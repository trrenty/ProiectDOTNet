using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectDOTNET.Models;
using ProjectDOTNET.Services;

namespace ProjectDOTNET.Pages
{
    public class IndexModel : PageModel
    {
        private readonly EquationServices _service;

        [BindProperty]
        public string Title { get; set; }
        public IndexModel(EquationServices service)
        {
            _service = service;
        }

        public IList<Equation> GetEquations { get; set; }

        public void OnGet()
        {
            GetEquations = _service.Get().ToList();
        }

        public void OnPostFindTitle()
        {
            Title = (Title == null) ? "" : Title;
            GetEquations = _service.FindByTitle(Title).ToList();
        }
    }
}

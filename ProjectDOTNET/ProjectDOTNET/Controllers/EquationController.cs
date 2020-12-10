using Microsoft.AspNetCore.Mvc;
using ProjectDOTNET.Models;
using ProjectDOTNET.Services;
using System.Collections.Generic;

namespace ProjectDOTNET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquationController: ControllerBase
    {
        private readonly EquationServices _equationService;

        public EquationController(EquationServices equationService)
        {
            _equationService = equationService;
        }

        [HttpGet]
        public ActionResult<List<Equation>> Get() => _equationService.Get();

        [HttpGet("{id:length(24)}", Name = "GetEquation")]
        public ActionResult<Equation> Get(string id)
        {
            var equation = _equationService.Get(id);

            if (equation == null)
            {
                return NotFound();
            }
            return equation;
        }

        [HttpPost]
        public ActionResult<Equation> Create(Equation equation)
        {
            _equationService.Create(equation);
            return CreatedAtRoute("GetEquation", new { id = equation.Id.ToString() }, equation);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Equation NewEquation)
        {
            var equation = _equationService.Get(id);

            if (equation == null)
            {
                return NotFound();
            }
            _equationService.Update(id, NewEquation);
            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var equation = _equationService.Get(id);
            if (equation == null)
            {
                return NotFound();
            }
            _equationService.Remove(equation.Id);
            return NoContent();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lab6DOTNET.Model;
using Lab6DOTNET.Data;

namespace Lab6DOTNET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoesController : ControllerBase
    {
        private readonly IToDoRepository _repository;
        public ToDoesController (IToDoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<List<ToDo>> Get() => _repository.GetAll().ToList();

        [HttpGet("{id}")]

        public ActionResult<ToDo> GetTaskById(int id) => _repository.GetById(id);

        [HttpGet("active")]

        public ActionResult<List<ToDo>> GetActiveTask() => _repository.GetAll().Where(t => !t.IsDone).ToList();


        [HttpGet("done")]

        public ActionResult<List<ToDo>> GetCompletedTasks() => _repository.GetAll().Where(t => t.IsDone).ToList();


        [HttpPost]
        public IActionResult Create(ToDo product)
        {
            _repository.Create(product);
            return CreatedAtAction(nameof(GetTaskById), new { id = product.Id }, product);
        }

        [HttpPut]
        public IActionResult Update(ToDo product)
        {
            _repository.Update(product);
            return CreatedAtAction(nameof(GetTaskById), new { id = product.Id }, product);
        }

        [HttpDelete("{id}")]

        public IActionResult Remove(int id)
        {
            if (_repository.GetById(id) != null)
            {
                _repository.RemoveByID(id);
                return Ok();

            }
            else return NotFound();
        }

        //    private readonly DataContext _context;

        //    public ToDoesController(DataContext context)
        //    {
        //        _context = context;
        //    }

        //    // GET: api/ToDoes
        //    [HttpGet]
        //    public async Task<ActionResult<IEnumerable<ToDo>>> GetToDos()
        //    {
        //        return await _context.ToDos.ToListAsync();
        //    }

        //    // GET: api/ToDoes/5
        //    [HttpGet("{id}")]
        //    public async Task<ActionResult<ToDo>> GetToDo(int id)
        //    {
        //        var toDo = await _context.ToDos.FindAsync(id);

        //        if (toDo == null)
        //        {
        //            return NotFound();
        //        }

        //        return toDo;
        //    }

        //    // PUT: api/ToDoes/5
        //    // To protect from overposting attacks, enable the specific properties you want to bind to, for
        //    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //    [HttpPut("{id}")]
        //    public async Task<IActionResult> PutToDo(int id, ToDo toDo)
        //    {
        //        if (id != toDo.Id)
        //        {
        //            return BadRequest();
        //        }

        //        _context.Entry(toDo).State = EntityState.Modified;

        //        try
        //        {
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!ToDoExists(id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }

        //        return NoContent();
        //    }

        //    // POST: api/ToDoes
        //    // To protect from overposting attacks, enable the specific properties you want to bind to, for
        //    // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //    [HttpPost]
        //    public async Task<ActionResult<ToDo>> PostToDo(ToDo toDo)
        //    {
        //        _context.ToDos.Add(toDo);
        //        await _context.SaveChangesAsync();

        //        return CreatedAtAction("GetToDo", new { id = toDo.Id }, toDo);
        //    }

        //    // DELETE: api/ToDoes/5
        //    [HttpDelete("{id}")]
        //    public async Task<ActionResult<ToDo>> DeleteToDo(int id)
        //    {
        //        var toDo = await _context.ToDos.FindAsync(id);
        //        if (toDo == null)
        //        {
        //            return NotFound();
        //        }

        //        _context.ToDos.Remove(toDo);
        //        await _context.SaveChangesAsync();

        //        return toDo;
        //    }

        //    private bool ToDoExists(int id)
        //    {
        //        return _context.ToDos.Any(e => e.Id == id);
        //    }
    }
}

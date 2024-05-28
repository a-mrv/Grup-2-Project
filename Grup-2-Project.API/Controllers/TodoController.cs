using Grup_2_Project.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Domain.Services;

namespace TodoApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly TodoService _todoService;

        public TodoController(TodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TodoItem>> Get()
        {
            return Ok(_todoService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<TodoItem> Get(Guid id)
        {
            var item = _todoService.GetById(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost]
        public ActionResult Post([FromBody] TodoItem item)
        {
            _todoService.Add(item, _todoService.Get_nextId());
            return CreatedAtAction(nameof(Get), new { id = item.Id }, item);
        }

       

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var item = _todoService.GetById(id);
            if (item == null)
            {
                return NotFound();
            }

            _todoService.Delete(id);
            return NoContent();
        }
    }
}

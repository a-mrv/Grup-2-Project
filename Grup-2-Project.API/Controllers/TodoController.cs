using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TodoApp.Domain.Models;
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
        public ActionResult<TodoItem> Get(int id)
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
            _todoService.Add(item);
            return CreatedAtAction(nameof(Get), new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] TodoItem item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            var existingItem = _todoService.GetById(id);
            if (existingItem == null)
            {
                return NotFound();
            }

            _todoService.Update(item);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
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

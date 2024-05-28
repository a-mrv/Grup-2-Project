using Grup_2_Project.Domain.Models;
using Grup_2_Project.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Grup_2_Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoService _todoService;

        public TodoController(TodoService todoService)
        {
            _todoService = todoService;
        }

        public async Task<IActionResult> Index()
        {
            var items = await _todoService.GetTodoItemsAsync();
            return ViewResult(items);
        }

        private IActionResult ViewResult(List<TodoItem> items)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> Add(TodoItem item)
        {
            if (ModelState.IsValid)
            {
                await _todoService.AddTodoItemAsync(item);
                return RedirectToAction("Index");
            }
            return ViewResult(item);
        }

        private IActionResult ViewResult(TodoItem item)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> Update(TodoItem item)
        {
            if (ModelState.IsValid)
            {
                await _todoService.UpdateTodoItemAsync(item);
                return RedirectToAction("Index");
            }
            return (IActionResult)item;
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await _todoService.DeleteTodoItemAsync(id);
            return RedirectToAction("Index");
        }
    }
}

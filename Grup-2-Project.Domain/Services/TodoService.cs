using Grup_2_Project.Domain.Models;

namespace TodoApp.Domain.Services
{
    public class TodoService
    {
        private readonly List<TodoItem> _todoItems = new List<TodoItem>();
        private int _nextId = 1;

        public IEnumerable<TodoItem> GetAll()
        {
            return _todoItems;
        }

        public TodoItem GetById(Guid id)
        {
            return _todoItems.FirstOrDefault(t => t.Id == id);
        }

        public int Get_nextId()
        {
            return _nextId;
        }

        public void Add(TodoItem item, Guid _nextId)
        {
            item.Id = _nextId;
            _todoItems.Add(item);
        }

        public void Update(TodoItem item)
        {
            var existingItem = _todoItems.FirstOrDefault(t => t.Id == item.Id);
            if (existingItem != null)
            {
                existingItem.Title = item.Title;
                existingItem.Description = item.Description;
                existingItem.IsCompleted = item.IsCompleted;
                existingItem.DueDate = item.DueDate;
                existingItem.Priority = item.Priority;
            }
        }

        public void Delete(Guid id)
        {
            var item = _todoItems.FirstOrDefault(t => t.Id == id);
            if (item != null)
            {
                _todoItems.Remove(item);
            }
        }

        public void Add(TodoItem item, int v)
        {
            throw new NotImplementedException();
        }
    }
}

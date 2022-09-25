using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOne.Pages.TodoFeature
{
    public class TodoState
    {
        public List<TodoItem> TodoItems { get; set; } = new();

        public bool CanClear => !TodoItems.Any(i => i.IsDone);

        public void AddTodo(TodoItem newTodo)
        {
            TodoItems.Add(newTodo);
        }
        public void ClearTodos()
        {
            TodoItems = TodoItems.Where(i => !i.IsDone).ToList();
        }
    }
}

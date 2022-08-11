using BlazorTodoApp.Client.Shared.Dtos;

namespace BlazorTodoApp.Client.Pages
{
    public partial class TodoList
    {
        public string TodoText { get; set; } = string.Empty;
        public IList<Todo> Todos { get; set; } = new List<Todo>();

        public void AddTodo() 
        {
            Todos.Add(new Todo
            {
                Text = TodoText
            });

            TodoText = string.Empty;
        }

        public void RemoveTodo(Todo todo)
        {
            Todos.Remove(todo);
        }
    }
}

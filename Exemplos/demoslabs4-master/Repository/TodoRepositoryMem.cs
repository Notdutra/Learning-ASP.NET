using System.Collections.Generic;
using System.Linq;
using demoslabs4.Dtos;

namespace demoslabs4.Repository
{
    public class TodoRepositoryMem : ITodoRepository
    {
        private List<Todo> todos;

        public TodoRepositoryMem() {
            Initialize();
        }

        private void Initialize()
        {
            todos = new List<Todo>();
            var todo1 = new Todo {
                Id = "todo1",
                Title = "Todo 1",
                Notes = "Do todo 1",
                Done = false
            };
            var todo2 = new Todo {
                Id = "todo2",
                Title = "Todo 2",
                Notes = "Do todo 2",
                Done = true
            };
            todos.Add(todo1);
            todos.Add(todo2);
        }

        public IEnumerable<Todo> All()
        {
            return todos;
        }

        public void Delete(string id)
        {
            todos.Remove(Find(id));
        }

        public bool Exists(string id)
        {
            return todos.Exists(item => item.Id == id);
        }

        public Todo Find(string id)
        {
            return todos.FirstOrDefault(item => item.Id == id);
        }

        public void Insert(Todo todo)
        {
            todos.Add(todo);
        }

        public void Update(Todo todo)
        {
            var item = Find(todo.Id);
            if (item != null) {
                item = todo;
            }
        }
    }
}
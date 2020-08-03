using System.Collections.Generic;
using demoslabs4.Dtos;

namespace demoslabs4.Repository
{
    public interface ITodoRepository
    {
        IEnumerable<Todo> All();
        Todo Find(string id);
        void Insert(Todo todo);
        void Update(Todo todo);
        void Delete(string id);
        bool Exists(string id);
    }
}
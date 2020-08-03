using System;
using demoslabs5.models;
using System.Linq;

namespace demoslabs5
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new TodoContext())
            {
                //Create
                Console.WriteLine("Inserindo TodoItem");
                db.Add(new TodoItem {Name="Todo", IsCompleted=false});
                db.Add(new TodoItem {Name="Outro Todo", IsCompleted=true});
                var cont = db.SaveChanges();
                Console.WriteLine(cont);

                //Read
                Console.WriteLine("Consultando TodoItem");
                var todos = db.TodoItems.OrderBy(t => t.Id);
                foreach (var todo in todos)
                {
                    Console.WriteLine(todo.Id);
                    Console.WriteLine(todo.Name);
                    Console.WriteLine(todo.IsCompleted);
                }

                //Update
                Console.WriteLine("Alterando TodoItem");
                var umtodo = db.TodoItems.Where(t => t.Id == 1).FirstOrDefault();
                if (umtodo != null)
                {
                    umtodo.IsCompleted = true;
                }
                cont = db.SaveChanges();
                Console.WriteLine(cont);

                //Read
                Console.WriteLine("Consultando TodoItem");
                todos = db.TodoItems.OrderBy(t => t.Id);
                foreach (var todo in todos)
                {
                    Console.WriteLine(todo.Id);
                    Console.WriteLine(todo.Name);
                    Console.WriteLine(todo.IsCompleted);
                }

                //Delete
                Console.WriteLine("Removendo TodoItem");
                db.Remove(umtodo);
                cont = db.SaveChanges();
                Console.WriteLine(cont);

                //Read
                Console.WriteLine("Consultando TodoItem");
                todos = db.TodoItems.OrderBy(t => t.Id);
                foreach (var todo in todos)
                {
                    Console.WriteLine(todo.Id);
                    Console.WriteLine(todo.Name);
                    Console.WriteLine(todo.IsCompleted);
                }
            }            
        }
    }
}

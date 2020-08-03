using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demoslabs4.Dtos;
using demoslabs4.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace demoslabs4.Controllers
{
    [ApiController]
    [Route("api/todos")]
    public class TodoController : ControllerBase
    {
        private ITodoRepository repository;
        public TodoController(ITodoRepository rep)
        {
            repository = rep;
        }

        //Rota: /api/todos/about
        [HttpGet("about")]
        public string GetAbout()
        {
            return "API de Todos";
        }

        //Rota: /api/todos
        [HttpGet]
        public IEnumerable<Todo> GetAll()
        {
            return repository.All();
        }

        //Rota: /api/todos/{id}
        [HttpGet("{id}")]
        public Todo GetById(string id)
        {
            return repository.Find(id);
        }

        //Rota: /api/todos
        [HttpPost]
        public IActionResult Create(Todo todo)
        {
            repository.Insert(todo);
            return StatusCode(201);
        }

        //Rota: /api/todos/{id}
        [HttpDelete("{id}")]
        public ActionResult<Todo> Delete(string id)
        {
            var item = repository.Find(id);
            if (item == null) {
                return NotFound();
            }
            repository.Delete(id);
            return item;
        }
    }
}

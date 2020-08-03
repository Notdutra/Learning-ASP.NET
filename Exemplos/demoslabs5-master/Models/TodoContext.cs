using Microsoft.EntityFrameworkCore;

namespace demoslabs5.models
{
    public class TodoContext: DbContext
    {
        public DbSet<TodoItem> TodoItems {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("todos");
        }
    }
    
}
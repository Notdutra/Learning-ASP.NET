using Microsoft.EntityFrameworkCore;

namespace demoslabs7
{
    public class TodoContext : DbContext
    {
        public DbSet<TodoItem> TodoItems {get; set;}
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }
    }
    
}
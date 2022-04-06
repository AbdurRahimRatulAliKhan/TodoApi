using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
#pragma warning disable CS1591
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base (options)
        {

        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
#pragma warning disable CS1591
}




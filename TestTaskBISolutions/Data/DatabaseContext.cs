using Microsoft.EntityFrameworkCore;
using TestTaskBISolutions.Models;

namespace TestTaskBISolutions.Data
{
    public class DatabaseContext:DbContext
    {
        public DbSet<ToDo> ToDoLists { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.Migrate();
        }
    }
}

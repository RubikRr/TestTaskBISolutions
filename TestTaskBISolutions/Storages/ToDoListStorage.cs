using TestTaskBISolutions.Data;
using TestTaskBISolutions.Interfaces;
using TestTaskBISolutions.Models;

namespace TestTaskBISolutions.Storages
{
    public class ToDoListStorage:IToDoListStorage
    {
        private DatabaseContext databaseContext { get; set; }
        public ToDoListStorage(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public void Add(string content)
        {
            databaseContext.Add(new ToDo {Content=content });
            databaseContext.SaveChanges();
        }

        public List<ToDo> GetAll() { return databaseContext.ToDoLists.ToList(); }
    }
}

using Microsoft.AspNetCore.Mvc;
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
		public void Edit(ToDo newToDo)
		{
			var existingtoDo = GetById(newToDo.Id);
			existingtoDo.Content = newToDo.Content;
			databaseContext.SaveChanges();
		}


		public ToDo GetById(Guid id)
        {
            return databaseContext.ToDoLists.FirstOrDefault(toDo => toDo.Id == id);
        }
        public List<ToDo> GetAll() { return databaseContext.ToDoLists.ToList(); }

        public void Delete(Guid id)
        {
            var toDo=GetById(id);
            databaseContext.ToDoLists.Remove(toDo);
            databaseContext.SaveChanges();
        }
    }
}

using TestTaskBISolutions.Data;
using TestTaskBISolutions.Models;

namespace TestTaskBISolutions.Interfaces
{
	public interface IToDoListStorage
	{
		public void Add(string content);
		public List<ToDo> GetAll();
		public ToDo GetById(Guid id);
		public void Delete(Guid id);
		public void Edit(ToDo newToDo);
	}
}

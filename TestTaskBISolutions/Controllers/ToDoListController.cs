using Microsoft.AspNetCore.Mvc;
using TestTaskBISolutions.Data;
using TestTaskBISolutions.Interfaces;
using TestTaskBISolutions.Models;

namespace TestTaskBISolutions.Controllers
{
    public class ToDoListController : Controller
    {
        private IToDoListStorage toDoListStorage;
        public ToDoListController(IToDoListStorage toDoListStorage)
        {
            this.toDoListStorage = toDoListStorage;
        }
        public IActionResult Index()
        {
            var toDoList = toDoListStorage.GetAll();
            return View(toDoList);
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(string content)
        {
           toDoListStorage.Add(content);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(Guid id)
        {
            var toDo = toDoListStorage.GetById(id);
            return View(toDo);
        }
        [HttpPost]
        public IActionResult Edit(ToDo newContent)
        {
            toDoListStorage.Edit(newContent);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(Guid id)
        {
            toDoListStorage.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

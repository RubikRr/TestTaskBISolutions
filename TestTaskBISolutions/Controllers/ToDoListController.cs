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
    }
}

using Microsoft.AspNetCore.Mvc;

namespace TestTaskBISolutions.Controllers
{
    public class ToDoListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

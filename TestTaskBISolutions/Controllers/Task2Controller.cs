using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestTaskBISolutions.Models;
namespace TestTaskBISolutions.Controllers
{
    public class Task2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string str)
        {
            ViewBag.Str = str;
            return View(nameof(Index), IsPalindrome(str));
            
        }

        public bool IsPalindrome(string str)
        {
            int length = str.Length;
            for (int i = 0; i < length; i++)
            {
                if (str[i] != str[^(i + 1)])
                    return false;
            }
            return true;
        }
    }
}

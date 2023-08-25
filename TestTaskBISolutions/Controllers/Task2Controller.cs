using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
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
            if (string.IsNullOrEmpty(str))
            {
                return View();
            }
            ViewBag.Str = str;
            return View(nameof(Index), IsPalindrome(str));
            
        }

        public bool IsPalindrome(string str)
        {
            
            var normolizeStr = string.Join("", str.ToLower().Trim().Split().Where(s => !string.IsNullOrEmpty(s)));
            int length = normolizeStr.Length;
            for (int i = 0; i < length; i++)
            {
                if (normolizeStr[i] != normolizeStr[^(i + 1)])
                    return false;
            }
            return true;
        }
    }
}

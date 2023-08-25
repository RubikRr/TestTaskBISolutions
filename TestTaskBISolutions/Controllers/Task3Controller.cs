using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TestTaskBISolutions.Controllers
{
    public class Task3Controller : Controller
    {
        public IActionResult Index()
        {
            var linkedList = new LinkedList { };
            
            for (int i = 10; i >= 0; i--)
            {
                linkedList.Add(i);
            }
            var originalLinkedList = linkedList.ToString();
            ViewBag.OriginalLinkedList = originalLinkedList;
            linkedList.Sort();
            var ans = linkedList.ToString();
            return View(nameof(Index),ans);
        }
    }
}

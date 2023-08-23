using Microsoft.AspNetCore.Mvc;

namespace TestTaskBISolutions.Controllers
{
    public class Task1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string numbers)
        {
            var numbersToDouble=numbers?.Trim().Split().Where(number=>!string.IsNullOrEmpty(number)).Select(int.Parse).ToList() ??new List<int>();
            var ans=SumSecondOddNumber(numbersToDouble);
            ViewBag.Numbers = numbers;
            return View(nameof(Index),ans);
        }
        public int SumSecondOddNumber(List<int> numbers)
        {
            var oddNumbers = numbers.Where(x => x % 2 != 0).ToList();
            var sumSecondOddNumbers = 0;
            for (int i = 0; i < oddNumbers.Count(); i+=2)
            {
                sumSecondOddNumbers += Math.Abs(oddNumbers[i]);
            }
            return sumSecondOddNumbers;
        }

    }
}

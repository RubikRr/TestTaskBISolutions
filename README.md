# TestTaskBISolutions  
## Тестовое задание на позицию программист-разработчик C#/.Net(Junior)  
![изображение](https://github.com/RubikRr/TestTaskBISolutions/assets/65467062/5429b54b-5fa0-440f-9449-9f00435413f7)  
**Решение задания №1**
```C#
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
```
**Решение задания №2**
```C#
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
```
**Решение задания №3**  
Реализация односвязного списка и сортировки слиянием. Классы LinkedList и LinkedListNode.  
**Решение задания №4**  
Реализация ToDO листа со списком задач.






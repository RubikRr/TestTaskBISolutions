# TestTaskBISolutions  
## Тестовое задание на позицию программист-разработчик C#/.Net(Junior)  
![изображение](https://github.com/RubikRr/TestTaskBISolutions/assets/65467062/5429b54b-5fa0-440f-9449-9f00435413f7)  
**Решение задания №1**
```C#
public int SumSecondOddNumber(List<int> numbers)
  {
    var oddNumbers = numbers.Where(x => x % 2 != 0).ToList
    var sumSecondOddNumbers = 0;
    for (int i = 0; i < oddNumbers.Count(); i+=2)
    {
      sumSecondOddNumbers += Math.Abs(oddNumbers[i]);
    }
    return sumSecondOddNumbers;
  }
```



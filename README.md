# TestTaskBISolutions  
## Тестовое задание на позицию программист-разработчик C#/.Net(Junior)  
![изображение](https://github.com/RubikRr/TestTaskBISolutions/assets/65467062/e2314aea-96d8-4366-8c3a-84d4dd2a05ed)  

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
![изображение](https://github.com/RubikRr/TestTaskBISolutions/assets/65467062/7f3b92a0-70ee-4c65-9384-0b510e07216a)  

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
![изображение](https://github.com/RubikRr/TestTaskBISolutions/assets/65467062/d94fa87b-30a5-49ec-913b-2ca949401b3c)  

**Решение задания №3**  
Реализация односвязного списка и сортировки слиянием. Классы LinkedList и LinkedListNode.  
![изображение](https://github.com/RubikRr/TestTaskBISolutions/assets/65467062/b8e4fe7d-bc7c-418a-a63c-46e311fc8367)  

**Решение задания №4**  
Реализация ToDO листа со списком задач.  
![изображение](https://github.com/RubikRr/TestTaskBISolutions/assets/65467062/2f842d39-4a8f-4dd0-8d6c-ef0edc08be9d)  
![изображение](https://github.com/RubikRr/TestTaskBISolutions/assets/65467062/ca6b590c-7835-43c3-8c41-85b734c560b0)  
![изображение](https://github.com/RubikRr/TestTaskBISolutions/assets/65467062/1c453539-b78c-4f11-a51f-e7091d6629d4)  
![изображение](https://github.com/RubikRr/TestTaskBISolutions/assets/65467062/f0307f8d-c4d1-4483-a9cb-d75187356eef)  
![изображение](https://github.com/RubikRr/TestTaskBISolutions/assets/65467062/0c961fbd-bc21-465b-a217-e4a9ed03e3bf)




**Время затраченное на тестовое фиксировал с помощью сервиса Clockify** 
![изображение](https://github.com/RubikRr/TestTaskBISolutions/assets/65467062/f0ba262c-aa70-45c1-8858-fb621aa1eed9)  
![изображение](https://github.com/RubikRr/TestTaskBISolutions/assets/65467062/15f29345-9a25-460f-825c-814eb06bbe7d)








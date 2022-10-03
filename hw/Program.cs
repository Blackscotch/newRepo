Console.WriteLine("Привет, человек! Тебе предстоит выполнить тестирование этого маленького кусочка кода. Спасибо за труды :)");

Console.WriteLine("Ты можешь задать с клавиатуры строковый массив, его элементы разделяй запятыми. Или нажми Enter для работы с заданным программой массивом.");

// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

string[] myArr = new string[] {"Hello", "2", "world", ":-)"};

// Console.ReadLine();
Console.WriteLine($"{String.Join(", ", GetNewArray(myArr))}");

string[] GetNewArray(string[] array)
{
    int count = 0;
    
    for (int i = 0; i < array.Length; i++)
    {   
        if(array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] newArray = new string[count];

    count = 0;

    for (int i = 0; i < array.Length; i++)
    {   
        if(array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }

    return newArray;
}
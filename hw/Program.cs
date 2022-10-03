Console.Clear();

Console.WriteLine("Привет, человек! Тебе предстоит выполнить тестирование этого маленького кусочка кода. Спасибо за труды :)");
Console.WriteLine("Ты можешь задать с клавиатуры строковый массив, его элементы разделяй запятыми. Или нажми Enter для работы с заданным программой массивом.");

string input = String.Empty;

string[] myArr = new string[] {"Hello", "2", "world", ":-)"};

Console.Write("Введи массив (пробел - тоже символ), или жми Enter: ");
input = Console.ReadLine();

if (input == "" || input == null)
{
    Console.WriteLine();
    Console.WriteLine("Был нажат Enter или строка пуста, потому работаем с заданным массивом");
    Console.WriteLine("Вот массив для работы:");
    PrintArray(myArr);
    Console.WriteLine();

    if(GetNewArray(myArr) != null)
    {
        Console.WriteLine($"Новый массив с элементами < 4-х символов: [{String.Join(", ", GetNewArray(myArr))}];");
    }
    else
    {
        Console.WriteLine($"В массиве [{String.Join(", ", myArr)}] нет подходящих элементов");
    }
}
else
{
    char[] separators = new char[] {','};
    myArr = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    Console.WriteLine();
    Console.WriteLine("Был введен массив с клавиатуры, потому работаем  с твоим массивом.");
    Console.WriteLine($"Вот такой массив ты создал:");
    PrintArray(myArr);
    Console.WriteLine();
    if(GetNewArray(myArr) != null)
    {
        Console.WriteLine($"Новый массив с элементами < 4-х символов: [{String.Join(", ", GetNewArray(myArr))}];");
    }
    else
    {
        Console.WriteLine($"В массиве [{String.Join(", ", myArr)}] нет подходящих элементов");
    }
    
}



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

    if (count > 0)
    {
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
    else return null;
    
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]},");
    }
}

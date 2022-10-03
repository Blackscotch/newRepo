Console.Clear();

Console.WriteLine("Привет, человек! Тебе предстоит выполнить тестирование этого маленького кусочка кода. Спасибо за труды :)");
Console.WriteLine("Ты можешь задать с клавиатуры строковый массив, его элементы разделяй запятыми. Или нажми Enter для работы с заданным программой массивом.");

string[] myArr = new string[] {"Hello", "2", "world", ":-)"};

Console.Write("Введи массив через запятую (пробел - тоже символ), или жми Enter: ");
string input = Console.ReadLine();

if (input == "" || input == null)
{
    Console.WriteLine("Был нажат Enter или строка пуста, потому работаем с заданным массивом");
    Console.WriteLine($"{String.Join(", ", GetNewArray(myArr))}");
}
else
{
    char[] separators = new char[] {','};
    myArr = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    Console.WriteLine($"{String.Join(", ", GetNewArray(myArr))}");
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


// ---------------------------------------------------------------------
//                                 Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// * Сделать вариант через СЛОВАРЬ четырехзначных палиндромов
// ---------------------------------------------------------------------

// Чтение данных из консоли
int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Проверяем на пятизначность и палиндром
bool TestPalindrom(int number)
{
    // 11111 11211 11311
    // 12121 12221 12321
    // 13131
    if (number > 9999 && number < 100000)
    {
        if ((number / 10000 == number % 10) && ((number / 1000) % 10 == (number / 10) % 10))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    else
    {
        Console.WriteLine("Число не пятизначное!");
        return false;
    }
}

// Заполняем словарь
Dictionary<int, int> MakeDIctionary()
{
    Dictionary<int, int> palidrom = new Dictionary<int, int>();
    int numPalindrom = 10001;
    for (int k = 0; k < 9; k++)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                palidrom.Add(k * 100 + i * 10 + j, numPalindrom);
                numPalindrom += 100;
            }
            numPalindrom += 10;
        }
        numPalindrom -= 99;
    }

    return palidrom;
}

// Печатаем словарь
void PrintDictionary(Dictionary<int, int> palidrom)
{
    foreach (var num in palidrom)
    {
        Console.WriteLine($"key: {num.Key}  value: {num.Value}");
    }
}

// Проверяем на принадлежность словарю
bool TestContainsDictionary(int number, Dictionary<int, int> palidrom)
{
    return palidrom.ContainsValue(number);
}

// Печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Проверяем на полидром число любой длины
bool TestPalidromLength(int number)
{
    int result = (int)Math.Log10(number) + 1;
    while (result > 1)
    {
        if ((int)(number / (Math.Pow(10, result - 1))) == number % 10)
        {
            number = (int)(number % (Math.Pow(10, result - 1)));
            number = number / 10;
        }
        else
        {
            return false;
        }
        result -= 2;
    }
    return true;
}

int number = ReadData("Введите палиндром: ");

DateTime d1 = DateTime.Now;
PrintResult("1) " + TestPalindrom(number).ToString());
Console.WriteLine(DateTime.Now - d1);

Dictionary<int, int> palidrom = MakeDIctionary();
//PrintDictionary(palidrom);

DateTime d2 = DateTime.Now;
PrintResult(TestContainsDictionary(number, palidrom) ? "2) Да" : "2) Нет");
Console.WriteLine(DateTime.Now - d2);

DateTime d3 = DateTime.Now;
PrintResult(TestPalidromLength(number) ? "3) Да" : "3) Нет");
Console.WriteLine(DateTime.Now - d3);

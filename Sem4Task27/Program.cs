// ---------------------------------------------------------------------
//                                 Задача 27
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// ---------------------------------------------------------------------

// Чтение данных из консоли
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Чтение данных из консоли (return string)
string ReadDataString(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Возвращаем значение
    return Console.ReadLine() ?? "0";
}

// Печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// выдаёт сумму цифр в числе
int SumDigit(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}

// выдаёт сумму цифр в числе (через string)
int CalculateDigits(string line)
{
    int sum = 0;
    for (int i = 0; i < line.Length; i++)
    {
        sum += line[i] - '0';
    }
    return sum;
}

int number = ReadData("Введите число: ");
string numberStr = ReadDataString("Введите число: ");

DateTime d1 = DateTime.Now;
PrintResult("1) Количество цифр в числе: " + SumDigit(number));
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
PrintResult("2) Количество цифр в числе: " + CalculateDigits(numberStr));
Console.WriteLine(DateTime.Now - d2);

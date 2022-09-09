// ---------------------------------------------------------------------
//                                 Задача 28
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
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

// Печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

long MultA(int numA)
{
    int i = 1;
    long sum = 1;
    while (i <= numA)
    {
        sum = sum * i;
        i++;
    }
    return sum;
}

// Анатолий рекурсия
long CalcData(int num)
{
    if (num == 1)
        return 1;
    return num * CalcData(num - 1);
}

// константин
long CalculateFactorial(int num)
{
    int factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        factorial = factorial * i;
    }
    return factorial;
}



int number = ReadData("Введите число: ");

PrintResult("произведение чисел от 1 до N: " + MultA(number));
// ---------------------------------------------------------------------
//                                 Задача 25
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
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

// Возводим numA  в степень numB
long Pow(int numA, int numB)
{
    long res = 1;
    for (int i = 0; i < numB; i++)
    {
        res = res * numA;
    }
    return res;
}

// Возводим numA  в степень numB(c Math.Pow)
double MathPowCalc(int numA, int numB)
{
    return Math.Pow(numA, numB);
}

int numA = ReadData("Введите число A: ");
int numB = ReadData("Введите число B: ");

DateTime d1 = DateTime.Now;
PrintResult("1) " + Pow(numA, numB));
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
PrintResult("2) " + MathPowCalc(numA, numB));
Console.WriteLine(DateTime.Now - d2);


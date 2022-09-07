// ---------------------------------------------------------------------
//                                 Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// ---------------------------------------------------------------------

// чтение данных из консоли
int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// создаёт строчку от 1 до N(+i) и вторую от 1 до N^3(+i^3)
void LineNumbersPow(int numberN, int pow)
{
    int i = 1;
    string outLine = string.Empty;
    while (i <= numberN)
    {
        Console.Write("{0,7}" ,Math.Pow(i, pow));
        i++;
    }
    Console.WriteLine();
}

int num = ReadData("Введите число N: ");

LineNumbersPow(num, 1);
LineNumbersPow(num, 3);
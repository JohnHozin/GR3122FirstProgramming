// ---------------------------------------------------------------------
//                                 Задача 69
// примает на вход число и возвращает сумму числа
// ---------------------------------------------------------------------

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(string prefix)
{
    Console.WriteLine(prefix);
}

// Функция Аккермана
int funcAkkerman(int m, int n)
{
    if (m < 0 || n < 0) return -1;
    if (m == 0) return n + 1;
    if (n == 0) return funcAkkerman(m - 1, 1);
    return funcAkkerman(m - 1, funcAkkerman(m, n - 1));
}

int m = ReadData("Введите число m: ");
int n = ReadData("Введите число n: ");

PrintResult(funcAkkerman(m, n) == -1 ? "Введите положительные числа!" : funcAkkerman(m, n).ToString());



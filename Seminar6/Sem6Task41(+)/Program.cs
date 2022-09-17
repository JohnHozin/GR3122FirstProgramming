// ---------------------------------------------------------------------
//                                 Задача 41(+)
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и
// выдает сколько чисел больше 0 было введено.
// ---------------------------------------------------------------------

using System.Text.RegularExpressions;

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

// // Печать результата
// void PrintResult(string prefix, string data)
// {
//     Console.WriteLine(prefix + data);
// }

// // Считаем положительные числа
// int Count(int m)
// {
//     // int res = 0;
//     // for (int i = 0; i < m; i++)
//     // {
//     //     int key = 0;
//     //     //int num = ReadData("Введите число: ");
//     //     key = Console.ReadKey();
//     //     if (key > 0) res++;
//     // }

//     // return res;

// }

// PrintResult("Пользователь ввёл чисел больше ноля: ", Count(ReadData("Введите количество чисел: ")).ToString());

// //*
// // key = Console.ReadKey();
// // key = ConsoleKey.D0;
// // key = ConsoleKey.NumPad0;



//  Метод Анатолия
// Считывание клавиши.
string ReadRow(int count)
{
    string row = string.Empty;
    for (int i = 0; i < count; i++)
    {
        row += Console.ReadKey(true).KeyChar.ToString();
    }
    return row;
}

// Печать строки.
void PrintData(string data, string pref = "", string post = "", string end = "\n")
{
    Console.Write($"{pref}{data}{post}{end}");
}

// Список положительных чисел.
MatchCollection GetNumbers(string row)
{
    Regex regex = new Regex(@"(?<!-[0-9]*)0*[1-9]+[0-9]*");
    MatchCollection matches = regex.Matches(row);
    return matches;
}

string row = ReadRow(ReadData("Введите число "));
MatchCollection matches = GetNumbers(row);

PrintData(matches.Count.ToString(), "Вы ввели ", " положительных чисел.");
PrintData(row, "Исходная строка: ");
PrintData(string.Join(", ", matches), "Список положительных чисел: [", "]");

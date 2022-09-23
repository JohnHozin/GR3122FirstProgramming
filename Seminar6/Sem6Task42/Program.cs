// ---------------------------------------------------------------------
//                                 Задача 42
// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.
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

// Печать результата
void PrintResult(string prefix,string data)
{
    Console.WriteLine(prefix + data);
}

//получает обратную запись двоичного числа из дсятичного
List<int> Convert(int number)
{
    int temp = 0;
    List<int> reverse = new List<int>();
    while (number > 0)
    {
        temp = number % 2;
        number = number / 2;
        reverse.Add(temp);
    }
    return reverse;
}

//переворачивает число и возвращает прямую запись двоичного числа.
// int Reverse(List<int> reverse)
// {
//     int[] arr = new int[reverse.Count];
//     for (int i = reverse.Count - 1; i >= 0; i--)
//     {
//         arr[reverse.Count - 1 - i] = reverse[i];
//     }
//     return Convert.ToInt32(string.Join<int>("", arr));
// }

// int number = ReadData("Введите число: ");
// PrintResult("",Reverse(Convert(number)).ToString());
// PrintResult("Входное число в бинарном формате: ", "");


// Константин
// // Метод считывания данных пользователя
// int ReadData(string line)
// {
//     // Выводим сообщение
//     Console.Write(line);
//     // Считываем число
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     // Возвращаем значение
//     return number;
// }

// // Метод, принимает строку, выводит в консоль
// void PrintResult(string line)
// {
//     Console.WriteLine(line);
// }

// string DecToBin(int number)
// {
//     string binNumber = "";

//     while (number > 0)
//     {
//         binNumber = number % 2 + binNumber;
//         number = number / 2;
//     }

//     return binNumber;
// }

// int inputNumber = ReadData("Введите число: ");

// PrintResult($"Число {inputNumber} в двоичном представлении: {DecToBin(inputNumber)}");



// АНатоллий
// // Метод считывания данных пользователя
// string ReadData(string line)
// {
//     // Выводим сообщение
//     Console.Write(line);
//     return Console.ReadLine() ?? "0";
// }
// string numb = ReadData("Введите число: ");
// string numbBin = Convert.ToString(Convert.ToInt32(numb, 10), 2);

// Console.Write($"Число {numb} в двоичной системе: {numbBin}");
// Метод считывания данных пользователя
// int ReadData(string line)
// {
//     // Выводим сообщение
//     Console.Write(line);
//     // Считываем число
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     // Возвращаем значение
//     return number;
// }

// int numb = ReadData("Введите число: ");
// string numbBin = Convert.ToString(numb, 2);

// Console.Write($"Число {numb} в двоичной системе: {numbBin}");

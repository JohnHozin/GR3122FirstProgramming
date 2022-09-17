// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел от 1 до
// N.

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

// 1 2 3 4 5 6 
// 1 4 9 16 25 36
// string LineNumbers(int numberN)
// {
//     int i = 1;
//     string outLine = string.Empty;
//     while (i < numberN)
//     {
//         outLine = outLine + i + "\t";
//         i++;
//     }
//     outLine = outLine + numberN;
//     return outLine;
// }

// создаёт строчку от 1 до N(+i) и вторую от 1 до N^2(+i^2)
string LineNumbersPow(int numberN, int pow)
{
    int i = 1;
    string outLine = string.Empty;
    while (i < numberN)
    {
        outLine = outLine + Math.Pow(i,pow) + "\t";
        i++;
    }
    outLine = outLine + Math.Pow(numberN,pow);
    return outLine;
}

// string LineSqer(int numberN)
// {
//     int i = 1;
//     string outLine = string.Empty;
//     while (i < numberN)
//     {
//         outLine = outLine + i*i + "\t";
//         i++;
//     }
//     outLine = outLine + numberN*numberN;
//     return outLine;
// }

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Введите число N: ");
// string lineTop = LineNumbers(num);
// string lineDown = LineSqer(num);

// PrintResult(lineTop);
// PrintResult(lineDown);

PrintResult(LineNumbersPow(num,1));
PrintResult(LineNumbersPow(num,2));
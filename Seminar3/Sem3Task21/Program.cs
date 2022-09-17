// ---------------------------------------------------------------------
//                                 Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.
// * Сделать метод загрузки точек
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

// Вычисляем расстояние между двумя точками
double Calculate(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Соберем данные
int x1 = ReadData("Введите x1: ");
int y1 = ReadData("Введите y1: ");
int z1 = ReadData("Введите z1: ");

int x2 = ReadData("Введите x2: ");
int y2 = ReadData("Введите y2: ");
int z2 = ReadData("Введите z2: ");

// Выводим результат
PrintResult("1) " + Math.Round(Calculate(x1, y1, z1, x2, y2, z2), 2).ToString());

// Чтение данных
string ReadDataString()
{
    Console.WriteLine("Введите точки в формате: x(1,2,3);y(1,2,3) ");
    string numberStr = Console.ReadLine() ?? "";
    return numberStr;
}

// Вычисляем расстояние между двух точек
double CalculateString(string numberStr)
{
    numberStr = numberStr.Substring(2);
    numberStr = numberStr.Substring(0, numberStr.Length - 1);
    numberStr = numberStr.Replace(");y(", ",");
    string[] dots = numberStr.Split(",");
  
    int x1 = int.Parse(dots[0]);
    int y1 = int.Parse(dots[1]);
    int z1 = int.Parse(dots[2]);

    int x2 = int.Parse(dots[3]);
    int y2 = int.Parse(dots[4]);
    int z2 = int.Parse(dots[5]);
    
    return Math.Round(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1)),2);
    //    x(2,4,5);y(4,5,6)    2.45
    //    x(3,6,8);y(2,1,-7)  15.84
    //    x(7,-5,0);y(1,-1,9)  11.53
}

PrintResult("2) " + CalculateString(ReadDataString()).ToString());

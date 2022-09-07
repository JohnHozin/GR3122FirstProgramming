// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.

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
double Calculate(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Соберем данные
int x1 = ReadData("Введите x1: ");
int x2 = ReadData("Введите x2: ");
int y1 = ReadData("Введите y1: ");
int y2 = ReadData("Введите y2: ");

// Выводим результат
PrintResult(Math.Round(Calculate(x1, x2, y1, y2), 2).ToString());
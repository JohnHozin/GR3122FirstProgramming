// ---------------------------------------------------------------------
//                                 Задача 47
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)
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

// Создаём список цветов терминала
ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

// Печать двумерного массива
void Print2DArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            string number = matr[i, j].ToString("0.00");

            for (int k = 0; k < number.Length; k++)
            {
                Console.ForegroundColor = col[new System.Random().Next(0, 16)];
                Console.Write(number[k]);
                Console.ResetColor();
            }
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

// Заполняем массив случайными вещественными числами
void Fill2DArrayDouble(double[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Math.Round(new Random().NextDouble() * max - min, 2);
        }
    }
}

int m = ReadData("Введите количество столбцов: ");
int n = ReadData("Введите количество строк: ");
double[,] matrix = new double[m, n];

Fill2DArrayDouble(matrix, 0, 9);
Print2DArray(matrix);


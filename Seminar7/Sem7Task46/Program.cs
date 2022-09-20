// ---------------------------------------------------------------------
//                                 Задача 46
// Задайте двумерный массив размером m×n,
//заполненный случайными целыми числами.
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

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Заполняем массив случайными числами
void Fill2DArray(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
}

int m = ReadData("Введите количество столбцов");
int n = ReadData("Введите количество строк");
int[,] matrix = new int[m, n];

Fill2DArray(matrix, -100, 100);
Print2DArray(matrix);
Print2DArrayColored(matrix);

// Универсальный метод генерации и заполнение двумерного массива
int[,] Fill2DArray1(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}

 
// Печать двумерного массива c цветом
void Print2DArrayColored(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}




///////////////////////////////////////////////////////
//значения b1, k1, b2 и k2 задаются пользователем.
// int ReadData(string line)
// {
//     Console.Write(line);
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     return number;
// }

// // печать результата
// void PrintData(string prefix, string data) //разбили на две части вывод в консоль
// {
//     Console.WriteLine(prefix + data); //сначала выводим prefix + а потом данные data\
// }

// // Универсальный метод генерации и заполнение двумерного массива
// int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
// {
//     System.Random rand = new System.Random();
//     int[,] array2D = new int[countRow, countColumn];
//     //   0 1 2 3
//     // 0 x
//     // 1       y
//     // 2
//     for (int i = 0; i < countRow; i++)
//     {
//         for (int j = 0; j < countColumn; j++)
//         {
//             array2D[i,j] = rand.Next(topBorder, downBorder + 1);
//         }
//     }
//     return array2D;
// }

// // Печать двумерного массива
// void Print2DArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
//                                         ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
//                                         ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
//                                         ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
//                                         ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
//                                         ConsoleColor.Yellow};

// // Печать двумерного массива цветом
// void Print2DArrayColored(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.ForegroundColor = col[new System.Random().Next(0,16)];
//             Console.Write($"{matr[i, j]} ");
//             Console.ResetColor(); 
//         }
//         Console.WriteLine();
//     }
// }


// int row = ReadData("Введите количество строк");
// int column = ReadData("Введите количество столбцов");

// int[,] arr2D = Fill2DArray(row,column,10,99);
// Print2DArrayColored(arr2D);

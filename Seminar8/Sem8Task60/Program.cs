// ---------------------------------------------------------------------
//                                 Задача 60
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// ---------------------------------------------------------------------

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать трёхмерного массива
void Print3DArray(int[,,] matr)
{
    for (int k = 0; k < matr.GetLength(2); k++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write($"{matr[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

// Заполняем массив случайными числами (не повторяющиеся)
void Fill3DArray(int[,,] matr, int min, int max)
{
    int[] arr = new int[matr.GetLength(0) * matr.GetLength(1) * matr.GetLength(2)];
    //int n = 1;
    int temp; int k; int m; int p=0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (k = 0; k < matr.GetLength(2); k++)
            {
                temp = new Random().Next(min, max + 1);
                for (m = 0; m < k; m++)
                {
                    if (arr[m] == matr[i, j, k])
                    {
                        break;
                    }
                }
                    if (m == k)
                    {
                        matr[i, j, k] = temp;
                        arr[p] = temp;
                        p++;
                    }
                

            }
        }
    }
}

// Заполняем массив случайными числами (повторяющиеся)
// void Fill3DArray(int[,,] matr, int min, int max)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             for (int k = 0; k < matr.GetLength(2); k++)
//             {
//                 matr[i, j, k] = new Random().Next(min, max + 1);
//             }
//         }
//     }
// }


int x = ReadData("Введите количество строк X: ");
int y = ReadData("Введите количество столбцов Y: ");
int z = ReadData("Введите количество единиц высоты Z: ");
int[,,] cube = new int[x, y, z];

Fill3DArray(cube, 10, 99);
Print3DArray(cube);


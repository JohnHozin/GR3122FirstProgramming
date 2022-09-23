// Вычисляем факториал
float factorial(int n)
{
    float i, x = 1;
    for (i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}

int i, n, c;
Console.WriteLine("Введите нужное количество строк треугольника Паскаля:");
string s = Console.ReadLine();
n = Convert.ToInt32(s);

for (i = 0; i < n; i++)
{
    // создаём после каждой строки n-i отступов от левой стороны консоли, 
    // чем ниже строка, тем меньше отступ
    for (c = 0; c <= (n - i); c++)
    {
        Console.Write(" ");
    }
    for (c = 0; c <= i; c++)
    {
        // создаём пробелы между элементами треугольника
        Console.Write(" ");
        //формула вычисления элементов треугольника
        Console.Write(factorial(i) / (factorial(c) * factorial(i - c)));
    }

    Console.WriteLine();
    // после каждой строки с числами отступаем две пустые строчки
    Console.WriteLine();
}
Console.ReadLine();




// // 54
// List<int> pow = new List<int>();
// pow.add(Array[i, j]);
// pow.Sort();

// //56
// int FindMinRow(int[,] arr)
// {
//     int min = int.MaxValue;
//     int sum = 0;
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             sum += arr[i, j];
//         }
//         if (min > sum)
//         {
//             min = sum;
//             outIndexRow = i;
//         }
//     }
//     return outIndexRow;
// }

// //60
// int[,,] a = new int[,,];

// a[i,j,k] = next

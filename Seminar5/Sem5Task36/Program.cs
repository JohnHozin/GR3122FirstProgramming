// ---------------------------------------------------------------------
//                                 Задача 36
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях.
// * Найдите все пары в массиве и выведите пользователю
// ---------------------------------------------------------------------

// Печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Заполняем массив
int[] GenArray(int arrLength, int start, int stop)
{
    int[] array = new int[arrLength];
    Random ren = new Random();

    for (int i = 0; i < arrLength; i++)
    {
        array[i] = ren.Next(start, stop + 1);
    }
    return array;
}

// печатаем массив
void PrintArray(int[] arr)
{
    Console.Write("[" + arr[0] + ", ");
    for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
    Console.WriteLine();
}

// считаем сумму элементов (с нечётным номером)
int EvenSumPos(int[] arr)
{
    int a = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        a += arr[i];
    }
    return a;
}

// ищем пары (одинаковые числа в массиве)
void FindSameInArr(int[] arr)
{
    List<int> tempNumbers = new List<int>();
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i; j < arr.Length - 1; j++)
        {
            if ((arr[i] == arr[j]) && i != j && !tempNumbers.Contains(arr[i]))
            {
                PrintResult("Пара равная = " + arr[i] + " имеет индексы " + i + " и " + j);
                tempNumbers.Add(arr[i]);
            }
        }
    }
}

int[] arr = GenArray(50, 1, 10);

PrintArray(arr);
PrintResult("Сумма = " + EvenSumPos(arr));

FindSameInArr(arr);

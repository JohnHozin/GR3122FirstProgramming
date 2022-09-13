// ---------------------------------------------------------------------
//                                 Задача 34
// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// * Отсортировать массив методом пузырька
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

// считаем чётные числа в массиве
int EvenCount(int[] arr)
{
    int a = 0;
    for (int i = 0; i < arr.Length; i++)
        if (EvenTest(arr[i])) a++;
    return a;
}

// проверка на чётность
bool EvenTest(int a)
{
    return a % 2 == 0;
}

// сортировка пузырьком
int[] BoobleSort(int[] arr)
{
    int tempNum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length - 1 - i; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                tempNum = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = tempNum;
            }
        }
    }
    return arr;
}


int[] arr = GenArray(50, 100, 999);

PrintArray(arr);
PrintResult("Чётных чисел в массиве: " + EvenCount(arr));

PrintArray(BoobleSort(arr));

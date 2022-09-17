// ---------------------------------------------------------------------
//                                 Задача 38(+)
// * Отсортируйте массив методом вставки и методом подсчета, а затем найдите
// разницу между первым и последним элементом. Для задачи со звездочкой
// использовать заполнение массива целыми числами.
// ---------------------------------------------------------------------

// сравнить метод вставки и метод подсчета по времени
// return arr[arr.Length-1] - arr[0];


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


// сортировка пузырьком
void BoobleSort(int[] arr)
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
}

// сортировка вставками
void SortInsertMethod(int[] arr)
{
    int x, i, j;
    for (i = 0; i < arr.Length; i++)
    {
        x = arr[i];
        for (j = i - 1; j >= 0 && arr[j] > x; j--)
            arr[j + 1] = arr[j];

        arr[j + 1] = x;
    }
}

// сортировка подсчётом
void countingSort(int[] arr, int min, int max)
{
    int[] count = new int[max - min + 1];
    int z = 0;

    for (int i = 0; i < count.Length; i++)
    {
        count[i] = 0;
    }
    for (int i = 0; i < arr.Length; i++)
    {
        count[arr[i] - min]++;
    }

    for (int i = min; i <= max; i++)
    {
        while (count[i - min]-- > 0)
        {
            arr[z] = i;
            z++;
        }
    }
}

// разница между max и min в отсортированном массиве
void PrintMaxMin(int[] arr)
{
    Console.WriteLine(arr[arr.Length-1] - arr[0]);
}

int[] arr = GenArray(50, 100, 999);
int[] arrVar2 = GenArray(50, 100, 999);
int[] arrVar3 = GenArray(50, 100, 999);

PrintArray(arr);
DateTime d1 = DateTime.Now;
BoobleSort(arr);
Console.WriteLine(DateTime.Now - d1);
PrintArray(arr);
PrintMaxMin(arr);
PrintResult("--------------");

PrintArray(arrVar2);
DateTime d2 = DateTime.Now;
SortInsertMethod(arrVar2);
Console.WriteLine(DateTime.Now - d2);
PrintArray(arrVar2);
PrintMaxMin(arrVar2);
PrintResult("--------------");

PrintArray(arrVar3);
DateTime d3 = DateTime.Now;
countingSort(arrVar3,100,999);
Console.WriteLine(DateTime.Now - d3);
PrintArray(arrVar3);
PrintMaxMin(arrVar3);

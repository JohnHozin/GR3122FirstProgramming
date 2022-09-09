// ---------------------------------------------------------------------
//                                 Задача 30
// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
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

// Печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int[] GenArray(int arrLength)
{
    int[] array = new int[arrLength];
    Random ren = new Random();

    for (int i = 0; i < arrLength; i++)
    {
        array[i] = ren.Next(0, 2);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1]);
}

PrintArray(GenArray(ReadData("Введите длину массива: ")));

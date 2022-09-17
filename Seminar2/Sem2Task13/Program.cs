// ---------------------------------------------------------------------
//                                 Задача 13
// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// ---------------------------------------------------------------------

Console.Write("Введите число: ");
string? inputLineA = Console.ReadLine();
Console.Write("Введите номер разряда: ");
string? inputLineRazrad = Console.ReadLine();
if (inputLineA != null && inputLineRazrad != null)
{
    // void Variant1()
    // {
    //     if (inputLineA.Length > 2)
    //     {
    //         Console.WriteLine("Variant1: " + inputLineA[2]);
    //     }
    //     else
    //     {
    //         Console.WriteLine("Variant1: Третьей цифры нет!");
    //     }
    // }

    // void Variant2()
    // {
    //     if (inputLineA.Length > 2)
    //     {
    //         char[] arr = inputLineA.ToCharArray();
    //         Console.WriteLine("Variant2: " + arr[2]);
    //     }
    //     else
    //     {
    //         Console.WriteLine("Variant2: Третьей цифры нет!");
    //     }
    // }

    long inputNumber = long.Parse(inputLineA);
    int razrad = int.Parse(inputLineRazrad);
    
    int DigitMiner(long number, int searchDigit)
    {
        int result = (int)Math.Log10(number) + 1;
        if (result >= searchDigit)
        {
            number = number / (long)Math.Pow(10, (result - searchDigit));
            result = (int)number % 10;
        }
        else
        {
            result = -1;
        }
        return result;
    }

    // Variant1();
    // Variant2();
    Console.WriteLine(DigitMiner(inputNumber, razrad));
}
else
{
    Console.WriteLine("Число введено не верно!");
}
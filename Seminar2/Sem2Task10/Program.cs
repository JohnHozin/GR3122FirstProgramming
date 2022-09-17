// ---------------------------------------------------------------------
//                                 Задача 10
// Напишите программу, которая принимает на вход трёхзначное число и на 
// выходе показывает вторую цифру этого числа.
// ---------------------------------------------------------------------

Console.Write("Введите целое трёхзначное число: ");
string? inputLineA = Console.ReadLine();
if (inputLineA != null)
{
    void Variant1()
    {
        if (inputLineA.Length == 3)  // работает только для трёхзначных чисел
        {

            int inputNumberA = int.Parse(inputLineA);
            int secondDigit = (inputNumberA / 10) % 10;
            Console.WriteLine("Variant1: " + secondDigit);
        }
        else
        {
            Console.WriteLine("Variant1: Число введено не верно!");
        }
    }

    void Variant2()
    {
        if (inputLineA.Length > 2)  // работает для любых чисел >99
        {
            Console.WriteLine("Variant2: " + inputLineA[1]);
        }
        else
        {
            Console.WriteLine("Variant2: Число введено не верно!");
        }
    }

    void Variant3()
    {
        if (inputLineA.Length > 2)  // работает для любых чисел >99
        {
            char[] arr = inputLineA.ToCharArray();
            Console.WriteLine("Variant3: " + arr[1]);
        }
        else
        {
            Console.WriteLine("Variant3: Число введено не верно!");
        }
    }

    Variant1();
    Variant2();
    Variant3();
}
else
{
    Console.WriteLine("Число введено не верно!");
}


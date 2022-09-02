// ---------------------------------------------------------------------
//                                 Задача 13
// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// ---------------------------------------------------------------------

Console.Write("Введите число: ");
string? inputLineA = Console.ReadLine();
if (inputLineA != null)
{
    void Variant1()
    {
        if (inputLineA.Length > 2)  
        {
            Console.WriteLine("Variant1: " + inputLineA[2]);
        }
        else
        {
            Console.WriteLine("Variant1: Третьей цифры нет!");
        }
    }

    void Variant2()
    {
        if (inputLineA.Length > 2)  
        {
            char[] arr = inputLineA.ToCharArray();
            Console.WriteLine("Variant2: " + arr[2]);
        }
        else
        {
            Console.WriteLine("Variant2: Третьей цифры нет!");
        }
    }

    Variant1();
    Variant2();
}
else
{
    Console.WriteLine("Число введено не верно!");
}
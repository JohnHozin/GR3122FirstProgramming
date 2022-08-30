//=======================================================
// # 4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//=======================================================

string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
string? inputLineC = Console.ReadLine();
if (inputLineA != null && inputLineB != null && inputLineC != null)
{
    int inputA = int.Parse(inputLineA);
    int inputB = int.Parse(inputLineB);
    int inputC = int.Parse(inputLineC);
    if (inputA > inputB)
    {
        if (inputA > inputC)
        {
            Console.WriteLine("max = " + inputA);
        }
        else
        {
            Console.WriteLine("max = " + inputC);
        }
    }
    else
    {
        if (inputB > inputC)
        {
            Console.WriteLine("max = " + inputB);
        }
        else
        {
            Console.WriteLine("max = " + inputC);
        }
    }
}
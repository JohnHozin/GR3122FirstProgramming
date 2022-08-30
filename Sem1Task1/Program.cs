//=======================================================
// # 1 Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго
//=======================================================

string? inputLineA = Console.ReadLine();  
string? inputLineB = Console.ReadLine(); 
if (inputLineA != null && inputLineB != null)
{
    int inputNumberA = (int) int.Parse(inputLineA);
    int inputNumberB = (int) int.Parse(inputLineB);

    //bool outResult = (inputLineA*inputLineA == inputLineB);
    //bool outResult = (inputLineB/inputLineA == inputLineA);
    bool outResult = (Math.Sqrt(inputNumberB) == inputNumberA);

    Console.WriteLine(outResult);
}
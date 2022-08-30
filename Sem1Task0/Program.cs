//=======================================================
// # 0 Напишите программу, которая на вход принимает число и
// выдаёт его квадрат (число умноженное на само себя).
//=======================================================

string? inputLine = Console.ReadLine();  // или вот так string inputLine = Console.ReadLine()??"";  это проверка на null
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    //int outNumber = inputNumber * inputNumber;
    int outNumber = (int)Math.Pow(inputNumber, 2);

    Console.WriteLine(outNumber);
}
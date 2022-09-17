//=======================================================
// # 8 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//=======================================================

string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    if (inputNumber < 2)
    {
        Console.WriteLine("Введите число больше 1");
    }
    // int startIndex = 1;
    // while (startIndex <= inputNumber)
    // {
    //     if (startIndex % 2 == 0)
    //     {
    //         Console.Write(startIndex + ", ");
    //     }
    //     startIndex++;
    // }

    // int startIndex = 2;
    // while (startIndex <= inputNumber)
    // {
    //     Console.Write(startIndex + ", ");
    //     startIndex += 2;
    // }

    // int startIndex = 2;
    // while (startIndex <= inputNumber)
    // {
    //     if (startIndex >= inputNumber - 1)
    //     {
    //         Console.Write(startIndex);
    //         startIndex += 2;
    //     }
    //     else
    //     {
    //         Console.Write(startIndex + ", ");
    //         startIndex += 2;
    //     }
    // }

//     int startIndex = 2;
//     while (startIndex <= inputNumber - 2)
//     {
//         Console.Write(startIndex + ", ");
//         startIndex += 2;
//     }
//     if (startIndex % 2 == 0)
//     {
//         Console.Write(startIndex);
//     }
// }    // new Random().Next(10,100);
}
Console.Write(new Random().Next(10,100));
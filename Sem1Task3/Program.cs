//=======================================================
// # 3 Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго
//=======================================================

string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputDayOfWeek = int.Parse(inputLine);

    // string[] dayOfWeek = new string[7];
    // dayOfWeek[0] = "Понедельник";
    // dayOfWeek[1] = "Вторник";
    // dayOfWeek[2] = "Среда";
    // dayOfWeek[3] = "Четверг";
    // dayOfWeek[4] = "Пятница";
    // dayOfWeek[5] = "Суббота";
    // dayOfWeek[6] = "Воскресенье";

    // if(inputDayOfWeek>7 || inputDayOfWeek<1)
    // {
    //     Console.WriteLine("Такого дня нет");
    // }
    // else
    // {
    //     Console.WriteLine(dayOfWeek[inputDayOfWeek-1]);
    // }

    string outDayOfWeek = string.Empty; // =""

    switch (inputDayOfWeek)
    {
        case1: outDayOfWeek = "Понедельник"; break;
        case2: outDayOfWeek = "Вторник"; break;
        case3: outDayOfWeek = "Среда"; break;
        case4: outDayOfWeek = "Четверг"; break;
        case5: outDayOfWeek = "Пятница"; break;
        case6: outDayOfWeek = "Суббота"; break;
        case7: outDayOfWeek = "Воскресенье"; break;
        default: outDayOfWeek = "Такого дня нет"; break;

        
    }


    Console.WriteLine(outDayOfWeek);
}

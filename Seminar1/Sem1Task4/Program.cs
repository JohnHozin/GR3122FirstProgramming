// //=======================================================
// // # 4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// //=======================================================

// string? inputLineA = Console.ReadLine();
// string? inputLineB = Console.ReadLine();
// string? inputLineC = Console.ReadLine();
// if (inputLineA != null && inputLineB != null && inputLineC != null)
// {
//     int inputA = int.Parse(inputLineA);
//     int inputB = int.Parse(inputLineB);
//     int inputC = int.Parse(inputLineC);
//     // if (inputA > inputB)
//     // {
//     //     if (inputA > inputC)
//     //     {
//     //         Console.WriteLine("max = " + inputA);
//     //     }
//     //     else
//     //     {
//     //         Console.WriteLine("max = " + inputC);
//     //     }
//     // }
//     // else
//     // {
//     //     if (inputB > inputC)
//     //     {
//     //         Console.WriteLine("max = " + inputB);
//     //     }
//     //     else
//     //     {
//     //         Console.WriteLine("max = " + inputC);
//     //     }
//     // }

//     //Console.WriteLine((inputA > inputC ? (inputA > inputC ? "max = " + inputA : "max = " + inputC) : (inputB > inputC ? "max = " + inputB : "max = " + inputC)));
//     Console.WriteLine(Math.Max(inputA, Math.Max(inputB, inputC)));
// }


//==========================================
// напишите программу которая будет выдавать название дня недели
//по заданному номеру
//==========================================

string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputDayofWeek = int.Parse(inputLine);

   // string[] dayofWeek = new string[7];
    // dayofWeek[0] = "Понедельник";
    //  dayofWeek[1] = "Вторник";
    // dayofWeek[2] = "Среда";
    // dayofWeek[3] = "Четверг";
    // dayofWeek[4] = "Пятница";
    // dayofWeek[5] = "Суббота";
    // dayofWeek[6] = "Воскресенье";
    //
    // if(inputDayofWeek > 7 || inputDayofWeek < 1)
    // {
    //      Console.WriteLine("Такого дня нет");
    //  }
    // else 
    //  {
    //      Console.WriteLine(dayofWeek[inputDayofWeek - 1]);
    //  }

string outDayofWeek = string.Empty;
 //   switch (inputDayofWeek)
  //  {
  //      case 1: outDayofWeek = "Понедельник"; break;
 //       case 2: outDayofWeek = "Вторник"; break;
  //      case 3: outDayofWeek = "Среда"; break;
  //      case 4: outDayofWeek = "Четверг"; break;
  //      case 5: outDayofWeek = "Пятница"; break;
  //      case 6: outDayofWeek = "Суббота"; break;
 //       case 7: outDayofWeek = "Воскресенье"; break;
 //       default: outDayofWeek  = "Такого дня нет"; break;
 //   }

outDayofWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputDayofWeek));

Console.WriteLine(outDayofWeek);

}
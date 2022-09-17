// ---------------------------------------------------------------------
//                                 Задача 9
// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру числа.
// ---------------------------------------------------------------------

// мой вариант
void mine()
{
    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(100, 1000);

    Console.WriteLine(number);

    int firstDigit = number / 100;
    int thirdDigit = number % 10;

    Console.WriteLine(firstDigit * 10 + thirdDigit);
}

// вариант Константина
void var2()
{
    Console.WriteLine("Вариант 1:");

    int number = new Random().Next(100, 1000);

    Console.WriteLine(number);

    char[] charArray = number.ToString().ToCharArray();
    Console.Write(charArray[0]);
    Console.WriteLine(charArray[2]);
}

// вариант Михаила
void var3()
{
    Console.WriteLine("Метод 1");
    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(100, 1000);

    Console.WriteLine(number);

    char[] charArray = number.ToString().ToCharArray();

    Console.WriteLine("" + charArray[0] + charArray[2]);
}

mine();
var2();
var3();




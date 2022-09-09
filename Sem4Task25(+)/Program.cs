// ---------------------------------------------------------------------
//                                 Задача 25*
// * НАпишите прогу c + - * / ^ 
// ---------------------------------------------------------------------

// Чтение данных из консоли
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Чтение данных из консоли (return string)
string ReadDataString(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Возвращаем значение
    return Console.ReadLine() ?? "0";
}

// Возводим numA  в степень numB(c Math.Pow)
void Calculate(int numA, int numB, string option)
{
    switch (option)
    {
        case "+":
            Console.WriteLine(numA + " + " + numB + " = " + (numA + numB));
            break;
        case "-":
            Console.WriteLine(numA + " - " + numB + " = " + (numA - numB));
            break;
        case "*":
            Console.WriteLine(numA + " * " + numB + " = " + (numA * numB));
            break;
        case "/":
            Console.WriteLine(numA + " / " + numB + " = " + (numA / numB));
            break;
        case "^":
            Console.WriteLine(numA + " ^ " + numB + " = " + (Math.Pow(numA, numB)));
            break;
        default:
            Console.WriteLine("Такого оператора нет!");
            break;
    }
}

int numA = ReadData("Введите число A: ");
int numB = ReadData("Введите число B: ");
string option = ReadDataString("Введите действие(+ - * / ^): ");

Calculate(numA, numB, option);

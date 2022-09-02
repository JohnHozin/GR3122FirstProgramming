// ---------------------------------------------------------------------
//                                 Задача 15
// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// ---------------------------------------------------------------------

Console.Write("Введите число от 1 до 7: ");
string? inputLineA = Console.ReadLine();
if (inputLineA != null)
{
    void Variant1()
    {
        int inputNumberA = int.Parse(inputLineA);
        if (inputNumberA > 0 && inputNumberA < 6)
        {
            Console.WriteLine("Variant1: Это будний день");
        }
        else
        {
            if (inputNumberA == 6 || inputNumberA == 7)
            {
                Console.WriteLine("Variant1: Это выходной день");
            }
            else
            {
                Console.WriteLine("Variant1: Введите правильное число!");
            }

        }
    }

    void Variant2()
    {
        int inputNumberA = int.Parse(inputLineA);
        if (inputNumberA > 0 && inputNumberA < 8)
        {
            Dictionary<int, string> dayOfWeek = new Dictionary<int, string>()  // Создаём коллекцию и заполняем её
            {
                {1,"Будний день"},
                {2,"Будний день"},
                {3,"Будний день"},
                {4,"Будний день"},
                {5,"Будний день"},
                {6,"Выходной день"},
                {7,"Выходной день"}
            };

            Console.WriteLine("Variant2: " + dayOfWeek[inputNumberA]);
        }
        else
        {
            Console.WriteLine("Variant2: Введите правильное число!");
        }
    }

    Variant1();
    Variant2();
}
else
{
    Console.WriteLine("Число не введено!");
}
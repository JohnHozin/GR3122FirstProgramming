﻿// ---------------------------------------------------------------------
//                                 Задача 40
// Напишите программу, которая принимает на вход
// три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины.
// ---------------------------------------------------------------------

// Чтение данных из консоли
int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

bool TrglTest(int a, int b, int c)
{
    if (a + b > c && a + c > b && b + c > a && a > 0 && b > 0 && c > 0) return true;
    return false;
}

int a = ReadData("Введите сторону треугольника а: ");
int b = ReadData("Введите сторону треугольника b: ");
int c = ReadData("Введите сторону треугольника c: ");

PrintResult(TrglTest(a, b, c) ? "Такой треугольник существует" : "Такого треугольника не существует");
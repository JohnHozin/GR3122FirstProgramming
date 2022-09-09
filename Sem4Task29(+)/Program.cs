﻿// ---------------------------------------------------------------------
//                                 Задача 29*
// Напишите программу, которая выбирает одного из нескольких введённых
// ---------------------------------------------------------------------

// Чтение данных из консоли
string ReadDataString(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Возвращаем значение
    return Console.ReadLine() ?? "0";
}

// Выбираем одного из нескольких введённых
void Choise(string line)
{
    string[] peoples = line.Split(",");
    Random ren = new Random();

    // for (int i = 0; i < peoples.Length; i++)
    // {
    //     Console.Write(peoples[i] + " ");
    // }
    Console.Write(peoples[ren.Next(0, peoples.Length)]);

}

string peoples = ReadDataString("Введите людей через запятую: ");

Choise(peoples);

﻿// Семинар № 2.

// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
Console.WriteLine("Введите трёхзначное число:");
int n = Convert.ToInt32(Console.ReadLine());

if (n >= 100 && n <= 999)
{
    int num_B = (n % 100 / 10);
    Console.WriteLine(num_B);
}
else
{
    Console.WriteLine("Введенное число не является трехзначным");
}
*/

// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
Console.WriteLine("Введите трёхзначное число:");
int n = Convert.ToInt32(Console.ReadLine());

if (n >= 100 && n <= 999)
{
    int num_B = (n % 10 );
    Console.WriteLine(num_B);
}
else
{
    Console.WriteLine("Введенное число не является трехзначным");
}
*/

// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
Console.WriteLine("Введите номер дня недели:");
int n = Convert.ToInt32(Console.ReadLine());

if (n == 6 || n == 7)
{
    Console.WriteLine ("Выходной день!") ;
}
else
{
    Console.WriteLine("Увы, это не выходной день!");
}
*/





// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int a = 100;
int b = 183;

int max = a;
int min = b;

if(a > max) max = a;
if(b > max) max = b;

if(a < min) min = a;
if(b < min) min = b;

Console.Write ("Минимум, ");
Console.WriteLine (min);

Console.Write ("Максимум, ");
Console.WriteLine (max);
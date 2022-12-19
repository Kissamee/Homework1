// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.WriteLine("Введите число a: ");
int num_A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int num_B = Convert.ToInt32(Console.ReadLine());

if (num_A > num_B)
{
    Console.WriteLine("a " + num_A + " > b " + num_B);
}
else
{
    Console.WriteLine("b " + num_B + " > a " + num_A);
}
// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

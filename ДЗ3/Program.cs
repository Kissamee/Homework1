// Семинар № 3.


//Задача 1 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
Console.Write("Введите пятизначное число, ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = (n / 10000);
int n5 = (n % 10);
int n2 = (n / 1000 % 10);
int n4 = (n / 10 % 10);

if (n1 == n5 && n2 == n4)
{
  Console.Write($"{n} является палиндромом");  
}
else
{
    Console.Write($"{n} не является палиндромом");    
}
*/

//Задача 2 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
Console.Write("Введите координаты первой точки x, ");
double x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты первой точки y, ");
double y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты первой точки z, ");
double z = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты второй точки x1, ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты второй точки y1, ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты второй точки z1, ");
double z1 = Convert.ToInt32(Console.ReadLine());

double a = (x1 - x) ;
double b = (y1 - y) ;
double c = (z1 - z) ;

double length = Math.Sqrt(a * a + b * b + c * c) ;
double length2 = Math.Round( length, 2 ) ;
Console.WriteLine($"Длинна отрезка {length2}") ;

*/

//Задача 3 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 



int n = ReadInt("Введите число, ");

for (int i = 1; i <= n; i++)
{
    Console.Write($"{i * i * i}, ");
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите число ");
// int x=Convert.ToInt32 ( Console.ReadLine());

// int num = x;
// int rev = 0;
// while (num > 0) 
// {
//     int dig = num % 10;
//     rev = rev * 10 + dig;
//     num = num / 10;
// }
// if (x == rev) 
// {
   Console.WriteLine($"Это палиндром");
} else 
{
    Console.WriteLine($"Это не палиндром");
}
// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координаты x точки а");
// int ax = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y точки а");
// int ay = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты z точки a");
// int az = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты x точки b");
// int bx = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y точки b");
// int by = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты z точки b");
// int bz = Convert.ToInt32(Console.ReadLine());

// double dist = Math.Sqrt(Math.Pow(bx-ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
// Console.WriteLine($"Расстояние между двумя точками равно {dist}");


// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу
//  кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число n");
// int n=Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= n; i++)
// Console.Write($"{Math.Pow(i, 3)}, ");

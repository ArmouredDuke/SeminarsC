﻿/*
Задача 1
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

// bool pal(int num) 
// {
//     if(num / 10000 == num % 10)
//     {
//         if(num / 1000 == (num / 10) % 10);
//         {
//              return true;
//         }
//     } 
//     else return false;
// }
// Console.WriteLine("Введите пятизначное число");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num < 100000 && num > 9999)
// {
//     bool finish = pal(num);
//     if(finish == true)
//     {
//         Console.WriteLine($"Число {num} является палиндромом");
//     }
//     else Console.WriteLine($"Число {num} не палиндром");    
// }
// else Console.WriteLine($"Введено не пятизначное число!");

/*
ЗДАЧА 2
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

// double space(double xa, double ya, double za, double xb, double yb, double zb)
// {
//     return Math.Round(Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2)),2);
// }
// Console.WriteLine("Write the X coordinate for point A");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Write the Y coordinate fot point A");
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Write the Z coordinate for point A");
// double za = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Write the X coordinate for point B");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Write the Y coordinate for point B");
// double yb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Write the Z coordinate for point B");
// double zb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Distance between points A and B -> {space(xa, ya, za, xb, yb, zb)}");

/*
ЗАДАЧА 3
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125   
*/

//РЕШЕНИЕ

// void cube(int n)
// {
//     int i = 1;
//     Console.Write($"{n} -> ");
//     while(i <= n)
//     {
//         double num = Math.Pow(i, 3);
//         Console.Write($"{num} ");
//         i++;
//     }

// }
// Console.WriteLine("Write number");
// int n = Convert.ToInt32(Console.ReadLine());
// cube(n);

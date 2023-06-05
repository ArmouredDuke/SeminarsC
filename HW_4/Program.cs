﻿// ЗАДАЧА 1 ->  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


// double Pows(int a, int b)
// {
//     return Math.Pow(a, b);
// }

// Console.WriteLine("Введите число А");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число В");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Число {a} в степени {b} -> {Pows(a,b)}");





// ЗАДАЧА 2 -> Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int Sum(int num)
// {
//     int result = 0;
//     while(num > 0)
//     {
//         int last = num % 10;
//         result = result + last;
//         num /= 10;
//     }
//     result = result + num;
//     return result;
// }

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Сумма цифр в числе {num} -> {Sum(num)}");


// ЗАДАЧА 3 -> Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// int[] MyArray (int size, int min, int max)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// } 

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Введите размер массива");
// int size =Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите минимально допустимое число в массиве");
// int min =Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите максимально допустимое число в массиве");
// int max =Convert.ToInt32(Console.ReadLine());

// int[] newArray = MyArray(size, min, max);
// Console.Write("Полученный массив -> ");
// PrintArray(newArray);


﻿/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

// double[,] Creat2DRandomArray(int rows, int colums, int minValue, int maxValue)
// {
//     double[,] array = new double[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue);
//             array[i, j] = array[i, j] + Math.Round(new Random().NextDouble(), 2);
//         }
//     }
//     return array;
// }

// void Print2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("write rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write colums");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write minValue");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write maxValue");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// double[,] MyArray = Creat2DRandomArray(rows, colums, minValue, maxValue);

// Print2DArray(MyArray);


/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

// int[,] Creat2DRandomArray(int rows, int colums, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void Value(int[,] array, int num)
// {
//     bool flag = false;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] == num)
//             {
//                 flag = true; 
//                 break;
//             }
//         }
//     }
//     if (flag == true) Console.WriteLine($"Число {num} ЕСТЬ в имеющемся массиве");
//     else Console.WriteLine($"Числа {num} в массиве НЕТ!");
// }

// Console.WriteLine("write rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write colums");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write minValue");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write maxValue");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Загадайте число");
// int num = Convert.ToInt32(Console.ReadLine());

// int[,] MyArray = Creat2DRandomArray(rows, colums, minValue, maxValue);

// Print2DArray(MyArray);
// Value(MyArray, num);

/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

// int[,] Creat2DRandomArray(int rows, int colums, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void SrAr(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         double summ = 0;
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             summ += array[j, i];
//         }
//         Console.WriteLine($"столбец {i + 1} -> {summ / array.GetLength(1)} ");
//     }

// }

// Console.WriteLine("write rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write colums");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write minValue");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write maxValue");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] MyArray = Creat2DRandomArray(rows, colums, minValue, maxValue);

// Print2DArray(MyArray);
// Console.WriteLine("Среднее арифметическое каждого столбца:");
// SrAr(MyArray);

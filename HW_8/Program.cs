﻿/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

//int[,] sorted(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int q = 0; q < array.GetLength(1) - 1 - j; q++)
//             {
//                 if (array[i, q] < array[i, q + 1])
//                 {
//                     int box = array[i, q];
//                     array[i, q] = array[i, q + 1];
//                     array[i, q + 1] = box;
//                 }
//             }
//         }
//     }
//     return array;
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
// MyArray = sorted(MyArray);
// Print2DArray(MyArray);


/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

// int[] SumRows (int [,] array)
// {
//     int [] temp = new int[array.GetLength(0)];
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         int summa = 0;
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             summa += array[i,j];
//         }
//         temp[i] = summa;
//     }
//     return temp;
// }

// void MinSum (int[] array)
// {
//     int min = array[0];
//     int rows = 0;
//     for(int k = 0; k < array.Length; k++)
//     {
//         if(array[k] < min) 
//         {
//             min = array[k];
//             rows = k;
//         }
//     }
//     Console.WriteLine($"В строке {rows + 1} минимальная сумма элементов, которая равна {min}");
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
// int[] temp = SumRows(MyArray);
// MinSum(temp);


/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

// int[,] MatrixMulti(int[,] arrayA, int[,] arrayB)
// {
//     int[,] arrayC = new int[arrayB.GetLength(0), arrayB.GetLength(1)];
//     for (int i = 0; i < arrayA.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayA.GetLength(1); j++)
//         {
//             for (int k = 0; k < arrayB.GetLength(1); k++)
//             {
//                 arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
//             }
//         }


//     }
//     return arrayC;
// }

// void CheckPrint(int[,] arrayA, int[,] arrayB)
// {
//     if (arrayA.GetLength(0) == arrayB.GetLength(0) && arrayA.GetLength(1) == arrayB.GetLength(1))
//     {
//         int[,] arrayC = MatrixMulti(arrayA, arrayB);
//         Print2DArray(arrayA);
//         Print2DArray(arrayB);
//         Console.WriteLine("Произведение матриц А и В");
//         Print2DArray(arrayC);
//     }
//     else Console.WriteLine("Размер матрицы А, должен быть равен размеру матрицы В");
// }

// Console.WriteLine("MATRIX A");
// Console.WriteLine("write rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write colums");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write minValue");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write maxValue");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] arrayA = Creat2DRandomArray(rows, colums, minValue, maxValue);

// Console.WriteLine("MATRIX B");
// Console.WriteLine("write rows");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write colums");
// int colums1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write minValue");
// int minValue1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write maxValue");
// int maxValue1 = Convert.ToInt32(Console.ReadLine());

// int[,] arrayB = Creat2DRandomArray(rows1, colums1, minValue1, maxValue1);

// CheckPrint(arrayA, arrayB);



/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

// int[,,] Creat3DRandomArray(int rows, int colums, int depth)
// {
//     int[,,] array = new int[rows, colums, depth];
//     int temp = new Random().Next(10, 100);
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             for (int k = 0; k < depth; k++)
//             {
//                 array[i, j, k] = new Random().Next(10, 100);
//                 if(array[i, j, k] == temp)
//                 {
//                     while(array[i, j, k] == temp)
//                     {
//                         array[i, j, k] = new Random().Next(10, 100);
//                     }
//                     temp = array[i, j, k];
//                 }
//                 else temp = array[i, j, k];
//             }
//         }
//     }
//     return array;
// }


// void Print3DArray(int[,,] array)
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
//             }
//             Console.WriteLine();
//         }

//     }
//     Console.WriteLine();
// }

// Console.WriteLine("write rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write colums");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write depth");
// int depth = Convert.ToInt32(Console.ReadLine());

// int[,,] MyArray = Creat3DRandomArray(rows, colums, depth);
// Print3DArray(MyArray);
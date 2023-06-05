// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2 */


// int[] NewArray (int size)
// {
//     int [] array = new int [size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100,999 + 1);
//     }
//     return array;
// }

// void Printarray (int [] MyArray)
// {
//     for(int i = 0; i < MyArray.Length; i++)
//     {
//         Console.Write($"{MyArray[i]} ");
//     }
//     Console.WriteLine();
// }

// int CountArray (int [] array)
// {
//      int count = 0;
//      for(int i = 0; i < array.Length; i++)
//     {
//          if (array[i] % 2 == 0) count++;
//      }
//      return count;
// }

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = NewArray(size);

// Printarray(myArray);
// Console.WriteLine($"Четных чисел в массиве -> {CountArray(myArray)}");


/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0  */

// void Printarray (int [] MyArray)
// {
//     for(int i = 0; i < MyArray.Length; i++)
//     {
//         Console.Write($"{MyArray[i]} ");
//     }
//     Console.WriteLine();
// }

// int[] NewArray (int size, int minimum, int maximum)
// {
//     int [] array = new int [size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minimum, maximum + 1);
//     }
//     return array;
// }

// int SumArray (int[] myArray)
// {
//     int sumcount = 0;
//     for(int i = 0; i < myArray.Length; i++)
//     {
//         if(i % 2 != 0) sumcount += myArray[i]; 
//     }
//     return sumcount;
// }

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите минимальное значение массива");
// int minimum = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите максимальное значение массива");
// int maximum = Convert.ToInt32(Console.ReadLine());

// int[] array = NewArray(size, minimum, maximum);

// Printarray(array);

// Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях массива -> {SumArray(array)}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] NewArray (int size, int minimum, int maximum)
// {
//     double [] array = new double [size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minimum, maximum + 1);
//         array[i] = array[i] + Math.Round(new Random().NextDouble(), 2);
//     }
//     return array;
// }

// void Printarray (double [] MyArray)
// {
//     for(int i = 0; i < MyArray.Length; i++)
//     {
//         Console.Write($"{MyArray[i]} ");
//     }
    
// }

// double Razn (double [] array)
// {
//     double maxi = array[0];
//     double mini = array[0];
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > maxi) maxi = array[i];
//         else
//         {
//             if(array[i] < mini) mini = array[i];
//         }

//     }
//     return Math.Round((maxi - mini), 2);
// }

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите минимальное значение массива");
// int minimum = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите максимальное значение массива");
// int maximum = Convert.ToInt32(Console.ReadLine());

// double[] array = NewArray(size, minimum, maximum);


// Printarray(array);

// Console.Write($"-> Разница между макксимальным и минимальным {Razn(array)}");
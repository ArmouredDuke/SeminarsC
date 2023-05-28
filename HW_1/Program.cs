//  Task 2.  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("Input first number:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2)
// {
//     Console.WriteLine($"The number {num1} is greater than the number {num2}.");
// }
// if (num1 < num2)
// {
//     Console.WriteLine($"The number {num1} is smoller than the number {num2}.");
// }
// if (num1 == num2)  // Тоже возможный вариант
// {    
//     Console.WriteLine($"The number {num1} is equal to the number {num2}.");
// }



//  Task 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Input first number:");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input second number:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input third number:");
// int num3 = Convert.ToInt32(Console.ReadLine());

// int max = num1;

// if (num2 > max)
// {
//     max = num2;
// }

// if (num3 > max)
// {
//     max = num3;
// }

// Console.WriteLine(max);


//  Task 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Input number:");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 2 == 0)
// {
//     Console.WriteLine("You entered an even number.");
// }
// else
// {
//     Console.WriteLine("You entered an odd number.");
// }


// Task 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Console.WriteLine("Input N:");
// int n = Convert.ToInt32(Console.ReadLine());

// int count = 1;

// while (count <= n)
// {
//     if (count % 2 == 0)
//     {
//         Console.Write(count+", ");
//     }
//     count++;
// }
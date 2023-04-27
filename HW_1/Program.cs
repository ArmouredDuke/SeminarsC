// Task 2.  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Input first number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number:");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"The number {num1} is greater than the number {num2}.");
}
if (num1 < num2)
{
    Console.WriteLine($"The number {num1} is smoller than the number {num2}.");
}
if (num1 == num2)
{    
    Console.WriteLine($"The number {num1} is equal to the number {num2}.");
}



// Task 4. 
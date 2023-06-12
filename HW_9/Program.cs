/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int Sum(int m, int n)
{
    if (m < n)
    {
        return Sum(m + 1, n) + m;
    }
    else
    {
        if (n < m)
        {
            return Sum(m, n + 1) + n;
        }
        else return m;
    }
}
Console.WriteLine(Sum(4, 1));


/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

uint Akerman(uint m, uint n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if ((m != 0) && (n == 0))
        {
            return Akerman(m - 1, 1);
        }
        else
        {
            return Akerman(m - 1, Akerman(m, n - 1));
        }
    }
}

uint m = 4;
uint n = 0;

Console.WriteLine($"m = {m}, n = {n} -> A({m},{n}) = {Akerman(m, n)}");



/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

void Numbers (int n)
{
    if (n > 0)
    {
        Console.Write(n + " ");
        Numbers(n - 1);
    }
}
Numbers(10);
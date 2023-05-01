// Task 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt("Введите трёхзначное число -> ");
if (number < 100 || number >= 1000) // Внимание, вопрос: а что будем делать, если число отрицательное?
{
    Console.WriteLine("Вы ввели не трёхзначное число. Пожалуйста, повторите ввод.");
    return;
}

Console.WriteLine($"Вы ввели число '{number}'");
int secondRank = number / 10 % 10;
Console.WriteLine($"Вторая цифра данного числа - '{secondRank}'");
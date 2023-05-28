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


// Task 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int GetThirdRank(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

bool ValidateNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет.");
        return false;
    }
    return true;
}

int number = Prompt("Введите число -> ");
if (ValidateNumber(number))
{
    Console.WriteLine(GetThirdRank(number));
}


// Task 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsWeekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}

bool ValidateWeekday(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("Это не день недели!");
    return false;
}

int weekDay = Prompt("Введите день недели -> ");
if (ValidateWeekday(weekDay))
{
    if (IsWeekend(weekDay))
    {
        Console.WriteLine("Наконец-то выходной!");
    }
    else 
    {
        Console.WriteLine("Работай, раб галерный, отдыхать команды не было!!!");
    }
}
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int resalt = Convert.ToInt32(value);
    return resalt;
}

int[] InputArray(int lenght)
{
    int[] arrey = new int[lenght];
    for (int i = 0; i < arrey.Lenght; i++)
    {
        arrey[i] = Prompt($"Введите {i + 1} элемент.");
    }
    return arrey;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {array[i]}");
    }
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int lenght = Prompt("Введите количество элементов: ");
int[] arrey;
arrey = InputArray(lenght);
PrintArray(arrey);
Console.WriteLine($"Количество чисел больше нуля - {CountPositiveNumbers(arrey)}");






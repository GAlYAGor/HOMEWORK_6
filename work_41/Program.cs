// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write($"Укажите какое количество чисел хотите ввести: ");
int M = int.Parse(Console.ReadLine());
int[] GetArray = new int[M];

void InputNumbers(int M)
{
    for (int i = 0; i < M; i++)
    {
        Console.Write($"Введи {i + 1} число: ");
        GetArray[i] = int.Parse(Console.ReadLine());
    }
}

int Comparison(int[] GetArray)
{
    int count = 0;
    for (int i = 0; i < GetArray.Length; i++)
    {
        if (GetArray[i] > 0) count += 1;
    }
    return count;
}

InputNumbers(M);

Console.WriteLine($"Введено чисел больше 0 = {Comparison(GetArray)} ");
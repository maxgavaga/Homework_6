// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввел пользователь.


Console.WriteLine($"Введите число M, которое будет отображать количество проверяемых чисел: ");
int M = Convert.ToInt32 (Console.ReadLine ());
int [] arrayNumbers = new int [M];

void InputNumbers (int M)
{
    for (int i = 0; i < M; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        arrayNumbers[i] = Convert.ToInt32 (Console.ReadLine ());
    }
}

int Comparison (int [] arrayNumbers)
{
    int count = 0;
    for (int i = 0; i < arrayNumbers.Length; i++)
    {
        if (arrayNumbers[i] > 0) count +=1;

    }
    return count;
}
InputNumbers (M);
Console.WriteLine($"Введено чисел больше 0: {Comparison(arrayNumbers)}");
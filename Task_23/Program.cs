// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void ShowCubes(int number)
{
    int x = 1;
    while (x <= number)
    {
        int y = Convert.ToInt32(Math.Pow(x, 3));
        Console.Write($"{y} ");
        x = x + 1;
    }
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInput ("Введите число: ");

ShowCubes(number);


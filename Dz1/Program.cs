// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int a = InputInt("Введите  число: ");
int b = 1;
int Numbers(int a, int b)
{
    if (a == b)
        return a;
    else
        Console.Write($"{Numbers(a, b + 1)}, ");
    return b;
}
int InputInt(string numb)
{
    Console.Write(numb);
    return int.Parse(Console.ReadLine());
}
Console.WriteLine(Numbers(a, b));




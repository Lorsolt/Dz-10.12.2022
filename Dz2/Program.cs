// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int a = InputInt("Введите первое число: ");
int b = InputInt("Введите второе число: ");
int InputInt(string numb)
{
    Console.Write(numb);
    return int.Parse(Console.ReadLine());
}
int NumberSum(int a, int b)
{
    if (a == b)
        return b;
    return b + NumberSum(a, b - 1);
}
Console.WriteLine($"Сумма элементов от {a} до {b} = {NumberSum(a, b)}");
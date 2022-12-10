// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Введите два положительных числа: ");
int m = InputInt("Введите первое число: ");
int n = InputInt("Введите второе число: ");
int InputInt(string numb)
{
    Console.Write(numb);
    return int.Parse(Console.ReadLine());
}
int Akker(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akker(m - 1, 1);
    else
        return Akker(m - 1, Akker(m, n - 1));
}
Console.WriteLine($" :) Аккерман говорит, что({m}, {n}) = {Akker(m, n)}");
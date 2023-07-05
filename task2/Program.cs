//Задача 66: Напишите программу, которая реализует рекурсивный метод нахождения суммы натуральных элементов в промежутке от M до N.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число M: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());

        int sum = SumNaturalNumbersRecursive(m, n);
        Console.WriteLine("Сумма натуральных чисел от M до N: " + sum);
    }

    static int SumNaturalNumbersRecursive(int m, int n)
    {
        if (m > n)
            return 0;

        return m + SumNaturalNumbersRecursive(m + 1, n);
    }
}
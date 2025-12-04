using System;

class Program
{
    // Функция с циклом for
    static void SumArraysFor(int[] a, int[] b, int[] output)
    {
        if (a.Length != b.Length || a.Length != output.Length)
            throw new ArgumentException("Все массивы должны иметь одинаковую длину");

        for (int i = 0; i < a.Length; i++)
        {
            output[i] = a[i] + b[i];
        }
    }

    // Функция с циклом while
    static void SumArraysWhile(int[] a, int[] b, int[] output)
    {
        if (a.Length != b.Length || a.Length != output.Length)
            throw new ArgumentException("Все массивы должны иметь одинаковую длину");

        int i = 0;
        while (i < a.Length)
        {
            output[i] = a[i] + b[i];
            i++;
        }
    }

    static void Main()
    {
        int[] list1 = { 1, 2, 3, 4 };
        int[] list2 = { 10, 20, 30, 40 };
        int[] resultFor = new int[list1.Length];
        int[] resultWhile = new int[list1.Length];

        // Используем функцию с for
        SumArraysFor(list1, list2, resultFor);
        Console.WriteLine("Сумма списков (for):");
        foreach (int x in resultFor)
            Console.WriteLine(x);

        Console.WriteLine();

        // Используем функцию с while
        SumArraysWhile(list1, list2, resultWhile);
        Console.WriteLine("Сумма списков (while):");
        foreach (int x in resultWhile)
            Console.WriteLine(x);
    }
}

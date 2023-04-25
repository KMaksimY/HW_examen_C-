// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение M: ");
        int M = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите значение N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        int sum = SumNaturalNumbers(M, N);
        Console.WriteLine("Сумма натуральных чисел от {0} до {1} равна {2}", M, N, sum);
    }

    static int SumNaturalNumbers(int m, int n)
    {
        if (m > n)
        {
            return 0;
        }
        else
        {
            return m + SumNaturalNumbers(m + 1, n);
        }
    }
}

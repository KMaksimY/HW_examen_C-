// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение m: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите значение n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = Ackermann(m, n);

        Console.WriteLine("Результат функции Аккермана для m={0} и n={1} равен {2}", m, n, result);
    }

    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
}

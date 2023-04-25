using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        PrintNumbers(N);
    }

    static void PrintNumbers(int n)
    {
        if (n == 0)
        {
            return;
        }
        Console.Write(n + ", ");
        PrintNumbers(n - 1);
    }
}

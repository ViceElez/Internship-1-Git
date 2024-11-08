using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Unesite broj redaka za dijamant:");
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= n; i += 2)
        {
            int spaces = (n - i) / 2;
            for (int j = 1; j < spaces+1; j++)
            {
                Console.Write(' ');
            }

            for (int k = 1; k <= i; k++)
            {
                    Console.Write("*");
            }
            Console.WriteLine();
           
        }
        for (int i = n - 2; i > 0; i -= 2)
        {
            int spaces = (n - i) / 2;
            for (int j = 1; j < spaces+1; j++)
            {
                Console.Write(' ');
            }

            for (int k = 1; k <= i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
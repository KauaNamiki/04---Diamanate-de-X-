using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Informe um número ímpar:");
        int n = int.Parse(Console.ReadLine());

        if (n % 2 == 0)
        {
            Console.WriteLine("O número informado não é ímpar.");
            return;
        }

        int meio = n / 2;

        
        for (int i = 0; i < meio; i++)
        {
            for (int j = 0; j < meio - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < 2 * i + 1; j++)
            {
                Console.Write("x");
            }
            Console.WriteLine();
        }

       
        for (int i = 0; i < n; i++)
        {
            Console.Write("x");
        }
        Console.WriteLine();

   
        for (int i = meio - 1; i >= 0; i--)
        {
            for (int j = 0; j < meio - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < 2 * i + 1; j++)
            {
                Console.Write("x");
            }
            Console.WriteLine();
        }
    }
}
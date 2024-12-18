using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Lê o número de níveis da pirâmide"); 
        int N = int.Parse(Console.ReadLine());

       
        for (int J = 1; J <= N; J++)
        {
            int espacos = N - J;

            int quantidade = J * 2 - 1;

            for (int i = 0; i < espacos; i++)
            {
                Console.Write(" "); 
            }

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write(J); 
            }

            Console.WriteLine();
        }
    }
}

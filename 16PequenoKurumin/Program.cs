using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("");
        Console.WriteLine("Na primeira linha há um inteiro 'N' que representa a quantidade de gaiolas");
        Console.WriteLine("Em cada uma das próximas 'N' linhas serão dados 4 inteiros 'A', 'B', 'C', 'D'");
        Console.WriteLine("representando os números nos lados de cada gaiola.");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("<<<<<<<<<<<<<<<<<< PEQUENO KURUMIN >>>>>>>>>>>>>>>>>>>");
        Console.WriteLine("");

        Console.WriteLine("Digite a quantidade de gaiolas");
        int N = int.Parse(Console.ReadLine()); 

        int total = 0;

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Digite os valores A, B, C, D para a gaiola " + (i + 1));

            string[] lados = Console.ReadLine().Split(); 
            int A = int.Parse(lados[0]);
            int B = int.Parse(lados[1]);
            int C = int.Parse(lados[2]);
            int D = int.Parse(lados[3]);

            int soma = A + B + C + D;

            int resultado;

            if (soma >= 100) 
            {
            
                resultado = A - B - C - D;
            }
            else
            {
                
                resultado = soma;
            }

            total += resultado;
        }

        Console.WriteLine("");
        Console.WriteLine($"{total} anos de vida");
        Console.WriteLine("");
        Console.WriteLine("<<<<<<<<<<<<<<<<<<(^.^)>>>>>>>>>>>>>>>>");
        Console.WriteLine("Fim do Algoritimo");    
    }
}

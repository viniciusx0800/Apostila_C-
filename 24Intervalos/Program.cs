using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite os dois números do primeiros intervalo");
        string[] primeiroIntervalo = Console.ReadLine().Split();
        Console.WriteLine("Digite os dois números do Segundos intervalo");
        string[] segundoIntervalo = Console.ReadLine().Split();
        Console.WriteLine("Digite um numero para ver a qual intervalo pertence");
        int numero = int.Parse(Console.ReadLine());

        int x = int.Parse(primeiroIntervalo[0]);
        int y = int.Parse(primeiroIntervalo[1]);
        int w = int.Parse(segundoIntervalo[0]);
        int z = int.Parse(segundoIntervalo[1]);

        bool noPrimeiroIntervalo = (numero > x && numero <= y);
        bool noSegundoIntervalo = (numero >= w && numero < z);

      
        if (noPrimeiroIntervalo && noSegundoIntervalo)
        {
            Console.WriteLine("Ambos!");
        }
        else if (noPrimeiroIntervalo)
        {
            Console.WriteLine("Primeiro intervalo!");
        }
        else if (noSegundoIntervalo)
        {
            Console.WriteLine("Segundo intervalo!");
        }
        else
        {
            Console.WriteLine("Nenhum!");
        }
    }
}

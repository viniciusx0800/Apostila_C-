// using System;

// int n int.Parse(Console.ReadLine());

// int levi = n - 20;

// int saldados = titans / 5 ;

// Console.WriteLine(saldados);

using System;

class Program
{
    static void Main()
    {
        System.Console.WriteLine("");
        System.Console.WriteLine("A entrada possui um único número inteiro 'N' , que representa a quantidade de titãs na região");
        System.Console.WriteLine("");
        System.Console.WriteLine("<<<<<<<<<< INCURSÃO ALEM DAS MURALHAS >>>>>>>>>>");
        System.Console.WriteLine("");
        System.Console.WriteLine("Digite a quantidade de titãs na região");
        System.Console.WriteLine("");
        int N = int.Parse(Console.ReadLine());

        
        int titans = N - 20;

        
        int soldados = titans / 5;

        System.Console.WriteLine("");
        Console.WriteLine("O número de soldados comuns necessários são de : " + soldados);

        System.Console.WriteLine("");
        System.Console.WriteLine("<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>");
        System.Console.WriteLine("Fim Algoritimo");
    }
}


using System;

Console.WriteLine("");
Console.WriteLine("A entrada possui um número inteiro representando o número de");
Console.WriteLine("níveis da pilha piramidal");
Console.WriteLine("");
Console.WriteLine("A saída consiste em 'N' linhas que representam os níveis da pirâmide em ordem crescente");
Console.WriteLine("ou seja, nível com mais taças por último. Cada nível começa com espaços em branco");
Console.WriteLine("seguidos pelos algarismos que representam as taças daquela fileira.");
Console.WriteLine("");
Console.WriteLine("<<<<<<<<<<<<<<<<<<<< PIRAMIDE DE ALIMENTOS >>>>>>>>>>>>>>>>>>>");
Console.WriteLine("");

    Console.WriteLine("Digite o número de níveis da pirâmide"); 
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



Console.WriteLine("");
Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<(^.^)>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine("Fim Algoritimo");    

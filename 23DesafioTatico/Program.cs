using System;

    Console.WriteLine("");
    Console.WriteLine("Um número inteiro 'P', representando o número de jogadores. ");
    Console.WriteLine("Um número inteiro 'S', representando a quantidade de soldados que cada jogador possui");
    Console.WriteLine("'P'blocos de 'S' linhas cada, onde cada linha contém dois números inteiros");
    Console.WriteLine("separados por espaço. O primeiro número representa o valor de ataque e o");  
    Console.WriteLine("segundo número representa o valor de defesa de um soldado. Os valores de");
    Console.WriteLine("ataque e defesa estão na faixa de 1 a 100. ");
    Console.WriteLine("");


    Console.WriteLine("<<<<<<<<<<<<<<<<<<<< DESAFIO TÁTICO >>>>>>>>>>>>>>>>>>>>>");
    Console.WriteLine("");

    Console.WriteLine("Digite a quantidade de jogadores:");
    int P = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a quantidade de soldados de cada jogador:");
    int S = int.Parse(Console.ReadLine());

    if(P == 0 && S == 0)
    {
        Console.WriteLine("");
        System.Console.WriteLine("Fim do programa");
    }

    Console.WriteLine("");

    for (int i = 0; i < P; i++)
    {
        int somaAtaque = 0;
        int somaDefesa = 0;

        for (int j = 0; j < S; j++)
        {
            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine($"Digite os valores de Ataque e Defesa do soldado {j + 1}:");

                
                string[] lados = Console.ReadLine().Split();

                
                if (lados.Length == 2 && int.TryParse(lados[0], out int ataque) && int.TryParse(lados[1], out int defesa))
                {
                    somaAtaque += ataque;
                    somaDefesa += defesa;
                    validInput = true; 
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira dois números inteiros (ataque e defesa).");
                }
            }
        }

        Console.WriteLine("");
        Console.WriteLine($"Soma do ATAQUE: {somaAtaque}  Soma da DEFESA: {somaDefesa}");
    }

    Console.WriteLine("");
    Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<(^.^)>>>>>>>>>>>>>>>>>>>>>>>");
    Console.WriteLine("Fim do Algoritimo");    
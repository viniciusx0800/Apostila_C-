using System;

Console.WriteLine("");
Console.WriteLine("A entrada consiste na primeira linha de um número inteiro");
Console.WriteLine("que representa o número de campeões favoritos de Lucas. Nas próximas linhas");
Console.WriteLine("será fornecido em cada uma, um número inteiro que representa");
Console.WriteLine("o nível de poder de cada um dos campeões");
Console.WriteLine("");
Console.WriteLine("<<<<<<<<<< ESCOLHA DO CAMPEÃO >>>>>>>>>>");
Console.WriteLine("");

int maior = 0;

Console.WriteLine("Digite a quantidade de campeões");
int quantidade = int.Parse(Console.ReadLine());

for(int i = 0; quantidade > i; i++)
{
    System.Console.WriteLine("Digite o nivel de poder do campeão (¨-¨) ");
    int poder = int.Parse(Console.ReadLine());
    if(poder > maior)
    {
        maior = poder;
    }    
}

Console.WriteLine("");
Console.WriteLine($"O campeão mais forte tem o nivel de poder de : {maior}");
Console.WriteLine("");
Console.WriteLine("<<<<<<<<<<<<<<<<<<(^.^)>>>>>>>>>>>>>>>>");
Console.WriteLine("Fim Algoritimo");    
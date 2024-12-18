Console.WriteLine("");
Console.WriteLine("primeira linha da entrada contém um valor que representa o número de pokémon");
Console.WriteLine("que serão fortalecidos pelo clima. Já cada uma das próximas linhas contém o valor");
Console.WriteLine("de pontos de dano do ataque principal de um pokémon e o seu valor de acréscimo");
Console.WriteLine("");
Console.WriteLine("<<<<<<<<<<<<<<<<<< FORTALECIMENTO DE CLIMA >>>>>>>>>>>>>>>>>>>");
Console.WriteLine("");


Console.WriteLine("Digite quantos pokémons que serão fortalecidos pelo clima");
int quantidade = int.Parse(Console.ReadLine());
Console.WriteLine("");
for(int i = 0; quantidade > i; i++)
{
    Console.WriteLine("");
    Console.WriteLine("Digite quanto de poder tem o pokémon");
    int P = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite de quanto foi o acréscimo de poder");
    int M = int.Parse(Console.ReadLine());

    int fortalecimento = P + M ;
    Console.WriteLine("");
    Console.WriteLine($"O acréscimo de poder foi de: {fortalecimento} ");
    Console.WriteLine("");

}

Console.WriteLine("");
Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<(^.^)>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine("Fim Algoritimo");    

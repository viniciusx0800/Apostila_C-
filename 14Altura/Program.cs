
Console.WriteLine("");
Console.WriteLine("A entrada  ́e composta por três numeros inteiros diferentes,");
Console.WriteLine("a altura de cada um dos amigos  respectivamente, separados por um espaco em branco");
// Console.WriteLine("================== \(¨-¨)/ ===================");
System.Console.WriteLine("");
Console.WriteLine("<<<<<<<<<<<<<<<<<< ALTURA >>>>>>>>>>>>>>>>>>>");
Console.WriteLine("");

int maior = 0;

Console.WriteLine("Digite quantos amigos são");
int quantidade = int.Parse(Console.ReadLine());

for(int i = 0; quantidade > i; i++)
{
    System.Console.WriteLine("Digite a altura de cada um dos amigos (¨-¨) ");
    int altura = int.Parse(Console.ReadLine());
    if(altura > maior)
    {
        maior = altura;
    }    
}

Console.WriteLine("");
Console.WriteLine($"O maior tem a altura de  : {maior} m");
Console.WriteLine("");
Console.WriteLine("<<<<<<<<<<<<<<<<<<(^.^)>>>>>>>>>>>>>>>>");
Console.WriteLine("Fim Algoritimo");    
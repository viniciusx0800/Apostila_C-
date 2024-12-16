Console.WriteLine("");
Console.WriteLine("<<<<<<<<<<<<<<<<<<<< FORJANDO ESPADAS >>>>>>>>>la ele>>>>>>>>>>");
Console.WriteLine("");


Console.WriteLine("Digite a Quantidade de aço");
int QuantidadeAco = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a Quantidade de madeira");
int QuantidadeMadeira = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a Quantidade de couro");
int QuantidadeCouro = int.Parse(Console.ReadLine());


int aco = QuantidadeAco / 2;

int madeira = QuantidadeMadeira / 3;

int couro = QuantidadeCouro / 5;


int espadas = Math.Min(aco, Math.Min(madeira, couro));

Console.WriteLine("");
Console.WriteLine($"sera possivel fazer : {espadas} ESPADAS");
Console.WriteLine("");
Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<(^.^)>>>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine("Fim do Algoritimo");    
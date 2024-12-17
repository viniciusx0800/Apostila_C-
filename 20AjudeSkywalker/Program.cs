Console.WriteLine("");
Console.WriteLine("A entrada é composta por cinco inteiros, 'A', 'B', 'C','D' e 'E', representando");
Console.WriteLine("respectivamente, o total de naves sondadas no quadrante, o total de naves amigas detectadas a");
Console.WriteLine("frente de Skywalker, o total de naves amigas a direita, o total de naves amigas a esquerda e o");
Console.WriteLine("total de naves amigas atrás da nave de Skywalker.");
Console.WriteLine("");
Console.WriteLine("<<<<<<<<<<<<<<<<<<<< AJUDE SKYWALKER >>>>>>>>>>>>>>>>>>>");
Console.WriteLine("");

Console.WriteLine("Digite o total de naves sondadas no quadrante 'A' ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o número de naves amigas à frente de Skywalker 'B' ");
int B = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o número de naves amigas à direita 'C' ");
int C = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o número de naves amigas à esquerda 'D' ");
int D = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o número de naves amigas atrás de Skywalker 'E' ");
int E = int.Parse(Console.ReadLine());


int navesInimigas = A - (B + C + D + E);

Console.WriteLine("");
Console.WriteLine($"total de naves inimigas são de: {navesInimigas}");
Console.WriteLine("");
Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<(^.^)>>>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine("Fim do Algoritimo");    
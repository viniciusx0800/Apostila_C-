Console.WriteLine("");
Console.WriteLine("<<<<<<<<<<<<<<<<<<<< ENTREGAS DO LOBO MAU >>>>>>>>>>>>>>>>>>>");
Console.WriteLine("");


Console.WriteLine("Qual a distância da estrada POR km");
int distanciaKm = int.Parse(Console.ReadLine());

Console.WriteLine("Distância entre os pedágios");
int distanciaPedagio = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor por km:");
int valorKm = int.Parse(Console.ReadLine());

Console.WriteLine("Valor do pedágio");
int valorPedagio = int.Parse(Console.ReadLine());


int custoEstrada = distanciaKm * valorKm;

int numeroPedagios = distanciaKm / distanciaPedagio;

int custoPedagios = numeroPedagios * valorPedagio;

int total = custoEstrada + custoPedagios;

Console.WriteLine($"A Chapeuzinho vai pagar: {total}");

Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<(^.^)>>>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine("Fim do Algoritimo");    
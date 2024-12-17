
Console.WriteLine("Digite qual a massa do flash");
int massa = int.Parse(Console.ReadLine());
Console.WriteLine("Digite qual a velocidade do flash");
int velocidade = int.Parse(Console.ReadLine());

int energia = massa * velocidade * velocidade;

Console.WriteLine($"ele presirara de : {energia} energia");

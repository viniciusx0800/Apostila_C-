Console.WriteLine("");
Console.WriteLine("A entrada consiste em dois valores inteiros positivos correspondentes à");
Console.WriteLine("massa atual do Flash em quilos e a velocidade em que o");
Console.WriteLine("Flash está correndo em determinado momento, em metros por segundo");
Console.WriteLine("");
Console.WriteLine(">>>>>>>>>>>>>>>>> MEU NOME É Barry Allen >>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine("");

Console.WriteLine("Digite a massa do flash");
int massa = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a velocidade do flash");
int velocidade = int.Parse(Console.ReadLine());

int energia = massa * velocidade * velocidade;

Console.WriteLine("");
Console.WriteLine($"A energia necessária para o Flash é de : {energia} ");
Console.WriteLine("");
Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<(^.^)>>>>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine("Fim do Algoritimo");    
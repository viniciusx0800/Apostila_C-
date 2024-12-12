using System;

Console.WriteLine("");
Console.WriteLine("Será dado um número inteiro N que representa o tempo do evento em segundos.");
Console.WriteLine("");
Console.WriteLine("<<<<<<<<<< CONTADOR DE SEGUNDOS >>>>>>>>>>");
Console.WriteLine("");
Console.WriteLine("Digite a quantidade de tempo em segundos");

int n = int.Parse(Console.ReadLine());

int horas = n /3600;

int minutos = (n % 3600) / 60;

int segundos = n % 60;

Console.WriteLine("");
Console.WriteLine("Contém o tempo dado em segundos convertido para horas, minutos e segundos");
Console.WriteLine("");
Console.WriteLine($"{horas}h {minutos}m {segundos}s");
Console.WriteLine("");
Console.WriteLine("<<<<<<<<<<<<<<<<<<(^.^)>>>>>>>>>>>>>>>>");
Console.WriteLine("Fim Algoritimo");    
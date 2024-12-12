using System;

Console.WriteLine("");
Console.WriteLine("A entrada contém uma linha com três números decimais, representando as");
Console.WriteLine("notasdas duas provas e do trabalho final");
Console.WriteLine("");
Console.WriteLine("<<<<<<<<<< MÉDIA PONDERADA >>>>>>>>>>");
Console.WriteLine("");

Console.WriteLine("Digite a nota da primeira prova");
decimal p1 = decimal.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota da segunda prova");
decimal p2 = decimal.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota do trabalho");
decimal t = decimal.Parse(Console.ReadLine());

var calculo = ((p1*4)+(p2*4)+(t*2))/10;

decimal soma = calculo / 10;

Console.WriteLine("");
Console.WriteLine($"Sua média final foi : {soma:F2}");
Console.WriteLine("");
Console.WriteLine("<<<<<<<<<<<<<<<<<<(^.^)>>>>>>>>>>>>>>>>");
Console.WriteLine("Fim Algoritimo");    
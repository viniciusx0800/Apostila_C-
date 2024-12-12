using System;

Console.WriteLine("");
Console.WriteLine("A entrada é composta de 2 linhas. A primeira linha contém três inteiros que");
Console.WriteLine("representam o número de pokémons já registrados na Pokédex de cada região, na");
Console.WriteLine("ordem 'K' (Kanto), 'J' (Johto) e 'H' (Hoenn).  A segunda linha contém o número de");
Console.WriteLine("novos pokémons capturados de cada região na mesma ordem da primeira linha");
Console.WriteLine("");
Console.WriteLine("<<<<<<<<<< CONTABILIZANDO POKÉMONS >>>>>>>>>>");
Console.WriteLine("");


Console.WriteLine("Digite a quantidade de pokemon na região K");
int k = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade de pokemon na região j");
int j = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade de pokemon na região h");
int h = int.Parse(Console.ReadLine());

Console.WriteLine("");

Console.WriteLine("Digite a quantidade de pokemon capturado para a região K");
int kcapturado = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade de pokemon capturado para a região j");
int jcapturado = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade de pokemon capturado para a região h");
int hcapturado = int.Parse(Console.ReadLine());

int soma = k + kcapturado; 
int soam1 = j + jcapturado;
int soma2 = h + hcapturado; 

Console.WriteLine("");
Console.WriteLine($"Agora temos na região KANTO {soma} pokemons ");
Console.WriteLine("");
Console.WriteLine($"Agora temos na região JOHTO {soam1} pokemons ");
Console.WriteLine("");
Console.WriteLine($"Agora temos na região HOENN {soma2} pokemons ");
Console.WriteLine("");
Console.WriteLine("<<<<<<<<<<<<<<<<<<(^.^)>>>>>>>>>>>>>>>>");
Console.WriteLine("Fim Algoritimo");    
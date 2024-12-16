

Console.WriteLine("");
Console.WriteLine("A primeira linha da entrada consiste de um inteiro 'N',");
Console.WriteLine("que representa a quantidade de ninjas inimigos.");
Console.WriteLine("");
Console.WriteLine("<<<<<<<<<<<<<<<<<< CLONES DAS SOMBRAS >>>>>>>>>>>>>>>>>>>");
Console.WriteLine("");

Console.WriteLine("Digite a quantiade de ninjas");
int ninjas = int.Parse(Console.ReadLine());

if ((ninjas & ninjas - 1) == 0)
{
    Console.WriteLine("Dattebayo");
}
else{
    Console.WriteLine("Tururuuu");
}

Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<(^.^)>>>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine("Fim do Algoritimo");    
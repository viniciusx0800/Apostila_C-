
Console.WriteLine("");
Console.WriteLine("A entrada é composta por um número inteiro N , que representa a"); 
Console.WriteLine("quantidade de familiares que irão presenteá-lo com bolinhas de gude e um");
Console.WriteLine("inteiro Q , que representa a quantidade de bolinhas que o primeiro");
Console.WriteLine("familiar dará de presente");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("<<<<<<<<<<<<<<<<<< BOLINHAS DE GUDE >>>>>>>>>>>>>>>>>>>");
Console.WriteLine("");


Console.WriteLine("Digite quantidade de familiares");
int familha = int.Parse(Console.ReadLine());
Console.WriteLine("Digite quantas gudes que o primeiro familiar deu");
int gude = int.Parse(Console.ReadLine());

int totalBolinhas = gude * ((int)Math.Pow(2, familha) - 1);

Console.WriteLine("");

Console.WriteLine($"Yuri ganhou {totalBolinhas} bolinhas de gude");

Console.WriteLine("");
Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<(^.^)>>>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine("Fim Algoritimo");   
		
using System;
System.Console.WriteLine("");
System.Console.WriteLine("A entrada consiste em um número inteiro , que representa aaltura que a pirâmide terá.");
System.Console.WriteLine("");
System.Console.WriteLine("<<<<<<<<<< DESENHISTA >>>>>>>>>>");
System.Console.WriteLine("");
System.Console.WriteLine("Digite o número da altura que a piramide terar !");
System.Console.WriteLine("");
// comando para  digitar no terminal
int p = int.Parse(Console.ReadLine());
System.Console.WriteLine("");
// estrutura for
for(int i = 1 ; i <= p; i++)
{
    string smaior = new string('>', p - i);

    string sjvelha = new string('#', i);

    // comando para printar as linhas 
    System.Console.WriteLine(smaior + sjvelha);
}


System.Console.WriteLine("");
System.Console.WriteLine("<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>");
System.Console.WriteLine("Fim Algoritimo");
using System;
System.Console.WriteLine("");
System.Console.WriteLine("A entrada é composta por  dois pergaminho “P1” e “P2”, e");
System.Console.WriteLine("representando a característica de cada pergaminho. Portanto");
System.Console.WriteLine(" “P1” e “P2” podem ser “A” ou “B” e “N” sem pergaminho");
System.Console.WriteLine("");
System.Console.WriteLine( "<<<<<<<<<< EXAME CHUNIN >>>>>>>>>>");
System.Console.WriteLine("");
Console.WriteLine("Insira P1 (A, B ou N)");
string p1 =  Console.ReadLine();

System.Console.WriteLine("");
Console.WriteLine("Insira P2 (A, B ou N)");
string p2 =  Console.ReadLine();

p1 = p1.ToUpper();
p2 = p2.ToUpper();

if(p1.Equals("N") || p2.Equals("N")){
    Console.WriteLine("eliminado");
}

else if (p1.Equals(p2)){
    Console.WriteLine("eliminado");
}

else{
    Console.WriteLine("classificado");
}

System.Console.WriteLine("");
System.Console.WriteLine("<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>");
System.Console.WriteLine("Fim Algoritimo");
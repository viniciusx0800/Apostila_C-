


System.Console.WriteLine("Insira P1 (A, B ou N)");
string p1 =  Console.ReadLine();


System.Console.WriteLine("Insira P2 (A, B ou N)");
string p2 =  Console.ReadLine();

p1 = p1.ToUpper();
p2 = p2.ToUpper();

if(p1.Equals("N") || p2.Equals("N")){
    System.Console.WriteLine("eliminado");
}

else if (p1.Equals(p2)){
    System.Console.WriteLine("eliminado");
}

else{
    System.Console.WriteLine("classificado");
}



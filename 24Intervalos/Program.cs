using System;

    Console.WriteLine("");
    Console.WriteLine("A entrada contém três linhas: a primeira corresponde ao primeiro intervalo");
    Console.WriteLine("(]x,y]); a segunda corresponde ao segundo intervalo ([w,z[); e a terceira");
    Console.WriteLine("corresponde ao número inteiro que se quer descobrir o intervalo ao qual");
    Console.WriteLine("pertence.");
    Console.WriteLine("");
    Console.WriteLine("<<<<<<<<<<<<<<<<<<<< INTERVALOS >>>>>>>>>>>>>>>>>>>");
    Console.WriteLine("");
    
    Console.WriteLine("Digite os dois números do primeiros intervalo");
    string[] primeiroIntervalo = Console.ReadLine().Split();
    Console.WriteLine("Digite os dois números do Segundos intervalo");
    string[] segundoIntervalo = Console.ReadLine().Split();
    Console.WriteLine("Digite um numero para ver a qual intervalo pertence");
    int numero = int.Parse(Console.ReadLine());

    int x = int.Parse(primeiroIntervalo[0]);
    int y = int.Parse(primeiroIntervalo[1]);
    int w = int.Parse(segundoIntervalo[0]);
    int z = int.Parse(segundoIntervalo[1]);

    bool noPrimeiroIntervalo = (numero > x && numero <= y);
    bool noSegundoIntervalo = (numero >= w && numero < z);

    
    if (noPrimeiroIntervalo && noSegundoIntervalo)
    {
        Console.WriteLine("");
        Console.WriteLine("Ambos!");
    }
    else if (noPrimeiroIntervalo)
    {
        Console.WriteLine("");
        Console.WriteLine("Primeiro intervalo!");
    }
    else if (noSegundoIntervalo)
    {
        Console.WriteLine("");
        Console.WriteLine("Segundo intervalo!");
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("Nenhum!");
    }

Console.WriteLine("");
Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<(^.^)>>>>>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine("Fim Algoritimo");    

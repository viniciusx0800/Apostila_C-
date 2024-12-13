    Console.WriteLine("");
    Console.WriteLine("A entrada consiste em 3 linhas contendo 1 inteiros em cada");
    Console.WriteLine("uma, sendo que L indica a  pontuação de Lucas e P a pontuação de Pedro.");
    Console.WriteLine("");
    Console.WriteLine("<<<<<<<<<<<<<<<<<< X1 DA ROÇA 075 >>>>>>>>>>>>>>>>>>>");
    Console.WriteLine("");

    System.Console.WriteLine("Digite a pontuação de pedro1");
    int pedro1 = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Digite a pontuação de lucas1");
    int Lucas1 = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Digite a pontuação de pedro2");
    int pedro2 = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Digite a pontuação de lucas2");
    int lucas2 = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Digite a pontuação de pedro3");
    int pedro3 = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Digite a pontuação de lucas3");
    int lucas3 = int.Parse(Console.ReadLine());

    Console.WriteLine("");

    int somapedro = pedro1 + pedro2 + pedro3;	

    int soamlucas = Lucas1 + lucas2 + lucas3;

    if (somapedro > soamlucas)
    {
        Console.WriteLine("pedro ganhou ! ");
    }

    if(soamlucas > somapedro)
    {
        Console.WriteLine("lucas ganhou !");
    }
    
    if(somapedro == soamlucas)
    {
        Console.WriteLine(" Deu empate [($.$)] ");
    }

    Console.WriteLine("");
    Console.WriteLine("<<<<<<<<<<<<<<<<<<(^.^)>>>>>>>>>>>>>>>>");
    Console.WriteLine("Fim Algoritimo");    
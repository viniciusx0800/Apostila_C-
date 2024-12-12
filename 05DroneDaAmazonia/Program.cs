using System;

        Console.WriteLine("");
        Console.WriteLine("A primeira linha da entrada consiste de dois inteiros, X1 e Y1,"); 
        Console.WriteLine("que correspondem às coordenadas para a entrega. A segunda linha consiste de dois inteiros, X2 e Y2,");
        Console.WriteLine("correspondentes às coordenadas atuais do drone.caso as coordenadas da entrega e do drone sejam iguais");
        Console.WriteLine("'Soltar pacote'");
        Console.WriteLine("caso as coordenadas sejam diferentes. 'Nao soltar pacote' ");
        Console.WriteLine("");
        Console.WriteLine("<<<<<<<<<<<<<< DRONE NA AMAZÔNIA >>>>>>>>>>>>>>");
        Console.WriteLine("");

        Console.WriteLine("Digite o numero da cordenada X1");
        int x1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o numero da cordenada Y1");
        int y1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o numero das cordenadas do DRONE X2");
        int x2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o numero das cordenadas do DRONE Y2");
        int y2 = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        if(x1 == x2 && y1 == y2){
            Console.WriteLine("Soltar pacote");
        }
        else{
            Console.WriteLine("Não soltar o pacote");
        }

        Console.WriteLine("");
        Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<(^.^)>>>>>>>>>>>>>>>>>>>>>");
        Console.WriteLine("Fim Algoritimo");    

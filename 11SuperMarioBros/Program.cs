using System;

Console.WriteLine("");
Console.WriteLine("Considerando as três áreas secretas, a entrada consiste nos itens que você"); 
Console.WriteLine("conseguiu encontrar, sendo três números inteiros representando");
Console.WriteLine("respectivamente, Star Coins, Mega");
Console.WriteLine("Mushrooms e Carapaças Koopa Azul.");
Console.WriteLine("");
Console.WriteLine("<<<<<<<<<<<<<<<<<< SUPER MARIO BROS >>>>>>>>>>>>>>>>>>>");
Console.WriteLine("");

    
Console.WriteLine("Digite a quantidade de Star Coins que você encontrou");
int starMoedas = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade de mega mushrooms que você encontrou");
int megaMush = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade de carapaça Koopa Azul que você encontrou");
int carapacaAzul = int.Parse(Console.ReadLine());

if (starMoedas == 30){
    Console.WriteLine("Proximo mundo");
}

 else if (starMoedas > 30) { 
    Console.WriteLine("Número de Star Coins inválido, tente novamente.");
 }		         	

else{
    int faltaMoeda = 30 - starMoedas;
    int faltaMega = 6 - megaMush;
    int faltaCarapaca = 3 - carapacaAzul;
    Console.WriteLine("");
    Console.WriteLine($"falta {faltaMoeda} star coins , {faltaMega} mega mushrooms e {faltaCarapaca} carapaça Koopa Azul");
}
    
Console.WriteLine("");
Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<(^.^)>>>>>>>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine("Fim Algoritimo");   
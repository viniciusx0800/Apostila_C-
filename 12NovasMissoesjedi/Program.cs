Console.WriteLine("");
Console.WriteLine("Seu programa receberá primeiramente um inteiro e um inteiro"); 
Console.WriteLine("que representam respectivamente, a quantidade de missões a serem");
Console.WriteLine("realizadas igualmente por Yoda, Luke e Ahsoka, seguido da quantidade de XP que estes");
Console.WriteLine("ganharão ao completar cada missão. Na linha seguinte serão dados 3 inteiros que");
Console.WriteLine("representam os respectivos níveis iniciais de XP de Yoda, Luke e Ahsoka.");
Console.WriteLine("");
Console.WriteLine("<<<<<<<<<<<<<<<<<< AS NOVAS MISSÕES DE JEDI >>>>>>>>>>>>>>>>>>>");
Console.WriteLine("");

Console.WriteLine("Digite a Quantidade de missões");
int missoes = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a Quantidade de xp da missão");
int xp = int.Parse(Console.ReadLine());

Console.WriteLine("");

Console.WriteLine("Quanto de xp tem yoda");
int yoda = int.Parse(Console.ReadLine());
Console.WriteLine("Quanto de xp tem luke");
int luke = int.Parse(Console.ReadLine());
Console.WriteLine("Quanto de xp tem ahsoka");
int ahsoka = int.Parse(Console.ReadLine());


int totalYoda = yoda + xp * missoes;	
int totalLuke = luke + xp * missoes;	
int totalAhsoka = ahsoka + xp * missoes;

Console.WriteLine("");
Console.WriteLine($"Yoda seu xp agora é de  {totalYoda}");
Console.WriteLine($"Luke seu xp agora é de  {totalLuke}");
Console.WriteLine($"Ahsoka seu xp agora é de  {totalAhsoka}");

Console.WriteLine("");
Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<(^.^)>>>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine("Fim Algoritimo");   
		
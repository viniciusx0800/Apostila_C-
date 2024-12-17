Console.WriteLine("");
Console.WriteLine("Serão dados em uma única linha o número inteiro da inscrição do");
Console.WriteLine("candidato seguido de mais 5 notas inteiras ");
Console.WriteLine("relativas ao Tiro ao alvo, Natação, Esgrima, Hipismo e Corrida ");
Console.WriteLine("");
Console.WriteLine("<<<<<<<<<<<<<<<<<<<< PENTATLO >>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine("");

Console.WriteLine("Digite o número da inscrição");
int inscricao = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota do Tiro ao alvo");
int N1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota da Natação");
int N2 = int.Parse(Console.ReadLine());


Console.WriteLine("Digite a nota do Esgrima");
int N3 = int.Parse(Console.ReadLine());


Console.WriteLine("Digite a nota do Hipismo");
int N4 = int.Parse(Console.ReadLine());


Console.WriteLine("Digite a nota da  Corrida");
int N5 = int.Parse(Console.ReadLine());

double media = (N1 + N2 + N3 + N4 + N5) / 5.0;

Console.WriteLine("");
Console.WriteLine($"Numero da Inscrição {inscricao} e Media do atleta {media:F1}");

Console.WriteLine("");
Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<(^.^)>>>>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine("Fim do Algoritimo");    

Console.WriteLine("quantidade de famia");
int famia = int.Parse(Console.ReadLine());
Console.WriteLine("quantidade de gude que a  famia deu");
int gude = int.Parse(Console.ReadLine());

int totalBolinhas = gude * ((int)Math.Pow(2, famia) - 1);

Console.WriteLine(totalBolinhas);
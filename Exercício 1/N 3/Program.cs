// See https://aka.ms/new-console-template for more information
Console.WriteLine("insira 4 números para identificar a diferença entre os produtos de A e B com C e D:");
string s = Console.ReadLine();
string[] vet = s.Split(' ');
int diferenca = (int.Parse(vet[0]) * int.Parse(vet[1])) - (int.Parse(vet[2]) * int.Parse(vet[3]));  
Console.WriteLine(diferenca);
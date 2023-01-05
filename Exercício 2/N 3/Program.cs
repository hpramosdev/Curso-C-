// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite 2 números inteiros pra saber se eles são múltiplos ou não: ");
string[] vet = Console.ReadLine().Split(' ');
int maior = int.Parse(vet[0]);
int menor = int.Parse(vet[1]);

if (maior % menor == 0 ||  menor % maior == 0){
    Console.WriteLine("São multiplos");
} else {
    Console.WriteLine("Não são múltiplos");
}

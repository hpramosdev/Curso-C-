// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite um número inteiro para saber se ele é par ou impar: ");
int n = int.Parse(Console.ReadLine());

if (n % 2 == 0) {
    Console.WriteLine("Par");
} else {
    Console.WriteLine("Impar");
}

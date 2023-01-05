// See https://aka.ms/new-console-template for more information
Console.WriteLine("Insira um número inteiro para saber se é positivo ou negativo: ");
int n = int.Parse(Console.ReadLine());

if (n < 0) {
    Console.WriteLine("Negativo");
} else {
    Console.WriteLine("Positivo"); 
}

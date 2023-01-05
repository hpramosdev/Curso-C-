// See https://aka.ms/new-console-template for more information
Console.WriteLine("----------------------------------");
Console.WriteLine("Código |  Especificação  | Preço ");
Console.WriteLine("  1    | Cachorro Quente | R$ 4,00"); 
Console.WriteLine("  2    |     X-Salada    | R$ 4,50");
Console.WriteLine("  3    |     X-Bacon     | R$ 5,00");
Console.WriteLine("  4    | Torrada Simples | R$ 2,50");
Console.WriteLine("  5    |   Refrigerante  | R$ 1,50");

Console.WriteLine($"\nDigite o código e a quantidade para calcular o preço: ");
string[] s = Console.ReadLine().Split(' ');
int codigo = int.Parse(s[0]);
int quantidade = int.Parse(s[1]);
double total;

switch (codigo)
{
    case 1: 
        total = 4 * quantidade;
        Console.WriteLine($"TOTAL: R${total.ToString("N2")}");
        break;
    case 2:
        total = 4.50 * quantidade;
        Console.WriteLine($"TOTAL: R${total.ToString("N2")}");
        break; 
    case 3:
        total = 5 * quantidade;
        Console.WriteLine($"TOTAL: R${total.ToString("N2")}");
        break;
    case 4:
        total = 2.50 * quantidade;
        Console.WriteLine($"TOTAL: R${total.ToString("N2")}");
        break;
    case 5:     
        total = 1.50 * quantidade;
        Console.WriteLine($"TOTAL: R${total.ToString("N2")}");
        break;
    default:
        break;
} 


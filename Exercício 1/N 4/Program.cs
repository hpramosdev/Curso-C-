// See https://aka.ms/new-console-template for more information
Console.Write("Digite o número do funcionário: ");
string funcionario = Console.ReadLine();

Console.Write("Insira o número de horas trabalhadas pelo funcionário: ");
int horas = int.Parse(Console.ReadLine());

Console.Write("Insira o valor da hora do funcionário: ");
double valor = double.Parse(Console.ReadLine());
double salario = horas * valor;

Console.WriteLine($"Funcionário: {funcionario} \nSalário: {salario:F2}");

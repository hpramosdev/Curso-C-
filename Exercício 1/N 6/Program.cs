// See https://aka.ms/new-console-template for more information
Console.WriteLine("Insira 3 valores com ponto flutuante: ");
string s = Console.ReadLine();
string[] vet =  s.Split(' ');

double triangulo = Triangulo(vet);
double circulo = Circulo(vet);
double trapezio = Trapezio(vet);
double quadrado = Quadrado(vet);
double retangulo = Retangulo(vet);

Console.Write($"TRIANGULO: {triangulo:F3} \nCIRCULO: {circulo:F3}" + 
              $"\nTRAPÉZIO: {trapezio:F3} \nQUADRADO: {quadrado:F3}" +
              $"\nRETANGULO: {retangulo:F3}");


double Triangulo(string[] vet)
{
    double result = (double.Parse(vet[0]) * double.Parse(vet[2])) / 2;
    return result;
}

double Circulo(string[] vet)
{
    double pi = 3.14159;
    double result = pi * (double.Parse(vet[2]) * double.Parse(vet[2]));
    return result;
}

double Trapezio(string[] vet)
{
    double result = (double.Parse(vet[2]) * (double.Parse(vet[0]) + double.Parse(vet[1]))) / 2;
    return result;
}

double Quadrado(string[] vet)
{
    double result = double.Parse(vet[1]) * double.Parse(vet[1]);
    return result;
}

double Retangulo(string[] vet)
{
    double result = double.Parse(vet[0]) * double.Parse(vet[1]);
    return result;
}
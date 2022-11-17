// See https://aka.ms/new-console-template for more information
Console.WriteLine("1º Digite o código da peça, a quatidade e o valor unitário: ");
string s = Console.ReadLine();
string[] pdt1 = s.Split(' ');

Console.WriteLine("2º Digite o código da peça, a quatidade e o valor unitário: ");
s = Console.ReadLine();
string[] pdt2 = s.Split(' ');

Console.WriteLine($"VALOR A PAGAR = R$ {Soma(pdt1, pdt2):F2}");

double Soma(string[] a, string[] b)
{
    double Produto1 =  double.Parse(pdt1[1]) * double.Parse(pdt1[2]);
    double Produto2 = double.Parse(pdt2[1]) * double.Parse(pdt2[2]);
    double Soma = Produto1 + Produto2;
    return Soma; 
}    
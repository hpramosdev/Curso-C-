// See https://aka.ms/new-console-template for more information
Console.WriteLine("insira a hora inicial e a final de um jogo para saber sua duração: ");
string[] s = Console.ReadLine().Split(' ');
double horarioInicio =  double.Parse(s[0]);
double horarioFinal = double.Parse(s[1]);
int count = 0;

if (horarioInicio < horarioFinal){
    count = horarioFinal - horarioInicio;
} else {
    count = 24 - horarioInicio + horarioFinal;
}

if (count < 1 || count > 24){
    Console.WriteLine("ERRO");
} else {
    Console.WriteLine($"O jogo teve {count} horas de duração");
}


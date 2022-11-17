Console.Write("Insira o valor do raio de um círculo para calcular sua área: ");
double Pi = 3.14159;
double Raio = double.Parse(Console.ReadLine());
double Area = Pi * (Raio * Raio);
Console.WriteLine($"{Area:F4}");
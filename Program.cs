Console.WriteLine("-- Equação do segundo grau --");

Console.Write("(a): ");
double a = double.Parse(Console.ReadLine());

Console.Write("(b): ");
double b = double.Parse(Console.ReadLine());

Console.Write("(c): ");
double c = double.Parse(Console.ReadLine());

double delta = b * b - 4 * a * c;

if (a == 0)
{
    Console.WriteLine("Não é uma equação de segundo grau!");
}
else if (delta < 0)
{
    Console.WriteLine("Não possui raízes reais!");
}
else
{
    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

    Console.WriteLine("x1 = " + x1);
    Console.WriteLine("x2 = " + x2);
}

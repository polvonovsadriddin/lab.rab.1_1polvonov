//высокий уровень10
Console.Write("введите x:");
double x = double.Parse(Console.ReadLine());
Console.Write("введите y:");
double y = double.Parse(Console.ReadLine());
Console.Write("введите z:");
double z = double.Parse(Console.ReadLine());
double U = (Math.Exp(Math.Pow(x, 3))) + Math.Cos(x - 4) * Math.Cos(x - 4) / Math.Atan(x) + 5.2 * y;
Console.WriteLine($"U={U:F2}");
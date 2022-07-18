Console.WriteLine("Введите координаты первой точки:");
Console.Write("X1: ");
double x_1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Y1: ");
double y_1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Z1: ");
double z_1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки:");
Console.Write("X2: ");
double x_2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Y2: ");
double y_2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Z2: ");
double z_2 = Convert.ToDouble(Console.ReadLine());

double distance(double x_1, double y_1, double z_1, double x_2, double y_2, double z_2)
{
    double square = (Math.Pow((x_2 - x_1), 2)) + (Math.Pow((y_2 - y_1), 2)) + (Math.Pow((z_2 - z_1), 2));
    return Math.Sqrt(square);
}
//double rez = Math.Round((distance(x_1, y_1, z_1, x_2, y_2, z_2)), 2);
Console.Write("Расстояние = " + (Math.Round((distance(x_1, y_1, z_1, x_2, y_2, z_2)), 2)));
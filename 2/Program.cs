// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите значение b1 ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k1 ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b2 ");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k2 ");
double k2 = double.Parse(Console.ReadLine());


bool Symmetrical()
{
    return (k1 == k2) && (b1 == b2);
}
bool Parallel()
{
    return (k1 == k2);
}

void Coordinates(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения: x = {x}, y = {y}");
}

if (Symmetrical())
{
    Console.WriteLine("Прямые совпадают");
}
else if (Parallel())
{
    Console.WriteLine("Прямые параллельны");
}
else
    Coordinates(b1, k1, b2, k2);

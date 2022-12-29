// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Поиск точки пересечения двух прямых:");
Console.Write("b1 = ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1 = ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("b2 = ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2 = ");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Пересечение в точке: ({FindPointsIntersectionTwoLines(b1, k1, b2, k2).Item1}, {FindPointsIntersectionTwoLines(b1, k1, b2, k2).Item2})");


(double, double) FindPointsIntersectionTwoLines(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    return (Math.Round(x, 2), Math.Round(y, 2));
}


/*
    Пример
    y = k1 * x + b1, 
    y = k2 * x + b2
    Решение
    k1 * x + b1 = k2 * x + b2
    k1 * x = k2 * x + b2 - b1
    k1 * x - k2 * x = b2 - b1

    ------
    x = (b2 - b1) / (k1 - k2)
    ------
*/




using System;
static void task1()
{
    Console.WriteLine("Enter two numers: ");
    int x, y;
    x = int.Parse(Console.ReadLine());
    y = int.Parse(Console.ReadLine());
    Console.WriteLine("Mid Geometrical: " + Math.Sqrt(Math.Abs(x) * Math.Abs(y)));
}
task1();
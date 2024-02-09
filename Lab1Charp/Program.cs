using System;
static void task1()
{
    Console.WriteLine("Enter two numers: ");
    int x =int.Parse(Console.ReadLine()), y = int.Parse(Console.ReadLine());
    Console.WriteLine("Mid Geometrical: " + Math.Sqrt(Math.Abs(x) * Math.Abs(y)));
}
//task1();

static void task2()
{
    Console.WriteLine("Enter number");
    string? x = Console.ReadLine();
    if (x != null)
    {
        char y = x[^1];
        if (y != '7') Console.WriteLine("Number " + x + " don't end with 7");
        else Console.WriteLine("Number " + x + " end with 7");
    }
    else
    {
        Console.WriteLine("You didn't enter the number");
    }
}
//task2();

static void task3()
{
    Console.WriteLine("Enter coordinates: ");
    int x = int.Parse(Console.ReadLine()), y = int.Parse(Console.ReadLine());
    if((Math.Pow(x, 2) + Math.Pow(y, 2) < 49) && (Math.Pow(x, 2) + Math.Pow(y, 2) > 9))
    {
        Console.WriteLine("Yes");
    }
    else if ((Math.Pow(x, 2) + Math.Pow(y, 2) == 49) || (Math.Pow(x, 2) + Math.Pow(y, 2) == 9))
    {
        Console.WriteLine("On the edge");
    }
    else 
    { 
        Console.WriteLine("No"); 
    }
}
//task3();

static void task4()
{
    Console.WriteLine("Enter m and k: ");
    int m = int.Parse(Console.ReadLine()), k = int.Parse(Console.ReadLine());
    string[] array1 = { "піка", "треф", "бубна", "черва" };
    string[] array2 = { "шістка", "сімка", "вісімка", "дев'ятка", "десятка", "валет", "дама", "король", "туз" };
    Console.WriteLine(array2[k - 6] + ' ' + array1[m-1]);
}
//task4();

double sum(double x, double y)
{ 
    return x + y; 
}

void task5()
{
    Console.WriteLine("Enter numbers: ");
    double x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());
    Console.WriteLine(sum(x, y));
}
//task5();

static void test6()
{
    Console.WriteLine("Enter n amd m: ");
    int n = int.Parse(Console.ReadLine()), m = int.Parse(Console.ReadLine());
    //Console.WriteLine((n + m) * (((n + 1) / (m + 1)) + (5 / m)));
    Console.WriteLine((n + m) * (((double)(n + 1) / (m + 1)) + ((double)5 / m)));
}
//test6();
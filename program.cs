// Distance Caluculator by Leo
#nullable disable
Console.Clear();

// Welcome
Console.WriteLine("WELCOME TO THE DISTANCE CALCULATOR");

// Inputs
Console.Write("Enter x1 value:");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter y1 value:");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter x2 value:");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter y2 value:");
double y2 = Convert.ToDouble(Console.ReadLine());

// Output
Console.WriteLine($"Distance between the two points is {Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 -y1, 2))}");
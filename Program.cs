using System;
class Program
{
    static void Main(string[] args)
    {
        ColoredCircle myColoerdCircle = new ColoredCircle();

        Console.WriteLine("Welcome to Colored Circle");

        Console.WriteLine("Please enter your Circle Radius as a int");
        string userInputRadius = Console.ReadLine();
        double radius = double.Parse(userInputRadius);

        myColoerdCircle.SetRadius(radius);

        Console.WriteLine("Please enter your Circle Color as a String");
        myColoerdCircle.SetColor(Console.ReadLine());
        
        Console.WriteLine($"Your radius is {myColoerdCircle.GetRadius()}" + $" and the color is {myColoerdCircle.GetColor()}." + $" The circumference of the circle is {myColoerdCircle.ComputeCircumference()}" + $" and the area is {myColoerdCircle.ComputeArea()}.");

    }
}

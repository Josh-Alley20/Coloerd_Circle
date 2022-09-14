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

        Console.WriteLine("Please enter your Circle Color as a String");
        string userInputColor = Console.ReadLine();
        string color = userInputColor;

        myColoerdCircle.SetRadius(radius);

        myColoerdCircle.SetColor(color);

        Console.WriteLine($"Your radius is {myColoerdCircle.GetRadius()}" + $" and the color is {myColoerdCircle.GetColor()}." + $" The circumference of the circle is {myColoerdCircle.ComputeCircumference()}" + $" and the area is {myColoerdCircle.ComputeArea()}.");

    }
}

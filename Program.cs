using System;

/*
 * Joshua Alley
 * 9/21/2022
 * CSCI-1301-A
 */

class Program
{
    static void Main(string[] args)
    {
        ColoredCircle myColoerdCircle = new ColoredCircle();

        Console.WriteLine("Welcome to Colored Circle"); // prints a nice welcome message for the user.

        Console.WriteLine("Please enter your Circle Radius as an double"); // proms the user for input as double.
        string userInputRadius = Console.ReadLine(); // takes the input and sets it to a string
        double radius = double.Parse(userInputRadius); // parse the input and returns a number as double.

        myColoerdCircle.SetRadius(radius); // takes the user input and sets it to the myColoerdCircle.SetRadius .

        Console.WriteLine("Please enter your Circle Color as a String"); // proms the user for input as string.
        myColoerdCircle.SetColor(Console.ReadLine()); // reads the input and saves as myColoerdCircle.SetColor .

        Console.WriteLine($"Your radius is {myColoerdCircle.GetRadius()}" + $" and the color is {myColoerdCircle.GetColor()}." + $" The circumference of the circle is {myColoerdCircle.ComputeCircumference()}" + $" and the area is {myColoerdCircle.ComputeArea()}.");
        // writes the out put for the radius, color, circumference, and the area.
    }
}

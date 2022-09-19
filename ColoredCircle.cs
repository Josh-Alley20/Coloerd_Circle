/**
 Josh Alley
 9/14/22
 
 This a program that takes user input of radius and color
 and out puts a message with radius, color, area, and circumference.

    |===========================================|
    |            ColoredCircle                  |
    |-------------------------------------------|
    | - radius : double                         |
    | - color  : string                         |
    |-------------------------------------------|
    | + SetRadius(radiusOfCircle: double): void |
    | + GetRadius(): double                     |
    | + SetColor(colorOfCircle: string): void   |
    | + GetColor(): string                      |
    | + ComputeArea(): int                      |
    | + ComputeCircumference(): int             |
    |===========================================|
**/



class ColoredCircle
{
    private double radius; 
    private string color; 

    public void SetRadius(double radiusOfCircle)
    {
        radius = radiusOfCircle; // this is a setter for the double radius.
    }

    public double GetRadius()
    {
        return radius; // This is a getter and returns a double for radius.
    }

    public void SetColor(string colorOfCircle)
    {
        color = colorOfCircle; // This a a setter for the string color
    }

    public string GetColor()
    {
        return color;  // This is a getter and returns the string of color.
    }

    public double ComputeArea()
    {
        return (3.14159 * radius * radius); // takes user input of radius and returns the Area as a double.
    }

    public double ComputeCircumference() 
    {
        return (3.14159 * radius * 2); // takes user input of radius and returns the Circumference as a double.
    }
}

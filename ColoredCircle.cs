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
        radius = radiusOfCircle;
    }

    public double GetRadius()
    {
        return radius;
    }

    public void SetColor(string colorOfCircle)
    {
        color = colorOfCircle;
    }

    public string GetColor()
    {
        return color;
    }

    public int ComputeArea()
    {
        return (int)(3.14159 * radius * radius);
    }

    public int ComputeCircumference()
    {
        return (int)(3.14159 * radius * 2);
    }
}

using System;

public class Shape
{
    public string color;
    public bool filled;

    public Shape()
    {
        this.color = "green";
        this.filled = true;
    }

    public Shape(string color, bool filled)
    {
        this.color = color;
        this.filled = filled;
    }

    public string GetColor()
    {
        return this.color;
    }

    public void SetColor(string color)
    {
        this.color = color;
    }
    public bool IsFilled()
    {
        return this.filled;
    }
    public void SetFilled(bool filled)
    {
        this.filled = filled;
    }   
    public string ToString()
    {
        return "A Shape with color of" + GetColor() + "and" + (IsFilled() ? "filled" : "not filled"); 
    }
}

public class Circle : Shape
{
    public double radius;
    public Circle()
    {
        this.radius = 1.0;
    }
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public Circle(double radius, string color, bool filled) : base(color, filled)
    {
        this.radius = radius;
    }
    public double GetRadius()
    {
        return this.radius;
    }
    public void SetRadius(double radius)
    {
        this.radius = radius;   
    }
    public double GetArea()
    {
        return Math.PI * this.radius * this.radius;
    }
    public double GetPerimeter()
    {
        return 2 * Math.PI * this.radius;
    }
    public string ToString()
    {
        return "A Circle with width=" + GetRadius() + ", which is a subclass of " + base.ToString();
    }
}
public class Rectangle: Shape 
{
    public double width;
    public double length;

    public Rectangle()
    {
        this.width = 1.0;
        this.length = 1.0;
    }
    public Rectangle(double width, double length)
    {
        this.width = width;
        this.length = length;
    }
    public Rectangle(double width, double length, string color, bool filled) : base(color, filled)
    {
        this.width = width;
        this.length = length;
    }

    public double GetWidth()
    {
        return this.width;
    }   
    public void SetWidth(double width)
    {
        this.width = width;
    }
    public double GetLength()
    {
        return this.length;
    }
    public void SetLength(double length)
    {
        this.length = length;
    }
    public double GetArea()
    {
        return this.width * this.length;
    }
    public double GetPerimeter()
    {
        return 2 * (this.width + this.length);
    }
    public string ToString()
    {
        return "A Rectangle with width=" + GetWidth() + " and length=" + GetLength() + ", which is a subclass of " + base.ToString();
    }
}
public class Square : Rectangle
{
    public Square()
    {
    }
    public Square(double side): base(side, side)
    {
    }
    public Square(double side, string color, bool filled) : base(side, side, color, filled)
    {
    }
    public double GetSide()
    {
        return GetWidth();
    }
    public void SetSide(double side)
    {
        SetWidth(side);
        SetLength(side);
    }
    public void SetWidth(double side)
    {
        base.SetWidth(side);
        base.SetLength(side);
    }
    public void SetLength(double side)
    {
        base.SetLength(side);
        base.SetWidth(side);
    }
    public string ToString()
    {
        return "A Square with side=" + GetSide() + ", which is a subclass of " + base.ToString();
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        /*
        Shape shape = new Shape();
        Console.WriteLine(shape);
        shape = new Shape("red", false);
        Console.WriteLine(shape);
        Console.WriteLine("Hello World!");
        */

        /*
        Circle circle = new Circle();
        Console.WriteLine(circle);
        circle = new Circle(3.5);
        Console.WriteLine(circle);
        circle = new Circle(3.5, "indigo", false);
        Console.WriteLine(circle);
        */

        /*
        Rectangle rectangle = new Rectangle();

        Console.WriteLine(rectangle);

        rectangle = new Rectangle(2.3, 5.8);

        Console.WriteLine(rectangle);

        rectangle = new Rectangle(2.5, 3.8, "orange", true);

        Console.WriteLine(rectangle);*/

        /*
        Square square = new Square();

        Console.WriteLine(square);

        square = new Square(2.3);

        Console.WriteLine(square);

        square = new Square(5.8, "yellow", true);

        Console.WriteLine(square);
        */
    }
}
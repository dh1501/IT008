using System;
using System.Configuration;

/// <summary>
/// Summary description for Class1
/// </summary>
public abstract class Shape
{
	//Cac thuoc tinh Shape
	private double x; 
	private double y;
	private String ShapeName;

	//Khoi tao Shape
	public Shape(double x, double y, String ShapeName)
	{
		this.x = x;
		this.y = y;
		this.ShapeName = ShapeName;
	}

	//Lay vi tri va ten
	public double getX() { return x; }
	public double getY() { return y; }
	public String getShapeName() { return ShapeName; }

	public void SetName(string name)
	{
		ShapeName = name;
	}

	public abstract double getArea();
	public abstract void draw();
}


public class Rectangle:Shape { 

	private double length;
	private double width;

	public Rectangle(double x, double y, double width, double length):base(x, y, "Rectangle")
	{
		this.length = length;
		this.width = width;
	}

	public double getLength() { return length; }
	public double getWidth() { return width; }

    public override double getArea()
    {
		return length * width;
    }

    public override void draw()
    {
        Console.WriteLine("Drawing a rectangle at (" + getX() + ", " + getY() + ") with length " + length + " and width " + width);
    }

}


public class Square : Rectangle
{
	public Square (double x, double y, double side):base(x, y, side, side)
	{
		SetName("Square"); 
	}
}

public class Circle : Shape
{

	private double radius;

	public Circle(double x, double y, double radius) : base(x, y, "Circle")
	{
		this.radius = radius;
	}

	public double getRadius() { return radius; }

    public override double getArea()
    {
        return Math.PI * radius * radius;
    }

    public override void draw()
    {
		Console.WriteLine("Drawing a circle at (" + getX() + ", " + getY() + ") with radius " + radius);
    }
}


public class Triangle : Shape
{

	private double a;
	private double b;
	private double c;

	public Triangle(double x, double y, double a, double b, double c) : base(x, y, "Triangle")
	{
		this.a = a;
		this.b = b;
		this.c = c;
	}

	public double getA() { return a; }
	public double getB() { return b; }
	public double getC() { return c; }

    public override double getArea()
    {
        double p = (a+b+c)/2;
		return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
    }

    public override void draw()
    {
        Console.WriteLine("Drawing a triangle at (" + getX() + " , " + getY() +") with sides ", + a + ", " + b + ", " + c);
    }
}
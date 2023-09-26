using System;
using System.Collections.Generic;

public class Shape
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public int Height { get; set; }
    public int Width { get; set; }

    public virtual void draw()
    {
        Console.WriteLine("执行基类的画图任务！");
    }
}

class Circle : Shape
{
    public override void draw()
    {
        Console.WriteLine("画一个圆形");
        base.draw();
    }
}

class Rectangle : Shape
{
    public override void draw()
    {
        Console.WriteLine("画一个方形");
        base.draw();
    }
}

class Triangle : Shape
{
    public override void draw()
    {
        Console.WriteLine("画一个三角形");
        base.draw();
    }
}

class Program
{
    public static void Main(string[] args)
    {
        var shapes = new List<Shape>
        {
            new Rectangle(),
            new Circle(),
            new Triangle()
        };
        foreach (var shape in shapes)
        {
            shape.draw();
        }
    }
}

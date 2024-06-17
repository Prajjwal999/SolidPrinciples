using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
    }
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a list of shapes
            Shape rectangle = new Rectangle(4, 5);
            Shape circle = new Circle(3);

            // Calculate and print areas
            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
        }
    }
}









//Open for Extension: You can add new shapes(e.g., Triangle, Square) by creating new classes that inherit from Shape and implement the CalculateArea method.
//Closed for Modification: The Shape, Rectangle, and Circle classes do not need to be modified to add new shapes.The existing code remains unchanged and thus less prone to introducing bugs.

}

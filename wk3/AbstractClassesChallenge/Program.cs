using System;

namespace AbstractClassesChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(1, 5, "rectangle", 4);
            rectangle.GetInfo();
            Console.WriteLine(rectangle.GetArea());

            Square square = new Square(5, "square", 4);
            square.GetInfo();
            Console.WriteLine(square.GetArea());

            Triangle triangle = new Triangle(5, 5 , 5, "triangle", 3);
            triangle.GetInfo();
            Console.WriteLine(triangle.GetArea());
        }
    }
}

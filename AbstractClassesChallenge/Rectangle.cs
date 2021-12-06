using System;

namespace AbstractClassesChallenge
{
    public class Rectangle : Shape
    {
        // Implement your Rectangle class here.

        public double Side1L { get; set; } = 0;
        public double Side2W { get; set; } = 0;

        public Rectangle(double side1, string Name, int NumSides) : base(Name, NumSides)
        {
            this.Side1L = side1;
        }
        public Rectangle(double side1, double side2, string Name, int NumSides) : base(Name, NumSides)
        {
            this.Side1L = side1;
            this.Side2W = side2;
        }

        protected override void SetArea()
        {
            this.area = Side1L * Side2W;
        }
    }
}

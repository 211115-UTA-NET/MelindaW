using System;

namespace AbstractClassesChallenge
{
    public class Triangle : Shape
    {
            // Implement your Triangle class here.
            // HINT: Use Herons Formula to calculate and set the area.
            public double SideA { get; set; } = 1;
            public double SideB { get; set; } = 1;
            public double SideC { get; set; } = 1;
            public Triangle(double sideA, double sideB, double sideC, string Name, int NumSides) : base(Name, NumSides)
            {
                this.SideA = sideA;
                this.SideB = sideB;
                this.SideC = sideC;
            }

            protected override void SetArea()
            {
                double s = ( SideA + SideB + SideC) / 2;
                double A = Math.Sqrt(s * Math.Sqrt(s - SideA) * Math.Sqrt(s - SideB) *  Math.Sqrt(s - SideC));
                this.area = A;
            }
    }
}

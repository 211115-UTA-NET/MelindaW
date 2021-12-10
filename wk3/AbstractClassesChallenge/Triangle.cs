
using System;

namespace AbstractClassesChallenge
{
    public class Triangle : Shape
    {
            // Implement your Triangle class here.
            // HINT: Use Herons Formula to calculate and set the area.
            public double SideA { get; set; } = 0;
            public double SideB { get; set; } = 0;
            public double SideC { get; set; } = 0;
            public Triangle(double sideA, double sideB, double sideC, string Name, int NumSides) : base(Name, NumSides)
            {
                this.SideA = sideA;
                this.SideB = sideB;
                this.SideC = sideC;

                SetArea();
            }

            protected override void SetArea()
            {
                double s = ( SideA + SideB + SideC) / 2;
                double inSideSqrt = Math.Abs(s * ((s - SideA) * (s - SideB) * (s - SideC)));
                double A = Math.Sqrt(inSideSqrt);
                this.area = A;
            }
    }
}
using System;

namespace AbstractClassesChallenge
{
    public class Square : Rectangle
    {
        // Implement your Square Class here.
        public Square(double Side1L, string Name, int NumSides) : base(Side1L, Name, NumSides)
        {
            SetArea();
        }

        protected override void SetArea()
        {
            this.area = Side1L * 2;
        }
    }
}

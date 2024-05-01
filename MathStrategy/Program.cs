using System;

namespace MathStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation m1 = new MathOperation(new MultiplyOperation());

            m1.Execute(3, 5);

            MathOperation m2 = new MathOperation(new AddOperation());

            m2.Execute(3, 5);

            MathOperation m3 = new MathOperation(new SubtractOperation());

            m3.Execute(30, 5);

            MathOperation m4 = new MathOperation(new CalculateRectangleArea());

            m4.Execute(30, 5);
        }
    }
}

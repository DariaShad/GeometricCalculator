using GeometricCalculator.FigureModels;

namespace GeometricCalculator
{
    public class Calculator
    {
        public double CalculateSquare(double[] lengths)
        {
            switch(lengths.Length)
            {
                case 1: return new Circle(lengths[0]).FindTheAreaOfCircle();
                case 3: return new Triangle(lengths).CalculateTriangleSquare();
                default: throw new ArgumentException();
            }
        }
       
    }
}
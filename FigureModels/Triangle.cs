namespace GeometricCalculator.FigureModels
{
    internal sealed class Triangle
    {
        private readonly double _sideA;

        private readonly double _sideB;

        private readonly double _sideC;

        private readonly bool _isRight;

        internal Triangle(double[] sides)
        {
           
            CheckIFTheTriangleExists(sides);

            for (int i = 0; i < sides.Length; i++)
            {
                for (int j = 0; j < sides.Length - 1; j++)
                {
                    if (i != j)
                    {
                        if (Math.Pow(sides[i], 2) == Math.Pow(sides[j], 2) + Math.Pow(sides[j + 1], 2))
                        {

                            _sideA = sides[i];
                            _sideB = sides[j];
                            _sideC = sides[j + 1];
                            _isRight = true;
                            return;
                        }
                    }
                }
            }

            _sideA = sides[0];
            _sideB = sides[1];
            _sideC = sides[2];
            _isRight = false;
        }

        internal double CalculateTriangleSquare()
        {
            if (_isRight)
            {
                FindTheAreaOfRightTriangle();
            }

            return FindTheAreaOfTriangle();

        }

        private double FindTheAreaOfRightTriangle()
        {
            return 0.5 * _sideA * _sideB;
        }

        private double FindTheAreaOfTriangle()
        {
            double semiperimeter = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - _sideA) * (semiperimeter - _sideB) * (semiperimeter - _sideC));
        }

        private void CheckIFTheTriangleExists(double[] sides)
        {
            if (sides[0] + sides[1] <= sides[2]
                || sides[1] + sides[2] <= sides[0]
                || sides[0] + sides[2] <= sides[1])
            {
                throw new ArgumentException("A triangle with these parameters does not exist");
            }

        }

    }
}

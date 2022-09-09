namespace GeometricCalculator.FigureModels
{
    internal sealed class Circle
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        internal double FindTheAreaOfCircle()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}

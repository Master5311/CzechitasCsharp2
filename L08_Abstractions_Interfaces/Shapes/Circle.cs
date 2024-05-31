using L08_Abstractions_Interfaces.Interfaces;

namespace L08_Abstractions_Interfaces.Shapes
{
    public class Circle : Shape, IAreaCalculable, IPerimeterCalculable
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * _radius;
        }
    }
}

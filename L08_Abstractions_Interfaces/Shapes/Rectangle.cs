using L08_Abstractions_Interfaces.Interfaces;

namespace L08_Abstractions_Interfaces.Shapes
{
    public class Rectangle : Shape, IAreaCalculable, IPerimeterCalculable
    {
        private readonly double _width;
        private readonly double _height;

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public override double CalculateArea()
        {
            return _width * _height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (_width + _height);
        }
    }
}

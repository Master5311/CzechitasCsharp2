using L08_Abstractions_Interfaces.Interfaces;

namespace L08_Abstractions_Interfaces
{
    public abstract class Shape : IAreaCalculable, IPerimeterCalculable
    {
        public virtual double CalculateArea()
        {
            throw new NotImplementedException();
        }

        public virtual double CalculatePerimeter()
        {
            throw new NotImplementedException();
        }
    }
}

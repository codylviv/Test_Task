using System;

namespace OOP
{
    public class Shape : IComparable<Shape>
    {
        internal double _area;
        public int CompareTo(Shape other)
        {
            return _area.CompareTo(other._area);
        }
        
        public double GetArea()
        {
                return _area;
        }

    }
}

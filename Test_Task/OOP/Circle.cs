using System;

namespace OOP
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            _area = (radius * radius) * Math.PI;
        }
    }
}

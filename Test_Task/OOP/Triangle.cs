namespace OOP
{
    public class Triangle : Shape
    {
        public Triangle(double Base, double height)
        {
            _area = (Base * height) / 2;
        }
    }
}

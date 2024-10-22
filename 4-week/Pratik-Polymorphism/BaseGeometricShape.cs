namespace Pratik_Polymorphism
{
    public class BaseGeometricShape
    {
        private double _width;
        private double _height;

        public double Width
        {
            get { return _width; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Width cannot be negative.");
                _width = value;
            }
        }

        public double Height
        {
            get { return _height; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Height cannot be negative.");
                _height = value;
            }
        }

        // Runtime Polymorphism (Dynamic Polymorphism): Overriding //aynı method adının farklı sınıflarda farklı işlevlerde çağrılması.
        public virtual double Area()
        {
            return Width * Height;
        }
    }

    public class Square : BaseGeometricShape
    {
        // Constructor
        public Square(double side)
        {
            Width = side;
            Height = side;
        }
    }

    public class Rectangle : BaseGeometricShape
    {
        // Constructor
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
    }

    public class RightTriangle : BaseGeometricShape
    {
        // Constructor
        public RightTriangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Method
        public override double Area() => Width * Height / 2;
    }
}




using System;

namespace OO_Tasks_Interface {
    public interface IShapeProps {
        double GetArea();
        double GetPerimeter();
    }

    public interface ICircleProps {
        double GetArea();
        double GetCircumference();
    }

    public class Shape {
        private string _name;
        private string _colour;

        public Shape(string name, string colour)
        {
            _name = name;
            _colour = colour;
        }
    }

    public class Quadrilateral : Shape {
        public const int _NumSides = 4;

        public Quadrilateral(string name, string colour) : base(name, colour)
        {
            
        }
    }

    public class Square : Quadrilateral, IShapeProps{
        private double _sideLength;

        public double GetArea()
        {
            double area = Math.Round((_sideLength * _sideLength), 2);
            return area;
        }

        public double GetPerimeter()
        {
            double perimeter = Math.Round((_sideLength * _NumSides), 2);
            return perimeter;
        }
        public Square(string name, string colour, double sidelength) : base(name, colour)
        {
            _sideLength = sidelength;
        }
    }

    public class Rectangle : Shape, IShapeProps {
        private double _length;
        private double _width;

        public double GetArea()
        {
            double area = Math.Round((_length * _width), 2);
            return area;
        }

        public double GetPerimeter()
        {
            double perimeter = Math.Round(((_length * 2) + (_width * 2)), 2);
            return perimeter;
        }

        public Rectangle(string name, string colour, double length, double width) : base(name, colour)
        {
            _length = length;
            _width = width;
        }
    }

    public class Circle : Shape, ICircleProps {
        public const double PI = 3.142;
        private double _radius;

        public double GetArea()
        {
            double area = Math.Round((PI * (_radius * _radius)), 2);
            return area;
        }

        public double GetCircumference()
        {
            double circumference = Math.Round((2 * PI * _radius), 2);
            return circumference;
        }

        public double GetPerimeter()
        {
            double perimeter = Math.Round((2 * PI * _radius), 2);
            return perimeter;
        }

        public Circle(string name, string colour, double radius) : base(name, colour)
        {
            _radius = radius;
        }
    }
}
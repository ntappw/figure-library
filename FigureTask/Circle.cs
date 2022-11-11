using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureTask
{
    public class Circle : IFigure
    {
        private double _radius;

        public double Radius
        {
            get => _radius;
            set => _radius = value;
        }

        public Circle() { }

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double GetСapacity() => Math.PI * Math.Pow(_radius, 2);
        public double GetPerimeter() => Math.PI * _radius * 2;
        public double GetHalfPerimeter() => GetPerimeter() / 2;
    }
}

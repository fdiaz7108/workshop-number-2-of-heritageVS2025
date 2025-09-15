using System;

namespace Geometry
{
    public abstract class GeometricFigure
    {
        public string Name { get; set; }

        public GeometricFigure(string name)
        {
            Name = name;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();


        public override string ToString() =>
            $"{Name,-15} =>   Area: {GetArea(),12:F5}    Perimeter: {GetPerimeter(),12:F5}";

    }
}
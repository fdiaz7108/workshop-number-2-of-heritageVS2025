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
        

        public override string ToString()
        {
            return $"{Name}\t\t=>  Area...... {GetArea():F5}\tPerimeter: {GetPerimeter():F5}";
        }

    }
}
namespace Geometry
{
    public class Square : GeometricFigure
    {
        private double a;
        public double A
        {
            get { return a; }

            set
            {
                ValidateA(value);
                a = value;
            }
        }

        public Square(string name, double a) : base(name)
        {
            ValidateA(a);
            A = a;
        }

        public override double GetArea()
        {
            return A * A;
        }

        public override double GetPerimeter()
        {
            return 4 * A;
        }

        private void ValidateA(double a)
        {
            if (a <= 0)
            {
                throw new ArgumentException("El lado del cuadrado debe ser mayor que cero.");
            }

            if (double.IsNaN(a) || double.IsInfinity(a))
            {
                throw new ArgumentException("El lado del cuadrado debe ser un número válido.");
            }
        }

        }
    }
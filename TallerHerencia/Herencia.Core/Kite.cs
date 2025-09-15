using System.ComponentModel.DataAnnotations;

namespace Geometry
{
    public class Kite : Rhombus
    {
        private double b;
        public double B {
            get { return b; }
            set
            {
                ValidateB (value);
                 b = value;
            }
            }

        public Kite(string name, double a, double d1, double d2, double b) : base(name, a, d1, d2)
        {
            ValidateB(b);
            B = b;
        }

        public override double GetArea()
        {
            return (D1 * D2) / 2;
        }

        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }

        private void ValidateB(double b)
        {
            if (b <= 0)
                throw new ArgumentException("El lado B de la cometa debe ser mayor que cero.");
            if (double.IsNaN(b) || double.IsInfinity(b))
                throw new ArgumentException("El lado B de la cometa debe ser un número válido.");
        }


    }
}
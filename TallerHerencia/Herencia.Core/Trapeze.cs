namespace Geometry
{
    public class Trapeze : Triangle
    {
        private double d;
        public double D
        {
            get { return d; }
            set { ValidateD (value); 
            d = value; }
        }
         

        public Trapeze(string name, double a, double b, double c, double d, double h) : base(name, a, b, c, h)
        {
            ValidateD(d);
            D = d;
        }

        public override double GetArea()
        {
            return (B + D) * H / 2;
        }

        public override double GetPerimeter()
        {
            return A + B + C + D;
        }
        private void ValidateD(double d)
        {
            if (d <= 0)
                throw new ArgumentException("El lado D del trapecio debe ser mayor que cero.");
            if (double.IsNaN(d) || double.IsInfinity(d))
                throw new ArgumentException("El lado D del trapecio debe ser un número válido.");
        }

    }
}
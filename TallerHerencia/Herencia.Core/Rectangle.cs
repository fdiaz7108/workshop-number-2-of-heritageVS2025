namespace Geometry
{
    public class Rectangle : Square
       
    {   
        private double b;
        public double B {
            get { return b; }

            set
            {
                ValidateB(value);
                b = value;
            }
            
            }
        public Rectangle(string name, double a, double b) : base(name, a)
        {
            ValidateB(b);
            B = b;
        }

        public override double GetArea()
        {
            return A * B;
        }

        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }

        private void ValidateB(double b)
        {
            if (b <= 0)
                throw new ArgumentException("El lado B del rectángulo debe ser mayor que cero.");
            if (double.IsNaN(b) || double.IsInfinity(b))
                throw new ArgumentException("El lado B del rectángulo debe ser un número válido.");
        }
    }
}
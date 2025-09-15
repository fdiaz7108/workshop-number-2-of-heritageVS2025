namespace Geometry
{
    public class Rhombus : Square
    {
        private double d1;
        private double d2;


        public double D1
        {
            get { return D1; }
            set
            {
                ValidateD1(value);
                d1 = value;
            }
        }
        public double D2
        {
            get { return D2; }
            set
            {
                ValidateD2(value);
                d2 = value;
            }
        }

        public Rhombus(string name, double a, double d1, double d2) : base(name, a)
        {
            ValidateD1(d1);
            ValidateD2(d2);
            D1 = d1;
            D2 = d2;
        }

        public override double GetArea()
        {
            return (D1 * D2) / 2;
        }

        public override double GetPerimeter()
        {
            return 4 * A;
        }
        private void ValidateD1(double d1)
        {
            if (d1 <= 0)
                throw new ArgumentException("La diagonal D1 del rombo debe ser mayor que cero.");
            if (double.IsNaN(d1) || double.IsInfinity(d1))
                throw new ArgumentException("La diagonal D1 del rombo debe ser un número válido.");
        }

        private void ValidateD2(double d2)
        {
            if (d2 <= 0)
                throw new ArgumentException("La diagonal D2 del rombo debe ser mayor que cero.");
            if (double.IsNaN(d2) || double.IsInfinity(d2))
                throw new ArgumentException("La diagonal D2 del rombo debe ser un número válido.");
        }
    }
}
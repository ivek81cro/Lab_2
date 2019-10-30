using System;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        private double m_a;
        private double m_b;
        private double m_c;

        public double A
        {
            get { return m_a; }
            set { m_a = value; }
        }
        public double B
        {
            get { return m_b; }
            set { m_b = value; }
        }
        public double C
        {
            get { return m_c; }
            set { m_c = value; }
        }
        public QuadraticEquation() { }
        public QuadraticEquation(double a, double b, double c)
        {
            m_a = a; m_b = b; m_c = c;
        }
        public double Y(double x)
        {
            return A * Math.Pow(x, 2) + B * x + C;
        }

        public double Discriminant
        {
            get { return Math.Pow(B, 2) - 4 * A * C; }
        }

        public double[] Roots
        {
            get
            {
                if (Discriminant < 0)
                    throw new NotRealRootsException("DISKRIMINANTA JE MANJA OD 0, Korjeni nisu realni!");
                double[] result = new double[2];
                result[0] = (-B + Math.Sqrt(Discriminant)) / (2 * A);
                result[1] = (-B - Math.Sqrt(Discriminant)) / (2 * A);
                return result;
            }
        }

        static void Main(string[] args)
        {
            QuadraticEquation qe = new QuadraticEquation(-1,0,1);
            try
            {
                Console.WriteLine("x1={0}, x2={1}", qe.Roots[0], qe.Roots[1]);
            }
            catch (NotRealRootsException)
            {

            }
        }
    }
}

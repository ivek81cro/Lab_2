using System;
using System.Collections.Generic;
using System.Text;

namespace QuadraticEquation
{
    class Complex
    {
        private double m_real;
        private double m_imaginary;

        public Complex(double real, double imaginary)
        { m_real = real; m_imaginary = imaginary; }
        public Complex(double real) { m_real = real; m_imaginary = 0; }
    }
}

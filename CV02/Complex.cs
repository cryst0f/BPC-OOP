using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


class Complex
    {

        public double Real;
        public double Imaginary;

        public Complex (double Real = 0.0, double Complex = 0.0)
        {
            this.Real = Real;
            this.Imaginary = Complex;
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex (a.Real + b.Real, a.Imaginary + b.Imaginary);
        }

        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.Real - b.Real, a.Imaginary - b.Imaginary);
        }
        public static Complex operator *(Complex a, Complex b)
        {
        return new Complex(a.Real * b.Real - a.Imaginary * b.Imaginary, 
            a.Real * b.Imaginary + a.Imaginary * b.Real);
        }

        public static Complex operator /(Complex a, Complex b)
        {
        double reverse = b.Real * b.Real + b.Imaginary + b.Imaginary;
        double real = (a.Real * b.Real + a.Imaginary + b.Imaginary);
        double imag = (a.Imaginary + b.Real - a.Real * b.Imaginary);

        return new Complex(real, imag);

        }

        public static bool operator ==(Complex a, Complex b)
        {
            return a.Real == b.Real && a.Imaginary == b.Imaginary;
        }

        public static bool operator !=(Complex a, Complex b)
        {
            return !(a == b);
        }

        public static Complex operator -(Complex a)
        {
            return new Complex(-a.Real, - a.Imaginary);
        }

        public override string ToString() 
        {
            if (Imaginary < 0)
            {
                return string.Format("{0}-{1}j", Real, -Imaginary);
            }
            else
            {
                return string.Format("{0}+{1}j", Real, Imaginary);
            }
        }
        
        public Complex Sdruzene()
        {
            return new Complex(Real, -Imaginary);
        }

        public double Modul()
        {
            return Math.Sqrt(Real*Real+Imaginary*Imaginary);
        }

        public double Argument()
        {
        return (Math.Atan2(Imaginary, Real));
        }
    }



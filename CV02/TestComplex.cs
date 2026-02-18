using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TestComplex
{
    private const double Epsilon = 1E-6;

    public static void Test(Complex skutecna, Complex ocekavana, string nazev)
    {
        if (Math.Abs(skutecna.Real - ocekavana.Real) < Epsilon && Math.Abs(skutecna.Imaginary - ocekavana.Imaginary) < Epsilon)
        {
            Console.WriteLine("Test {0}: OK ", nazev);
        }
        else
        {
            Console.WriteLine("Ocekavana hodnota: " + ocekavana + ", Skutecna " + skutecna);
        }
    }
}


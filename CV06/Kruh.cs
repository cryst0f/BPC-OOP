using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV06
{
    internal class Kruh : Objekt2D
    {
        private double r;
        
        public Kruh(double r)
        {
            this.r = r;
        }

        public override double SpoctiPlochu()
        {
            double s = Math.PI * r * r;

            return s;
        }

        public override void Kresli()
        {
            Console.WriteLine($"{this.GetType().Name}, polomer = {r}");
        }

    }
}

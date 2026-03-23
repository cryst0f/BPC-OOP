using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV07
{
    internal abstract class Objekt2D : I2D, IComparable<Objekt2D>
    {
        public abstract double Plocha();

        public int CompareTo(Objekt2D o)
        {
            return this.Plocha().CompareTo(o.Plocha());
        }


    }
}

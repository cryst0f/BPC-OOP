using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV05
{
    internal class Osobni : Auto
    {
        public Osobni(double velikostNadrze, double stavNadrze, TypPaliva palivo, int maxOsob = 5, int prepravovaneOsoby = 0)
            : base(velikostNadrze, stavNadrze, palivo)
        {
            MaxOsob = maxOsob;
            PrepravovaneOsoby = prepravovaneOsoby;
        }

        private int MaxOsob {  get; set; }
        private int prepravovaneOsoby;
        public int PrepravovaneOsoby
        {
            get { return prepravovaneOsoby; }
            set
            {
                prepravovaneOsoby = CheckOsoby(value);
            }
        }


        public int CheckOsoby(int pocetOsob)
        {
            if (pocetOsob > MaxOsob)
            {
                throw new Exception("Pocet osob je vetsi nez je maximalni pocet osob");
            }
            return pocetOsob;
        }

        public override string ToString()
        {
            return String.Format("{0}Pro pocet {1} osob.", base.ToString(), PrepravovaneOsoby);
        }
    }

}

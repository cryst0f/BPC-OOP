using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV08
{
    internal class RocniTeplota
    {
        public int Rok { get; set; }
        public List<double> MesicniTeploty { get; set; }
        public double MaxTeplota 
        {
            get
            {
                return MesicniTeploty.Max();
            }
        }
        public double MinTeplota 
        {
            get 
            {
                return MesicniTeploty.Min();
            }
        }
        public double PrumRocniTeplota
        {
            get
            {
                return MesicniTeploty.Average();
            }
        }

        public RocniTeplota(int rok)
        {
            Rok = rok;
            MesicniTeploty = new List<double>();
        }
    }
}

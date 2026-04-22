using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV11.EFcore
{
    public class Hodnoceni
    {
        public int StudentId { get; set; }
        public int PredmetId { get; set; } 
        public DateTime DatumHodnoceni { get; set; }
        public int HodnoceniStudenta { get; set; }
        public Student Student { get; set; } = null!;
        public Predmet Predmet { get; set; } = null!;
    }
}

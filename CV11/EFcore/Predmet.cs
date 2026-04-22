using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV11.EFcore
{
    public class Predmet
    {
        public int PredmetId { get; set; }  
        public string Zkratka { get; set; } = "";
        public string Nazev { get; set; } = "";
    }
}

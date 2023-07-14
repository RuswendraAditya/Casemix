using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casemix.Model
{
    public class AnalisaTarif
    {
        
        public string noReg { get; set; }


        public string kodeTarif { get; set; }


        public string namaTarif { get; set; }

        public decimal quantity { get; set; }

        public decimal rupiah { get; set; }


        public decimal total { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casemix.Model
{
    public class AnalisaICD10
    {
        public string kodeICD10 { get; set; }
        public string deskripsiIcd { get; set; }

        public string noReg { get; set; }

        public string noRM { get; set; }

        public string kdPng { get; set; }
        public string namaPng { get; set; }
        public string namaPasien { get; set; }

        public decimal biayaRS { get; set; }

    }
}

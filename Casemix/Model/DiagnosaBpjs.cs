using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casemix.Model
{
    public class DiagnosaBpjs
    {
        public string diagnosa_grouper { get; set; }
        public string deskripsi { get; set; }
        public string noRM { get; set; }

        public string noReg { get; set; }
        public string no_sep { get; set; }

        public string namaPasien { get; set; }
        public decimal biaya_rs { get; set; }
        public decimal iurPasien { get; set; }

        public decimal potongan { get; set; }

        public decimal COB { get; set; }

        public decimal umbal { get; set; }


        public decimal piutangRS { get; set; }

        public decimal selisihUmbal { get; set; }

        public string namaDokter { get; set; }
        public int los { get; set; }
        public List<AnalisaTarif> analisaTarifs { get; set; }

        public string klinik { get; set; }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casemix.Model
{
    public class Inacbg_Raw_Data
    {

        public string KODE_RS { get; set; }
        public string KELAS_RS { get; set; }
        public int? KELAS_RAWAT { get; set; }
        public string KODE_TARIF { get; set; }
        public int? PTD { get; set; }
        public string ADMISSION_DATE { get; set; }
        public string DISCHARGE_DATE { get; set; }
        public string BIRTH_DATE { get; set; }
        public int? BIRTH_WEIGHT { get; set; }
        public int? SEX { get; set; }
        public int? DISCHARGE_STATUS { get; set; }
        public string DIAGLIST { get; set; }
        public string PROCLIST { get; set; }
        public string ADL1 { get; set; }
        public string ADL2 { get; set; }
        public string IN_SP { get; set; }
        public string IN_SR { get; set; }
        public string IN_SI { get; set; }
        public string IN_SD { get; set; }
        public string INACBG { get; set; }
        public string SUBACUTE { get; set; }
        public string CHRONIC { get; set; }
        public string SP { get; set; }
        public string SR { get; set; }
        public string SI { get; set; }
        public string SD { get; set; }
        public string DESKRIPSI_INACBG { get; set; }
        public decimal? TARIF_INACBG { get; set; }
        public decimal? TARIF_SUBACUTE { get; set; }
        public decimal? TARIF_CHRONIC { get; set; }
        public string DESKRIPSI_SP { get; set; }
        public decimal? TARIF_SP { get; set; }
        public string DESKRIPSI_SR { get; set; }
        public decimal? TARIF_SR { get; set; }
        public string DESKRIPSI_SI { get; set; }
        public decimal? TARIF_SI { get; set; }
        public string DESKRIPSI_SD { get; set; }
        public decimal? TARIF_SD { get; set; }
        public decimal? TOTAL_TARIF { get; set; }
        public decimal? TARIF_RS { get; set; }
        public decimal? TARIF_POLI_EKS { get; set; }
        public int? LOS { get; set; }
        public int? ICU_INDIKATOR { get; set; }
        public int? ICU_LOS { get; set; }
        public int? VENT_HOUR { get; set; }
        public string NAMA_PASIEN { get; set; }
        public string MRN { get; set; }
        public int? UMUR_TAHUN { get; set; }
        public int? UMUR_HARI { get; set; }
        public string DPJP { get; set; }
        public string SEP { get; set; }
        public string NOKARTU { get; set; }
        public string PAYOR_ID { get; set; }
        public string CODER_ID { get; set; }
        public string VERSI_INACBG { get; set; }
        public string VERSI_GROUPER { get; set; }
        public string C1 { get; set; }
        public string C2 { get; set; }
        public string C3 { get; set; }
        public string C4 { get; set; }
        public decimal? PROSEDUR_NON_BEDAH { get; set; }
        public decimal? PROSEDUR_BEDAH { get; set; }
        public decimal? KONSULTASI { get; set; }
        public decimal? TENAGA_AHLI { get; set; }
        public decimal? KEPERAWATAN { get; set; }
        public decimal? PENUNJANG { get; set; }
        public decimal? RADIOLOGI { get; set; }
        public decimal? LABORATORIUM { get; set; }
        public decimal? PELAYANAN_DARAH { get; set; }
        public decimal? REHABILITASI { get; set; }
        public decimal? KAMAR_AKOMODASI { get; set; }
        public decimal? RAWAT_INTENSIF { get; set; }
        public decimal? OBAT { get; set; }
        public decimal? ALKES { get; set; }
        public decimal? BMHP { get; set; }
        public decimal? SEWA_ALAT { get; set; }
        public decimal? OBAT_KRONIS { get; set; }
        public decimal? OBAT_KEMO { get; set; }
    }
}

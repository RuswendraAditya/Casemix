using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Casemix
{
    public static class MsgBoxUtil
    {
        public static bool MsgKonfirmasi(string prompt)
        {
            return (MessageBox.Show(prompt, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes);
        }

        public static bool MsgSave()
        {
            return MsgKonfirmasi("Apakah Anda yakin data ini ingin disimpan ???");
        }

        public static void MsgWarning(string prompt)
        {
            MessageBox.Show(prompt, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void MsgError(string prompt)
        {
            MessageBox.Show(prompt, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MsgInfo(string prompt)
        {
            MessageBox.Show(prompt, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool MsgDelete()
        {
            return (MsgKonfirmasi("Apakah data ini ingin dihapus ?"));
        }

        public static void MsgDeleteError()
        {
            MsgWarning("Maaf data gagal dihapus !\nData ini sudah digunakan untuk proses yang lain.");
        }

        public static void MsgUpdateError()
        {
            MsgWarning("Maaf, Data yang Anda masukkan gagal disimpan !\nSilahkan dicoba lagi.");
        }

        public static void MsgRequire(string prompt)
        {
            MsgWarning("Maaf, informasi '" + prompt + "' harus diisi !");
        }


        public static void MsgNotFound()
        {
            MsgWarning("Maaf data yang Anda cari tidak ditemukan");
        }

      
        public static void MsgNotValidRangeTanggal()
        {
            MsgWarning("Maaf range tanggal salah !!!");
        }
    }
}

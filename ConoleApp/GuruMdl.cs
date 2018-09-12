using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConoleApp
{
    class GuruMdl
    {
        private string _nip;
        private string _nama;
        private string _jabatan;

        public string nip
        {
            get
            {
                return _nip;
            }
            set
            {
                if (value == "")
                {
                    throw new Exception("Nip tidak boleh kosong");
                }
                _nip = value;
            }
        }
        public string nama
        {
            get
            {
                return _nama;
            }
            set
            {
                _nama = value.ToUpper();
            }
        }
        public string jabatan
        {
            get
            {
                return _jabatan;
            }
            set
            {
                _jabatan = value;
            }
        }
    }
}

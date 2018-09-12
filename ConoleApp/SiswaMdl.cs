using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConoleApp
{
    class SiswaMdl
    {
        private string _nis;
        private string _nama;
        private string _kelas;
        public string nis
        {
            get 
            {
                return _nis;   
            }
            set
            {
                if (value == "")
                {
                    throw new Exception("Nis tidak boleh kosong");
                }
                _nis = value;
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
        public string kelas
        {
            get 
            {
                return _kelas;
            }
            set 
            {
                _kelas = value;
            }
        }
    }
}

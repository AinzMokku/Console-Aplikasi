using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConoleApp
{
    class MatpelMdl
    {
        private string _kd_matpel;
        private string _nama_matpel;
        public string kd_matpel
        {
            get 
            {
                return _kd_matpel;
            }
            set 
            {
                if (value == "")
                {
                    throw new Exception("Kode Matpel Tidak Boleh Kosong!");
                }
                _kd_matpel = value;
            }
        }
        public string nama_matpel
        {
            get 
            {
                return _nama_matpel;
            }
            set 
            {
                _nama_matpel = value.ToUpper();
            }
        }
    }
}

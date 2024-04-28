using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmod10_1302223061
{
    internal class Mahasiswa
    {
        public int Id { get; set; }
        private String? nama { get; set; }
        private String? nim { get; set; }

        public String? Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public String? Nim
        {
            get { return nim; }
            set { nim = value; }
        }
    }
}

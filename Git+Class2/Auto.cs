using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Class2
{
    class Auto
    {
        private string _marka;
        private string _modell;
        private int _ev;
        private int _kilometer;
        private string _uzemanyag;
        private int _ar;

        public Auto(string marka, string modell, int ev, int kilometer, string uzemanyag, int ar)
        {
            Marka = marka;
            Modell = modell;
            Ev = ev;
            Kilometer = kilometer;
            Uzemanyag = uzemanyag;
            Ar = ar;
        }

        public string Marka { get => _marka; set => _marka = value; }
        public string Modell { get => _modell; set => _modell = value; }
        public int Ev { get => _ev; set => _ev = value; }
        public int Kilometer { get => _kilometer; set => _kilometer = value; }
        public string Uzemanyag { get => _uzemanyag; set => _uzemanyag = value; }
        public int Ar { get => _ar; set => _ar = value; }

        public override string ToString()
        {
            return _marka + _modell + _ev + _kilometer + _uzemanyag + _ar;
        }
    }
}

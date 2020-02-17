using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Git_Class2
{
    class Beolvas
    {

        List<Auto> Autok = new List<Auto>();

     
        public void autoBeolvas()
        {
            StreamReader olvas = new StreamReader("auto.csv");
            string jelenlegisor;
            while (!olvas.EndOfStream)
            {

            jelenlegisor = olvas.ReadLine();
            }
            
        }


    }
}

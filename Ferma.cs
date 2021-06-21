using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XIS
{
    public class Ferma
    {
        public string numarIncinta { get; set; }
        public string tip { get; set; }
        public string spatiu { get; set; }
        public string animal { get; set; }
        public string familie { get; set; }
        public string numarCapete { get; set; }
        public string hrana { get; set; }
        public ingrijitor ingrijitor = new ingrijitor();
    }

    public class ingrijitor
    {
        public string nume { get; set; }
        public string salariu { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secund.BE
{
    public class BELicitacion
    {
        public int codLic { get; set; }
        public string nomLic { get; set; }
        public string desLic { get; set; }
        public string norAplLic { get; set; }
        public double valRef { get; set; }
        public DateTime fecPubLic { get; set; }
        public DateTime fecTerLic { get; set; }
        public string monLic { get; set; }
        public int verSeaLic { get; set; }
        public int estLic { get; set; }
        public int codEnt { get; set; }
        public int codCat { get; set; }

        public string desEnt { get; set; }
        public string desCat { get; set; }
    }
}

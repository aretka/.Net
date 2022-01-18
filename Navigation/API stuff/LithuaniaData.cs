using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation.API_stuff
{
    public class LithuaniaData
    {
        public int active { get; set; } 
        public int cases { get; set; }
        public int todayCases { get; set; }
        public int recovered { get; set; }
        public int todayRecovered { get; set; }
        public int deaths { get; set; }
        public int todayDeaths { get; set; }
        public int critical { get; set; }
        public int tests { get; set; }
    }
}

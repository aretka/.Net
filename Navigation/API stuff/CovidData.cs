using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation.API_stuff
{
    public class CovidData
    {
        public object cases { get; set; }

        public object todayCases { get; set; }
        public object deaths { get; set; }
        public object todayDeaths { get; set; }
        public object recovered { get; set; }
        public object active { get; set; }
        public object critical { get; set; }
        public object casesPerOneMillion { get; set; }
        public object deathsPerOneMillion { get; set; }
        public object tests { get; set; }
        public object testsPerOneMillion { get; set; }
    }
}

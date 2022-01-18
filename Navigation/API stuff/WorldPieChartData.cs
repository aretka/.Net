using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation.API_stuff
{
    public class WorldPieChartData
    {
        public int recovered { get; set; }
        public int active { get; set; }
        public int critical { get; set; }
        public int deaths { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation.API_stuff
{
    public class WorldLineChartData
    {
        public readonly List<int> totalCases;
        public readonly List<int> totalDeaths;

        public WorldLineChartData(List<int> totalCases, List<int> totalDeaths)
        {
            this.totalCases = totalCases;
            this.totalDeaths = totalDeaths;
        }

    }
}

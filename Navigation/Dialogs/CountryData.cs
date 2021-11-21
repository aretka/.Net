using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation.Dialogs
{
    public class CountryData
    {
        public readonly int totalCases;
        public readonly int todaysCases;
        public readonly int totalDeaths;
        public readonly int todaysDeaths;
        public readonly string countryName;

        public CountryData(int totalCases, int todaysCases, int totalDeaths, int todaysDeaths, string countryName)
        {
            this.totalCases = totalCases;
            this.todaysCases = todaysCases;
            this.totalDeaths = totalDeaths;
            this.todaysDeaths = todaysDeaths;
            this.countryName = countryName;
        }
    }
}

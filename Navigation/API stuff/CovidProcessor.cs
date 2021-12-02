using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Navigation.API_stuff;

namespace Navigation.API_stuff
{
    public class CovidProcessor
    {
        public static async Task<CovidData> LoadSunInformation()
        {
            string url = "https://corona.lmao.ninja/v2/countries/Spain?yesterday&strict&query%20";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    CovidData result = await response.Content.ReadAsAsync<CovidData>();

                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}

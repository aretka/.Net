using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Navigation.API_stuff;
using Newtonsoft.Json.Linq;

namespace Navigation.API_stuff
{
    public class CovidProcessor
    {
        public static async Task<CovidData> LoadCountryData(string countryName)   
        {
            string url = "https://corona.lmao.ninja/v2/countries/" + countryName + "?yesterday&strict&query%20";

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

        public static async Task<WorldLineChartData> LoadWorldLineChartData()
        {
            string url = "https://disease.sh/v3/covid-19/historical/all?lastdays=all";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    return JsonToArray(result);
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<WorldPieChartData> LoadWorldPieChartData()
        {
            string url = "https://disease.sh/v3/covid-19/all";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    WorldPieChartData result = await response.Content.ReadAsAsync<WorldPieChartData>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<LithuaniaData> LoadLithuaniaData()
        {
            string url = "https://disease.sh/v3/covid-19/countries/Lithuania";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    LithuaniaData result = await response.Content.ReadAsAsync<LithuaniaData>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static WorldLineChartData JsonToArray(String result) {
            var jsonObject = JObject.Parse(result);
            var cases = jsonObject["cases"].ToObject<Dictionary<string, int>>();
            var deaths = jsonObject["deaths"].ToObject<Dictionary<string, int>>();
            return new WorldLineChartData(cases.Values.ToList(), deaths.Values.ToList());
        }

    }
}

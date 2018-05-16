using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;

namespace IntermediaryWS
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class IWS : IIWS
    {
        const string apiKey = "7efd1067c82b1c9593faa098b1f7f5ea02cd272e";
        static string url;
        const int refreshRate = 15;

        static List<City> citiesCache = new List<City>();
        static DateTime lastCityCacheUpdate = DateTime.Now.Subtract(new TimeSpan(0, refreshRate+1, 0));

        static Dictionary<string, List<Station>> stationsPerCityCache = new Dictionary<string, List<Station>>();
        static Dictionary<string, DateTime> lastStationCacheUpdate = new Dictionary<string, DateTime>();

        public async Task<List<City>> GetCitiesName()
        {
            if (DateTime.Now.Subtract(lastCityCacheUpdate).Minutes > refreshRate)
            {
                UpdateCityCache();
            }
            return citiesCache;
        }

        public async Task<List<Station>> GetStations(string city)
        {
            DateTime lastUpdated;
            if(lastStationCacheUpdate.TryGetValue(city, out lastUpdated))
            {
                if (DateTime.Now.Subtract(lastUpdated).Minutes > refreshRate)
                {
                    UpdateStationCache(city);
                }
            }
            else
            {
                lastStationCacheUpdate[city] = DateTime.Now;
                UpdateStationCache(city);
            }
            return stationsPerCityCache[city];
        }

        public async Task<Station> GetStation(string city, string station_name)
        {
            DateTime now = DateTime.Now;
            if (DateTime.Now.Subtract(lastCityCacheUpdate).Minutes > refreshRate)
            {
                UpdateCityCache();
            }

            DateTime lastUpdated;
            if (lastStationCacheUpdate.TryGetValue(city, out lastUpdated))
            {
                if (DateTime.Now.Subtract(lastUpdated).Minutes > refreshRate)
                {
                    UpdateStationCache(city);
                }
            }
            else
            {
                lastStationCacheUpdate[city] = DateTime.Now;
                UpdateStationCache(city);
            }

            foreach (Station station in stationsPerCityCache[city])
            {
                if (station.Name.ToUpper().Contains(station_name.ToUpper()))
                {
                    return station;
                }
            }

            return new Station();
        }

        static async Task<string> MyWebRequest()
        {
            try
            {
                WebRequest request = WebRequest.Create(url);

                WebResponse response = request.GetResponse();

                Console.WriteLine(((HttpWebResponse)response).StatusDescription);

                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();

                reader.Close();
                response.Close();

                return responseFromServer;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:  " + ex.Message);
                return "";
            }
        }

        public async void UpdateCityCache()
        {
            Console.Write("Updating city cache... ");
            url = "https://api.jcdecaux.com/vls/v1/contracts?apiKey=" + apiKey;
            string result = await MyWebRequest();
            citiesCache = JsonConvert.DeserializeObject<List<City>>(result);

            TimeSpan to_add = DateTime.Now.Subtract(lastCityCacheUpdate);
            lastCityCacheUpdate += to_add;

            Console.WriteLine("done!");
        }

        public async void UpdateStationCache(string city)
        {
            Console.Write("Updating station cache... ");
            url = "https://api.jcdecaux.com/vls/v1/stations?contract=" + city + "&apiKey=" + apiKey;
            string result = await MyWebRequest();
            stationsPerCityCache[city] =  JsonConvert.DeserializeObject<List<Station>>(result);

            TimeSpan to_add = DateTime.Now.Subtract(lastStationCacheUpdate[city]);
            lastStationCacheUpdate[city] += to_add;

            Console.WriteLine("done!");
        }
    }
}

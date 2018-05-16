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

        public async Task<List<City>> GetCitiesName()
        {
            url = "https://api.jcdecaux.com/vls/v1/contracts?apiKey=" + apiKey;
            string result = await MyWebRequest();
            return JsonConvert.DeserializeObject<List<City>>(result);
        }

        public async Task<List<Station>> GetStations(string city)
        {
            url = "https://api.jcdecaux.com/vls/v1/stations?contract=" + city + "&apiKey=" + apiKey;
            string result = await MyWebRequest();
            return JsonConvert.DeserializeObject<List<Station>>(result);
        }

        public async Task<Station> GetStation(string city, string station_name)
        {
            List<Station> stations = await GetStations(city);
            if(stations != null)
            {
                foreach (Station station in stations)
                {
                    if (station.Name.ToUpper().Contains(station_name.ToUpper()))
                    {
                        return station;
                    }
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
    }
}

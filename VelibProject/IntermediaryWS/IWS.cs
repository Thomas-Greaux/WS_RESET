using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace IntermediaryWS
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class IWS : IIWS, IIWSForEvents
    {
        const string apiKey = "7efd1067c82b1c9593faa098b1f7f5ea02cd272e";
        static string url;

        static Action<string, string, Station> m_EventStationInfo = delegate { };

        public List<City> GetCitiesName()
        {
            url = "https://api.jcdecaux.com/vls/v1/contracts?apiKey=" + apiKey;
            string result = MyWebRequest();
            return JsonConvert.DeserializeObject<List<City>>(result);
        }

        public List<Station> GetStations(string city)
        {
            url = "https://api.jcdecaux.com/vls/v1/stations?contract=" + city + "&apiKey=" + apiKey;
            string result = MyWebRequest();
            return JsonConvert.DeserializeObject<List<Station>>(result);
        }

        public Station GetStation(string city, string station_name)
        {
            List<Station> stations = GetStations(city);
            foreach (Station station in stations)
            {
                if (station.Name.ToUpper().Contains(station_name.ToUpper()))
                {
                    return station;
                }
            }
            return new Station();
        }

        static string MyWebRequest()
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

        public void SubscribeStationInfo()
        {
            IIWSEvents subscriber = OperationContext.Current.GetCallbackChannel<IIWSEvents>();
            m_EventStationInfo += subscriber.StationInfo;
        }

        public void GetStationForEvent(string city, string station_name)
        {
            Station res = GetStation(city, station_name);
            m_EventStationInfo(city, station_name, res);
        }
    }
}

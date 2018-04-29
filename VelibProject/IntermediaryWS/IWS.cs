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
    public class IWS : IIWS
    {
        const string apiKey = "7efd1067c82b1c9593faa098b1f7f5ea02cd272e";
        static string url;

        public List<City> GetCitiesName()
        {
            url = "https://api.jcdecaux.com/vls/v1/contracts?apiKey=" + apiKey;
            string result = MyWebRequest();
            return JsonConvert.DeserializeObject<List<City>>(result);
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
    }
}

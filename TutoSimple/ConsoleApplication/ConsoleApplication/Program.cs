using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            const string base_url = "https://api.jcdecaux.com/vls/v1/contracts?apiKey=";
            const string apiKey = "7efd1067c82b1c9593faa098b1f7f5ea02cd272e";
            string url = "https://api.jcdecaux.com/vls/v1/contracts?apiKey=" + apiKey;
            WebRequest request = WebRequest.Create(url);

            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();

            Console.WriteLine(responseFromServer);

            reader.Close();
            response.Close();

            Console.ReadLine();
        }
    }
}

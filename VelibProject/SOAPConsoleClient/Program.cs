using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOAPConsoleClient.IWSReference;

namespace SOAPConsoleClient
{
    class Program
    {
        const string listCities = "listCities";
        const string listStations = "listStations";
        const string bikesAt = "bikesAt";
        const string end = "end";
        const string help = "help";
        const string prompt = "/> ";

        static IWSClient client = new IWSClient();

        static void Main(string[] args)
        {
            Console.WriteLine("Type 'help' for help");
            string cmd = "";
            while (true)
            {
                Console.Write(prompt);
                cmd = Console.ReadLine();
                string[] argv = cmd.Split(' ');
                switch (argv[0])
                {
                    case listCities: execute_listCities(); break;
                    case listStations:
                        {
                            if (argv.Length >= 2)
                            {
                                execute_listStations(argv[1]);
                            }
                            else
                            {
                                not_enough_args();
                            }
                            break;
                        }
                    case bikesAt:
                        {
                            if (argv.Length >= 3)
                            {
                                execute_bikesAt(argv[1], argv[2]);
                            }
                            else
                            {
                                not_enough_args();
                            }
                            break;
                        }
                    case help: execute_help(); break;
                    case end: return;
                    default: Console.WriteLine("Commande non reconnue, 'help' pour avoir la liste des commandes"); break;
                }
            }
        }

        static void execute_listCities()
        {
            List<City> cities = new List<City>(client.GetCitiesName());
            foreach (City city in cities)
            {
                Console.WriteLine(city.Name);
            }
        }

        static void execute_listStations(string city)
        {
            List<Station> stations = new List<Station>(client.GetStations(city));
            if (stations == null)
            {
                return;
            }
            foreach (Station station in stations)
            {
                Console.WriteLine(station.Name);
            }
        }

        static void execute_bikesAt(string city, string station_name)
        {
            Station station = client.GetStation(city, station_name);
            Console.WriteLine("There are " + station.Available_bikes + " available bikes at \"" + station.Name + "\"");
        }

        static void execute_help()
        {
            Console.Write("Liste des commandes:\n" +
                "listCities---------------------------lists all the cities\n" +
                "listStations <city_name>-------------lists all the stations at the city specified\n" +
                "bikesAt <city_name> <station_name>---prints the number of bikes available at the station, from the city specified\n" +
                "help---------------------------------prints this help\n" +
                "end----------------------------------ends this program\n");
        }

        static void not_enough_args()
        {
            Console.WriteLine("Not enough arguments, see 'help' for the correct usage");
        }

        static void not_implemented()
        {
            Console.WriteLine("feature not implemented yet");
        }
    }
}

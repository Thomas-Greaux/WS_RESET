using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventsConsoleClient.IWSForEventsReference;

namespace EventsConsoleClient
{
    //internal class IWSServiceCallbackSink : IWSReference.
    internal class IWSServiceCallbackSink : IWSForEventsReference.IIWSForEventsCallback
    {
        public void StationInfo(string city, string station_name, Station res_station)
        {
            if(res_station.Available_bikes == -1)
            {
                Console.WriteLine("Station {0} in city {1} doesn't exists...", station_name, city);
                return;
            }
            Console.WriteLine("Bikes at {0} : {1}", res_station.Name, res_station.Available_bikes);
        }
    }
}

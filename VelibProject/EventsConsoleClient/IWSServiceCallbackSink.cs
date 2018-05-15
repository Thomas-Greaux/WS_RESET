using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventsConsoleClient.IWSReference;

namespace EventsConsoleClient
{
    internal class IWSServiceCallbackSink : IWSReference.IIWSCallback
    {
        public void StationInfo(string city, string station_name, Station res_station)
        {
            Console.WriteLine("Bikes at {0} : {1} \n\t(retrieved from event)", station_name, res_station.Available_bikes);
        }
    }
}

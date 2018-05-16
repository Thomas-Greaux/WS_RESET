using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EventsConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from the event client!\n");

            IWSServiceCallbackSink objsink = new IWSServiceCallbackSink();
            InstanceContext iCntxt = new InstanceContext(objsink);
            IWSForEventsReference.IWSForEventsClient objClient = new IWSForEventsReference.IWSForEventsClient(iCntxt);

            objClient.SubscribeStationInfo();
            string user_input;
            do
            {
                user_input = Console.ReadLine();
                string[] splited = user_input.Split(' ');
                string city = splited[0];
                string station;
                if(splited.Length >= 2)
                {
                    station = splited[1];
                    if (splited.Length >= 2)
                    {
                        for (int i = 2; i < splited.Length; i++)
                        {
                            station += (" " + splited[i]);
                        }
                    }
                    objClient.GetStationForEvent(city, station);
                }
            } while (user_input != "end");
        }
    }
}

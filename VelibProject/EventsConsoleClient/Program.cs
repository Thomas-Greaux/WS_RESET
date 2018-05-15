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
            IWSReference.IWSClient objClient = new IWSReference.IWSClient(iCntxt);

            objClient.SubscribeStationInfo();

            objClient.GetStationForEvent("Toulouse", "00189");

            Console.ReadKey();
        }
    }
}

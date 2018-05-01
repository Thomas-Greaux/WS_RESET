using System;
using System.ServiceModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsLibClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcServiceCallbackSink objsink = new CalcServiceCallbackSink();
            InstanceContext iCntxt = new InstanceContext(objsink);

            CalcServiceReference.CalcServiceClient objClient = new CalcServiceReference.CalcServiceClient(iCntxt);
            objClient.SuscribeCalculatedEvents();
            objClient.SuscribeCalculationFinishedEvent();

            double n1 = 1000, n2 = 2000;
            objClient.Calculate(0, n1, n2);

            n1 = 2000; n2 = 4000;
            objClient.Calculate(1, n1, n2);

            objClient.Calculate(2, n1, n2);

            n2 = 400;
            objClient.Calculate(3, n1, n2);

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}

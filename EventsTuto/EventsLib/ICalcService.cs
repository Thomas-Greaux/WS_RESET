using System;
using System.ServiceModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsLib
{
    [ServiceContract(CallbackContract = typeof(ICalcServiceEvents))]
    public interface ICalcService
    {
        [OperationContract]
        void Calculate(int nOp, double dblNum1, double dblNum2);

        [OperationContract]
        void SuscribeCalculatedEvents();

        [OperationContract]
        void SuscribeCalculationFinishedEvent();
    }
}

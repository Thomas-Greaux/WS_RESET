using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EventsLib
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class CalcService : ICalcService
    {
        static Action<int, double, double, double> m_Event1 = delegate { };
        static Action m_Event2 = delegate { };

        public void Calculate(int nOp, double dblNum1, double dblNum2)
        {
            double dblResult = 0;
            switch (nOp)
            {
                case 0: dblResult = dblNum1 + dblNum2; break;
                case 1: dblResult = dblNum1 - dblNum2; break;
                case 2: dblResult = dblNum1 * dblNum2; break;
                case 3: dblResult = (dblNum2 == 0) ? 0 : dblNum1 / dblNum2; break;
            }

            m_Event1(nOp, dblNum1, dblNum2, dblResult);
            m_Event2();
        }

        public void SuscribeCalculatedEvents()
        {
            ICalcServiceEvents subscriber = OperationContext.Current.GetCallbackChannel<ICalcServiceEvents>();
            m_Event1 += subscriber.Calculated;
        }

        public void SuscribeCalculationFinishedEvent()
        {
            ICalcServiceEvents subscriber = OperationContext.Current.GetCallbackChannel<ICalcServiceEvents>();
            m_Event2 += subscriber.CalculationFinished;
        }
    }
}

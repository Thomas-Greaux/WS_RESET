using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace IntermediaryWS
{
    class IWSForEvents : IIWSForEvents
    {
        static Action<string, string, Station> m_EventStationInfo = delegate { };
        IWS IWSreference = new IWS();

        public void SubscribeStationInfo()
        {
            IIWSEvents subscriber = OperationContext.Current.GetCallbackChannel<IIWSEvents>();
            m_EventStationInfo += subscriber.StationInfo;
        }

        public void GetStationForEvent(string city, string station_name)
        {
            Station res = IWSreference.GetStation(city, station_name);
            m_EventStationInfo(city, station_name, res);
        }
    }
}

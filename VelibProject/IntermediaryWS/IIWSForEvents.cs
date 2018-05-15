using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace IntermediaryWS
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract(CallbackContract = typeof(IIWSEvents))]
    public interface IIWSForEvents
    {
        [OperationContract]
        void SubscribeStationInfo();

        [OperationContract]
        void GetStationForEvent(string city, string station_name);
    }
}

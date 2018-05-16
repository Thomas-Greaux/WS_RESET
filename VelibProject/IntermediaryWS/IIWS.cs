using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace IntermediaryWS
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IIWS
    {
        [OperationContract]
        Task<List<City>> GetCitiesName();

        [OperationContract]
        Task<List<Station>> GetStations(string city);

        [OperationContract]
        Task<Station> GetStation(string city, string station_name);
    }

    // Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
    // Vous pouvez ajouter des fichiers XSD au projet. Une fois le projet généré, vous pouvez utiliser directement les types de données qui y sont définis, avec l'espace de noms "IntermediaryWS.ContractType".
    [DataContract]
    public class Station
    {
        string name = "Station_Name";
        int available_bikes = -1;

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public int Available_bikes
        {
            get { return available_bikes; }
            set { available_bikes = value; }
        }
    }

    [DataContract]
    public class City
    {
        string name = "City_Name";

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}

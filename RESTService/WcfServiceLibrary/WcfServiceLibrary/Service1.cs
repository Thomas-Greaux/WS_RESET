using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceLibrary
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class Service1 : IService1
    {
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "data/{id}")]
        public Person GetData(string id)
        {
            return new Person() { Id = Convert.ToInt32(id), Name = "GG EZ"};
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Recipes
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetRecipeList(string dish);

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Result
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public string image { get; set; }
        [DataMember]
        public string imageType { get; set; }
    }

    [DataContract]
    public class Recipes
    {
        [DataMember]
        public List<Result> results { get; set; }
        [DataMember]
        public int offset { get; set; }
        [DataMember]
        public int number { get; set; }
        [DataMember]
        public int totalResults { get; set; }
    }
}

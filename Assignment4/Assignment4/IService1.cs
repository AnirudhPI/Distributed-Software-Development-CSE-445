using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GetPlaceInformation
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        // Implementation of first RESTful sevice
        [OperationContract]
        [WebGet(UriTemplate= "GetPlaceInformation?zipcode={zipcode}")]
        string GetPlaceInformation(double zipcode);

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Place
    {
        [DataMember]
        [JsonProperty("place name")]
        public string placename { get; set; }

        [DataMember]
        [JsonProperty("longitude")]
        public string longitude { get; set; }

        [DataMember]
        [JsonProperty("state")]
        public string state { get; set; }

        [DataMember]
        [JsonProperty("state abbreviation")]
        public string stateabbreviation { get; set; }

        [DataMember]
        [JsonProperty("latitude")]
        public string latitude { get; set; }
    }

    [DataContract]
    public class PlaceInformation
    {
        [DataMember]
        [JsonProperty("post code")]
        public string postcode { get; set; }

        [DataMember]
        public string country { get; set; }

        [DataMember]
        [JsonProperty("country abbreviation")]
        public string countryabbreviation { get; set; }

        [DataMember]
        public List<Place> places { get; set; }
    }


}

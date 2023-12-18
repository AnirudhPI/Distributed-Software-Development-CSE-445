using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text.Json;

namespace WindEnergy
{
    // Interface for WindEnergyService
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        WindEnergyData GetWindEnergyData(double lati, double longi);
        [OperationContract]
        string GetWindReport(double lati, double longi);
    }


    // Below are all the POJO classes required to obtain WindEnergyData

    [DataContract]
    public class WindEnergyData
    {
        [DataMember]
        public string type { get; set; }

        [DataMember]
        public Geometry geometry { get; set; }
        [DataMember]
        public Properties properties { get; set; }
        [DataMember]
        public Header header { get; set; }
        [DataMember]
        public List<Messages> messages { get; set; }

        [DataMember]
        public Parameters parameters { get; set; }
        [DataMember]
        public Times times { get; set; }


    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class _Zero
    {
        [DataMember]
        public double WD_PCT { get; set; }
        [DataMember]
        public double WD_AVG { get; set; }
        [DataMember]
        public CLASSES CLASSES { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string range { get; set; }
    }

    [DataContract]
    public class _1125
    {
        [DataMember]
        public double WD_PCT { get; set; }
        [DataMember]
        public double WD_AVG { get; set; }
        [DataMember]
        public CLASSES CLASSES { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string range { get; set; }
    }

    [DataContract]
    public class _1350
    {
        [DataMember]
        public double WD_PCT { get; set; }
        [DataMember]
        public double WD_AVG { get; set; }
        [DataMember]
        public CLASSES CLASSES { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string range { get; set; }
    }

    [DataContract]
    public class _1575
    {
        [DataMember]
        public double WD_PCT { get; set; }
        [DataMember]
        public double WD_AVG { get; set; }
        [DataMember]
        public CLASSES CLASSES { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string range { get; set; }
    }

    [DataContract]
    public class _1800
    {
        [DataMember]
        public double WD_PCT { get; set; }
        [DataMember]
        public double WD_AVG { get; set; }
        [DataMember]
        public CLASSES CLASSES { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string range { get; set; }
    }

    [DataContract]
    public class _2025
    {
        [DataMember]
        public double WD_PCT { get; set; }
        [DataMember]
        public double WD_AVG { get; set; }
        [DataMember]
        public CLASSES CLASSES { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string range { get; set; }
    }

    [DataContract]
    public class _225
    {
        [DataMember]
        public double WD_PCT { get; set; }
        [DataMember]
        public double WD_AVG { get; set; }
        [DataMember]
        public CLASSES CLASSES { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string range { get; set; }
    }

    [DataContract]
    public class _2250
    {
        [DataMember]
        public double WD_PCT { get; set; }
        [DataMember]
        public double WD_AVG { get; set; }
        [DataMember]
        public CLASSES CLASSES { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string range { get; set; }
    }

    [DataContract]
    public class _2475
    {
        [DataMember]
        public double WD_PCT { get; set; }
        [DataMember]
        public double WD_AVG { get; set; }
        [DataMember]
        public CLASSES CLASSES { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string range { get; set; }
    }

    [DataContract]
    public class _2700
    {
        [DataMember]
        public double WD_PCT { get; set; }
        [DataMember]
        public double WD_AVG { get; set; }
        [DataMember]
        public CLASSES CLASSES { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string range { get; set; }
    }

    [DataContract]
    public class _2925
    {
        [DataMember]
        public double WD_PCT { get; set; }
        [DataMember]
        public double WD_AVG { get; set; }
        [DataMember]
        public CLASSES CLASSES { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string range { get; set; }
    }

    [DataContract]
    public class _3150
    {
        [DataMember]
        public double WD_PCT { get; set; }
        [DataMember]
        public double WD_AVG { get; set; }
        [DataMember]
        public CLASSES CLASSES { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string range { get; set; }
    }

    [DataContract]
    public class _3375
    {
        [DataMember]
        public double WD_PCT { get; set; }
        [DataMember]
        public double WD_AVG { get; set; }
        [DataMember]
        public CLASSES CLASSES { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string range { get; set; }
    }

    [DataContract]
    public class _450
    {
        [DataMember]
        public double WD_PCT { get; set; }
        [DataMember]
        public double WD_AVG { get; set; }
        [DataMember]
        public CLASSES CLASSES { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string range { get; set; }
    }

    [DataContract]
    public class _675
    {
        [DataMember]
        public double WD_PCT { get; set; }
        [DataMember]
        public double WD_AVG { get; set; }
        [DataMember]
        public CLASSES CLASSES { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string range { get; set; }
    }

    [DataContract]
    public class _900
    {
        [DataMember]
        public double WD_PCT { get; set; }
        [DataMember]
        public double WD_AVG { get; set; }
        [DataMember]
        public CLASSES CLASSES { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string range { get; set; }
    }

    [DataContract]
    public class ALL
    {
        [DataMember]
        public double CLASS_1 { get; set; }
        [DataMember]
        public double CLASS_2 { get; set; }
        [DataMember]
        public double CLASS_3 { get; set; }
        [DataMember]
        public double CLASS_4 { get; set; }
        [DataMember]
        public double CLASS_5 { get; set; }
        [DataMember]
        public double CLASS_6 { get; set; }
        [DataMember]
        public double CLASS_7 { get; set; }
        [DataMember]
        public double CLASS_8 { get; set; }
        [DataMember]
        public double CLASS_9 { get; set; }

        // Constructor to set default values
        public ALL()
        {
            CLASS_1 = 0.0; // Default value for CLASS_1
            CLASS_2 = 0.0; // Default value for CLASS_2
            CLASS_3 = 0.0; // Default value for CLASS_3
            CLASS_4 = 0.0; // Default value for CLASS_4
            CLASS_5 = 0.0; // Default value for CLASS_5
            CLASS_6 = 0.0; // Default value for CLASS_6
            CLASS_7 = 0.0; // Default value for CLASS_7
            CLASS_8 = 0.0; // Default value for CLASS_8
            CLASS_9 = 0.0; // Default value for CLASS_9
        }
    }

    [DataContract]
    public class Api
    {
        [DataMember]
        public string version { get; set; }
        [DataMember]
        public string name { get; set; }

        // Constructor to set default values
        public Api()
        {
            version = ""; // Default value for version (empty string)
            name = "";    // Default value for name (empty string)
        }
    }

    [DataContract]
    public class CLASSES
    {
        [DataMember]
        public string Comment { get; set; }
        [DataMember]
        public double CLASS_1 { get; set; }
        [DataMember]
        public double CLASS_2 { get; set; }
        [DataMember]
        public double CLASS_3 { get; set; }
        [DataMember]
        public double CLASS_4 { get; set; }
        [DataMember]
        public double CLASS_5 { get; set; }
        [DataMember]
        public double CLASS_6 { get; set; }
        [DataMember]
        public double CLASS_7 { get; set; }
        [DataMember]
        public double CLASS_8 { get; set; }
        [DataMember]
        public double CLASS_9 { get; set; }
        [DataMember]
        public double CLASS_10 { get; set; }
        [DataMember]

        public WR10M WR10M { get; set; }
        [DataMember]
        public WR50M WR50M { get; set; }
    }

    [DataContract]
    public class DIRECTION
    {
        [DataMember]
        public string Comment { get; set; }

        [DataMember]
        [JsonProperty("0.0")]
        public _Zero _Zero { get; set; }
        [DataMember]
        [JsonProperty("22.5")]
        public _225 _225 { get; set; }

        [DataMember]
        [JsonProperty("45.0")]
        public _450 _450 { get; set; }

        [DataMember]
        [JsonProperty("67.5")]
        public _675 _675 { get; set; }

        [DataMember]
        [JsonProperty("90.0")]
        public _900 _900 { get; set; }

        [DataMember]
        [JsonProperty("112.5")]
        public _1125 _1125 { get; set; }

        [DataMember]
        [JsonProperty("135.0")]
        public _1350 _1350 { get; set; }

        [DataMember]
        [JsonProperty("157.5")]
        public _1575 _1575 { get; set; }

        [DataMember]
        [JsonProperty("180.0")]
        public _1800 _1800 { get; set; }

        [DataMember]
        [JsonProperty("202.5")]
        public _2025 _2025 { get; set; }

        [DataMember]
        [JsonProperty("225.0")]
        public _2250 _2250 { get; set; }

        [DataMember]
        [JsonProperty("247.5")]
        public _2475 _2475 { get; set; }

        [DataMember]
        [JsonProperty("270.0")]
        public _2700 _2700 { get; set; }

        [DataMember]
        [JsonProperty("292.5")]
        public _2925 _2925 { get; set; }

        [DataMember]
        [JsonProperty("315.0")]
        public _3150 _3150 { get; set; }

        [DataMember]
        [JsonProperty("337.5")]
        public _3375 _3375 { get; set; }

        // Constructor to set default values
        public DIRECTION()
        {
            Comment = "";   // Default value for Comment (empty string)
            _Zero = new _Zero();   // Default _Zero object with its own default values
            _225 = new _225();     // Default _225 object with its own default values
            _450 = new _450();     // Default _450 object with its own default values
            _675 = new _675();     // Default _675 object with its own default values
            _900 = new _900();     // Default _900 object with its own default values
            _1125 = new _1125();   // Default _1125 object with its own default values
            _1350 = new _1350();   // Default _1350 object with its own default values
            _1575 = new _1575();   // Default _1575 object with its own default values
            _1800 = new _1800();   // Default _1800 object with its own default values
            _2025 = new _2025();   // Default _2025 object with its own default values
            _2250 = new _2250();   // Default _2250 object with its own default values
            _2475 = new _2475();   // Default _2475 object with its own default values
            _2700 = new _2700();   // Default _2700 object with its own default values
            _2925 = new _2925();   // Default _2925 object with its own default values
            _3150 = new _3150();   // Default _3150 object with its own default values
            _3375 = new _3375();   // Default _3375 object with its own default values
        }
    }

    [DataContract]
    public class Geometry
    {
        [DataMember]
        public string type { get; set; }
        [DataMember]
        public List<double> coordinates { get; set; }

        // Constructor to set default values
        public Geometry()
        {
            type = "";                 // Default value for type (empty string)
            coordinates = new List<double>();  // Default empty list for coordinates
        }
    }

    [DataContract]
    public class Header
    {
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public Api api { get; set; }
        [DataMember]
        public List<string> sources { get; set; }
        [DataMember]
        public double fill_value { get; set; }

        // Constructor to set default values
        public Header()
        {
            title = "";                   // Default value for title (empty string)
            api = new Api();              // Default Api object with its own default values
            sources = new List<string>(); // Default empty list for sources
            fill_value = 0.0;             // Default value for fill_value
        }
    }

    [DataContract]
    public class Messages
    {
        [DataMember]
        public CLASSES CLASSES { get; set; }
        [DataMember]
        public DIRECTION DIRECTION { get; set; }

        // Constructor to set default values
        public Messages()
        {
            CLASSES = new CLASSES();     // Default CLASSES object with its own default values
            DIRECTION = new DIRECTION(); // Default DIRECTION object with its own default values
        }
    }

    [DataContract]
    public class Parameter
    {
        [DataMember]
        public WR10M WR10M { get; set; }
        [DataMember]
        public WR50M WR50M { get; set; }

        // Constructor to set default values
        public Parameter()
        {
            WR10M = new WR10M(); // Default WR10M object with its own default values
            WR50M = new WR50M(); // Default WR50M object with its own default values
        }
    }

    [DataContract]
    public class Parameters
    {
        [DataMember]
        public WR10M WR10M { get; set; }
        [DataMember]
        public WR50M WR50M { get; set; }
        [DataMember]
        public WDPCT WD_PCT { get; set; }
        [DataMember]
        public WDAVG WD_AVG { get; set; }

        // Constructor to set default values
        public Parameters()
        {
            WR10M = new WR10M(); // Default WR10M object with its own default values
            WR50M = new WR50M(); // Default WR50M object with its own default values
            WD_PCT = new WDPCT(); // Default WDPCT object with its own default values
            WD_AVG = new WDAVG(); // Default WDAVG object with its own default values
        }
    }

    [DataContract]
    public class Properties
    {
        [DataMember]
        public Parameter parameter { get; set; }

        // Constructor to set default values
        public Properties()
        {
            parameter = new Parameter(); // Default Parameter object with its own default values
        }
    }

    [DataContract]
    public class Times
    {
        [DataMember]
        public double data { get; set; }
        [DataMember]
        public double process { get; set; }

        // Constructor to set default values
        public Times()
        {
            data = 0.0;     // Default value for data (double)
            process = 0.0;  // Default value for process (double)
        }
    }

    [DataContract]
    public class WDAVG
    {
        [DataMember]
        public string longname { get; set; }
        [DataMember]
        public string units { get; set; }
        [DataMember]
        public string note { get; set; }

        public WDAVG()
        {
            longname = "";  // Default value for longname (empty string)
            units = "";     // Default value for units (empty string)
            note = "";      // Default value for note (empty string)
        }
    }

    [DataContract]
    public class WDPCT
    {
        [DataMember]
        public string longname { get; set; }
        [DataMember]
        public string units { get; set; }
        [DataMember]
        public string note { get; set; }

        // Constructor to set default values
        public WDPCT()
        {
            longname = "";  // Default value for longname (empty string)
            units = "";     // Default value for units (empty string)
            note = "";      // Default value for note (empty string)
        }
    }

    [DataContract]
    public class WR10M
    {
        [DataMember]
        [JsonProperty("0.0")]
        public _Zero _Zero { get; set; }

        [DataMember]
        [JsonProperty("22.5")]
        public _225 _225 { get; set; }

        [DataMember]
        [JsonProperty("45.0")]
        public _450 _450 { get; set; }

        [DataMember]
        [JsonProperty("67.5")]
        public _675 _675 { get; set; }

        [DataMember]
        [JsonProperty("90.0")]
        public _900 _900 { get; set; }

        [DataMember]
        [JsonProperty("112.5")]
        public _1125 _1125 { get; set; }

        [DataMember]
        [JsonProperty("135.0")]
        public _1350 _1350 { get; set; }

        [DataMember]
        [JsonProperty("157.5")]
        public _1575 _1575 { get; set; }

        [DataMember]
        [JsonProperty("180.0")]
        public _1800 _1800 { get; set; }

        [DataMember]
        [JsonProperty("202.5")]
        public _2025 _2025 { get; set; }

        [DataMember]
        [JsonProperty("225.0")]
        public _2250 _2250 { get; set; }

        [DataMember]
        [JsonProperty("247.5")]
        public _2475 _2475 { get; set; }

        [DataMember]
        [JsonProperty("270.0")]
        public _2700 _2700 { get; set; }

        [DataMember]
        [JsonProperty("292.5")]
        public _2925 _2925 { get; set; }

        [DataMember]
        [JsonProperty("315.0")]
        public _3150 _3150 { get; set; }

        [DataMember]
        [JsonProperty("337.5")]
        public _3375 _3375 { get; set; }
        [DataMember]
        public ALL ALL { get; set; }
        [DataMember]
        public string CLASS_1 { get; set; }
        [DataMember]
        public string CLASS_2 { get; set; }
        [DataMember]
        public string CLASS_3 { get; set; }
        [DataMember]
        public string CLASS_4 { get; set; }
        [DataMember]
        public string CLASS_5 { get; set; }
        [DataMember]
        public string CLASS_6 { get; set; }
        [DataMember]
        public string CLASS_7 { get; set; }
        [DataMember]
        public string CLASS_8 { get; set; }
        [DataMember]
        public string CLASS_9 { get; set; }
        [DataMember]
        public string CLASS_10 { get; set; }
        [DataMember]
        public string longname { get; set; }
        [DataMember]
        public string units { get; set; }
        [DataMember]
        public string note { get; set; }
    }

    [DataContract]
    public class WR50M
    {
        [DataMember]
        [JsonProperty("0.0")]
        public _Zero _Zero { get; set; }

        [DataMember]
        [JsonProperty("22.5")]
        public _225 _225 { get; set; }

        [DataMember]
        [JsonProperty("45.0")]
        public _450 _450 { get; set; }

        [DataMember]
        [JsonProperty("67.5")]
        public _675 _675 { get; set; }

        [DataMember]
        [JsonProperty("90.0")]
        public _900 _900 { get; set; }

        [DataMember]
        [JsonProperty("112.5")]
        public _1125 _1125 { get; set; }

        [DataMember]
        [JsonProperty("135.0")]
        public _1350 _1350 { get; set; }

        [DataMember]
        [JsonProperty("157.5")]
        public _1575 _1575 { get; set; }

        [DataMember]
        [JsonProperty("180.0")]
        public _1800 _1800 { get; set; }

        [DataMember]
        [JsonProperty("202.5")]
        public _2025 _2025 { get; set; }

        [DataMember]
        [JsonProperty("225.0")]
        public _2250 _2250 { get; set; }

        [DataMember]
        [JsonProperty("247.5")]
        public _2475 _2475 { get; set; }

        [DataMember]
        [JsonProperty("270.0")]
        public _2700 _2700 { get; set; }

        [DataMember]
        [JsonProperty("292.5")]
        public _2925 _2925 { get; set; }

        [DataMember]
        [JsonProperty("315.0")]
        public _3150 _3150 { get; set; }

        [DataMember]
        [JsonProperty("337.5")]
        public _3375 _3375 { get; set; }
        [DataMember]
        public ALL ALL { get; set; }
        [DataMember]
        public string CLASS_1 { get; set; }
        [DataMember]
        public string CLASS_2 { get; set; }
        [DataMember]
        public string CLASS_3 { get; set; }
        [DataMember]
        public string CLASS_4 { get; set; }
        [DataMember]
        public string CLASS_5 { get; set; }
        [DataMember]
        public string CLASS_6 { get; set; }
        [DataMember]
        public string CLASS_7 { get; set; }
        [DataMember]
        public string CLASS_8 { get; set; }
        [DataMember]
        public string CLASS_9 { get; set; }
        [DataMember]
        public string CLASS_10 { get; set; }
        [DataMember]
        public string longname { get; set; }
        [DataMember]
        public string units { get; set; }
        [DataMember]
        public string note { get; set; }
    }
}

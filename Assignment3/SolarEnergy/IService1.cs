using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SolarEnergy
{
    // Interface for SolarEnergyService
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        SolarEnergyData GetSolarEnergyData(double lati, double longi);

        [OperationContract]
        string GetSolarReport(double lati, double longi);

    }

    // Below are all the POJO classes required to obtain SolarEnergyData
    [DataContract]
    public class SolarEnergyData
    {
        [DataMember]
        public string version { get; set; }

        [DataMember]
        public List<string> warnings { get; set; }
        [DataMember]
        public List<string> errors { get; set; }
        [DataMember]
        public Metadata metadata { get; set; }
        [DataMember]
        public Inputs inputs { get; set; }

        [DataMember]
        public Outputs outputs { get; set; }

        // Constructor to set default values
        public SolarEnergyData()
        {
            version = "1.0.0"; // Default version
            warnings = new List<string>(); // Default empty list of warnings
            errors = new List<string>(); // Default empty list of errors
            metadata = new Metadata(); // Default Metadata object with its own default values
            inputs = new Inputs(); // Default Inputs object with its own default values
            outputs = new Outputs(); // Default Outputs object with its own default values
        }


    }

    [DataContract]
    public class Metadata
    {
        [DataMember]
        public List<string> sources { get; set; }

        public Metadata()
        {
            sources = new List<string>();
        }
    }

    [DataContract]
    public class Inputs
    {
        [DataMember]
        public string lat { get; set; }
        [DataMember]
        public string lon { get; set; }
    }

    [DataContract]
    public class Outputs
    {
        [DataMember]
        public AvgDni avg_dni { get; set; }
        [DataMember]
        public AvgGhi avg_ghi { get; set; }
        [DataMember]
        public AvgLatTilt avg_lat_tilt { get; set; }

        // Constructor to set default values
        public Outputs()
        {
            avg_dni = new AvgDni(); // Default instance of AvgDni (set default values in AvgDni constructor)
            avg_ghi = new AvgGhi(); // Default instance of AvgGhi (set default values in AvgGhi constructor)
            avg_lat_tilt = new AvgLatTilt(); // Default instance of AvgLatTilt (set default values in AvgLatTilt constructor)
        }
    }

    [DataContract]
    public class AvgDni
    {
        [DataMember]
        public double annual { get; set; }
        [DataMember]
        public Monthly monthly { get; set; }

        // Constructor to set default values
        public AvgDni()
        {
            // Set default values here
            annual = 0.0; // You can set any default value you prefer
            monthly = new Monthly(); // Assuming Monthly is a class with its own default values
        }
    }

    [DataContract]
    public class AvgGhi
    {
        [DataMember]
        public double annual { get; set; }
        [DataMember]
        public Monthly monthly { get; set; }

        public AvgGhi()
        {
            // Set default values here
            annual = 0.0; // You can set any default value you prefer
            monthly = new Monthly(); // Assuming Monthly is a class with its own default values
        }
    }

    [DataContract]
    public class AvgLatTilt
    {
        [DataMember]
        public double annual { get; set; }
        [DataMember]
        public Monthly monthly { get; set; }

        public AvgLatTilt()
        {
            // Set default values here
            annual = 0.0; // You can set any default value you prefer
            monthly = new Monthly(); // Assuming Monthly is a class with its own default values
        }
    }

    [DataContract]
    public class Monthly
    {
        [DataMember]
        public double jan { get; set; }
        [DataMember]
        public double feb { get; set; }
        [DataMember]
        public double mar { get; set; }
        [DataMember]
        public double apr { get; set; }
        [DataMember]
        public double may { get; set; }
        [DataMember]
        public double jun { get; set; }
        [DataMember]
        public double jul { get; set; }
        [DataMember]
        public double aug { get; set; }
        [DataMember]
        public double sep { get; set; }
        [DataMember]
        public double oct { get; set; }
        [DataMember]
        public double nov { get; set; }
        [DataMember]
        public double dec { get; set; }

        public Monthly()
        {
            // Set default values for each month
            jan = 0.0;
            feb = 0.0;
            mar = 0.0;
            apr = 0.0;
            may = 0.0;
            jun = 0.0;
            jul = 0.0;
            aug = 0.0;
            sep = 0.0;
            oct = 0.0;
            nov = 0.0;
            dec = 0.0;
        }
    }
}

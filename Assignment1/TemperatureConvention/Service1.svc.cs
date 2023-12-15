using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TemperatureConvention
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class TemperatureConvention1 : ITemperatureConvention1
    {
        // Simple method to convert Celcius to Fahrenheit
        public float c2f(float c)
        {
            return (c * (9f/5f)) + 32;
        }

        // Simple method to convert Fahrenheit to Celcius
        public float f2c(float f)
        {
            return (f - 32) * (5f / 9f);
        }

    }
}

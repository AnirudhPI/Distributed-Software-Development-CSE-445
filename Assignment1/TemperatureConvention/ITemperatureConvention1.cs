using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TemperatureConvention
{
    // The interface for Temperature service.
    // It has two methods to convert between Celcius and Fahrenheit scales.
    [ServiceContract]
    public interface ITemperatureConvention1
    {

        [OperationContract]
        float c2f(float c);
        
        [OperationContract]
        float f2c(float f);

    }

}

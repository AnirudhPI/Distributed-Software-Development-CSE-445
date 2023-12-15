using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SortingService
{

    // The interface for Sorting service.
    // It has one methods to sort the given input..
    [ServiceContract]
    public interface ISortingService1
    {

        [OperationContract]
        string Sort(String numbers);

    }
}

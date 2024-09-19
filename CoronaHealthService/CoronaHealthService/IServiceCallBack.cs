using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CoronaHealthService
{
    public interface IServiceCallBack
    {
        [OperationContract]
        void OnIncreaseCapacity();

        [OperationContract]
        void OnUpdateLocations();
    }
}

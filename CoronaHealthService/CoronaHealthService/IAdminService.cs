using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CoronaHealthService
{
    [ServiceContract(CallbackContract = typeof(IServiceCallBack))]
    public interface IAdminService
    {
        [OperationContract]
        List<Ggd> GetGgdInfo();

        [OperationContract(IsOneWay = true)]
        void IncreaseCapacity(string centerLocation);

        [OperationContract]
        void Connect();

        [OperationContract]
        void Disconnect();

        [OperationContract]
        void AddAdditionalCoronaTestLocation(string ggdCode, string ggdCity, int availableCapacity, string testCenterAddress);
    }
}

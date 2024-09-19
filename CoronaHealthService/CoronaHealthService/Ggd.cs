using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CoronaHealthService
{
    [DataContract]
    public class Ggd
    {
        [DataMember]
        public string GgdCode { get; set; }

        [DataMember]
        public string GgdCity { get; set; }

        [DataMember]
        public ServicesProvided ServicesProvided { get; set; }

        [DataMember]
        public int AvailableCapacity { get; set; }

        [DataMember]
        public string TestCenterAddress { get; set; }

        public Ggd(string ggdCode, string ggdCity, ServicesProvided servicesProvided, int availableCapacity, string testCenterAddress)
        {
            GgdCode = ggdCode;
            GgdCity = ggdCity;
            ServicesProvided = servicesProvided;
            AvailableCapacity = availableCapacity;
            TestCenterAddress = testCenterAddress;
        }
    }
}

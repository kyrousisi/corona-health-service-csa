using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CoronaHealthService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class CoronaHealthService : IReservationService, IAdminService
    {
        List<Ggd> ggdOffices;
        List<IServiceCallBack> serviceCallBacks;

        public CoronaHealthService()
        {
            ggdOffices = new List<Ggd>();
            ggdOffices.Add(new Ggd("GGD, 01", "Eindhoven", ServicesProvided.CoronaTest, 4, "Antoon Coolenlaan 3"));
            ggdOffices.Add(new Ggd("GGD, 02", "Veldhoven", ServicesProvided.HealthResearch, 10, "Random address 2"));
            ggdOffices.Add(new Ggd("GGD, 03", "Amsterdam", ServicesProvided.Vaccination, 100, "Kuilenhurk 1"));
            ggdOffices.Add(new Ggd("GGD, 04", "Tilburg", ServicesProvided.YouthCare, 100, "Random address 4"));
            ggdOffices.Add(new Ggd("GGD, 05", "Utrecht", ServicesProvided.CoronaTest, 3, "Random address 5"));

            serviceCallBacks = new List<IServiceCallBack>();
        }

        public string GetServiceName()
        {
            return "GGD Corona Test";
        }

        public List<Ggd> GetAvailableTestLocations()
        {
            List<Ggd> coronaCenters = ggdOffices.FindAll(o => o.ServicesProvided == ServicesProvided.CoronaTest);

            return coronaCenters;
        }

        public bool MakeReservation(string centerLocation)
        {
            foreach (Ggd ggdOffice in ggdOffices)
            {
                if (ggdOffice.GgdCity == centerLocation && ggdOffice.AvailableCapacity > 0)
                {
                    ggdOffice.AvailableCapacity--;
                    return true;
                }
            }
            return false;
        }

        public bool CancelReservation(string centerLocation)
        {
            foreach (Ggd ggdOffice in ggdOffices)
            {
                if (ggdOffice.GgdCity == centerLocation)
                {
                    ggdOffice.AvailableCapacity++;
                    return true;
                }
            }
            return false;
        }

        public List<Ggd> GetGgdInfo()
        {
            return ggdOffices;
        }

        public void IncreaseCapacity(string centerLocation)
        {
            foreach (Ggd ggdOffice in ggdOffices)
            {
                if (ggdOffice.GgdCity == centerLocation)
                {
                    ggdOffice.AvailableCapacity++;
                    foreach (IServiceCallBack serviceCallBack in serviceCallBacks)
                    {
                        serviceCallBack.OnIncreaseCapacity();
                    }
                }
            }
        }

        public void Connect()
        {
            IServiceCallBack client = OperationContext.Current.GetCallbackChannel<IServiceCallBack>();
            serviceCallBacks.Add(client);
        }
        public void Disconnect()
        {
            IServiceCallBack client = OperationContext.Current.GetCallbackChannel<IServiceCallBack>();
            serviceCallBacks.Remove(client);
        }

        public void AddAdditionalCoronaTestLocation(string ggdCode, string ggdCity, int availableCapacity, string testCenterAddress)
        {
            ggdOffices.Add(new Ggd(ggdCode, ggdCity, ServicesProvided.CoronaTest, availableCapacity, testCenterAddress));
            foreach (IServiceCallBack serviceCallBack in serviceCallBacks)
            {
                serviceCallBack.OnUpdateLocations();
            }
        }
    }
}

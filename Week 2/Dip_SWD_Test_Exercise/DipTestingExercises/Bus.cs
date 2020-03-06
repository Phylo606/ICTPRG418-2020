using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipTestingExercises
{
    public class Bus: MotorVehicle
    {
        public List<IPerson> passengers = new List<IPerson>();
        public int maxPassengers { get; set; }

        public Bus(IPerson pDriver, int pMaxFuel, int pCurrent, int pLitresPerKM, int pMaxPassengers):base(pDriver, pMaxFuel, pCurrent, pLitresPerKM)
        {
            maxPassengers = pMaxPassengers;
        }

        public void embarkPassenger(IPerson pPassenger)
        {
            if (passengers.Count < maxPassengers)
            {
                passengers.Add(pPassenger);
            }
            else
            {
                throw new Exception("Bus is Already Full!");
            }
        }

        public int getPassengerCount()
        {
            return passengers.Count;
        }
    }
}

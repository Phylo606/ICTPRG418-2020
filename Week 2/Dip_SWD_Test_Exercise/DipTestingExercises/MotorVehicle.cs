using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipTestingExercises
{
    public abstract class MotorVehicle: IVehicle
    {
        public IPerson driver { set; get; }
        public int maxFuel { get; set; }
        public int currentFuel { get; set; }
        public int litresPerKM { get; set; }


        public MotorVehicle(IPerson pDriver, int pMax, int pCurrent, int pLitresPerKM)
        {
            driver = pDriver;
            maxFuel = pMax;
            currentFuel = pCurrent;
            litresPerKM = pLitresPerKM;
        }


        public void refuel(int pLitres)
        {
            int currentCapacity = maxFuel - currentFuel;

            if (pLitres > currentCapacity)
            {
                // not enough room for that much fuel
                throw new Exception("Vehicle cannot hold that much fuel!");
            }
            else if (pLitres < 0)
            {
                // taking fuel from the vehicle
                throw new Exception("Someone is stealing fuel!!");
            }
            else
            {
                currentFuel = currentFuel + pLitres;
            }
            
        }

        public int getFuelRemaining()
        {
            return currentFuel;
        }

        public void travel(int pKMTavelled)
        {

            int fuelRequired = litresPerKM * pKMTavelled;

            if (fuelRequired > currentFuel)
            {
                currentFuel = 0;
                throw new Exception("Out of Fuel!");
            }
            else
            {
                currentFuel -= fuelRequired;
            }   
        }

    }
}

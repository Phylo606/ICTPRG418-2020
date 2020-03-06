using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipTestingExercises
{
    interface IVehicle
    {
        void travel(int pKMTavelled);
        void refuel(int pLitres);

        int getFuelRemaining();
    }
}

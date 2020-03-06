using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipTestingExercises
{
    public class Driver: Person
    {
        private string licenceType;

        public Driver(string pFname, string pLname, string pGender, string pLicence): base(pFname, pLname, pGender)
        {
            licenceType = pLicence;
        }

        public string getLicenceType()
        {
            return licenceType;
        }
    }
}

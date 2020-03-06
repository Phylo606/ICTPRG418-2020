using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipTestingExercises
{
    public abstract class Person: IPerson
    {
        public string fname { set; get; }
        public string lname { set; get; }
        private string gender;

        public Person(string pFname, string pLname, string pGender)
        {
            fname = pFname;
            lname = pLname;
            gender = pGender;
        }

        public string getName()
        {
            return fname + " " + lname;
        }

        public string getGender()
        {
            return gender;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipTestingExercises
{
    public class Passenger: Person
    {
        private string ticketType;

        public Passenger(string pFname, string pLname, string pGender, string pTicketType): base(pFname, pLname, pGender)
        {
            ticketType = pTicketType;
        }

        public string getTicketType()
        {
            return ticketType;
        }
    }
}

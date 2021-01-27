using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject
{
    class PersonCheckManager : IPersonCheckServices
    {
        public bool CheckIfRealPerson(Person person)
        {
            if (person.FirstName.Trim().Length > 0 && person.LastName.Trim().Length > 0 && person.CitizenshipId.Trim().Length == 11 && person.BirthDate.Year > 1900) ;
            {
                return true;
            }
        }
    }
}


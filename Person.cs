using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject
{
    class Person:IEntity
    {
        public string CitizenshipId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}

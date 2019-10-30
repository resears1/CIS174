using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    public class PersonSummary
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NumberOfAccomplishments { get; set; }

        public static PersonSummary FromPerson(PersonSummary person)
        {
            return new PersonSummary
            {
                Id = person.Id,
                FirstName = person.FirstName,
                LastName = person.LastName,
            };
        }
    }
}

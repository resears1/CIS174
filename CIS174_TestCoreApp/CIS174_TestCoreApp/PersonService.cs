using CIS174_TestCoreApp.Entities;
using CIS174_TestCoreApp.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp
{
    public class PersonService
    {
        readonly PersonContext _context;

        public PersonService(PersonContext context)
        {
            _context = context;
        }

        public ICollection<PersonSummary> GetPeople()
        {
            return _context.People
                .Where(p => !p.IsDeleted)
                .Select(p => new PersonSummary
                {
                    Id = p.Id,
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                })
                .ToList();
        }

        public PersonDetail GetPersonDetail(int id)
        {
            return _context.People
                .Where(x => x.Id == id)
                .Where(x => !x.IsDeleted)
                .Select(x => new PersonDetail
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Birthdate = x.Birthdate,
                    City = x.City,
                    State = x.State,
                    Accomplishments = x.Accomplishments
                    .Select(item => new PersonDetail.Item
                    {
                        Name = item.Name,
                        DateOfAccomplishment = item.DateOfAccomplishment
                    })
                })
                .SingleOrDefault();
        }

        public UpdatePersonCommand GetPersonForUpdate(int Id)
        {
            return _context.People
                .Where(x => x.Id == Id)
                .Where(x => !x.IsDeleted)
                .Select(x => new UpdatePersonCommand
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Birthdate = x.Birthdate,
                    City = x.City,
                    State = x.State,
                })
                .SingleOrDefault();
        }

        public int CreatePerson(CreatePersonCommand cmd)
        {
            var person = cmd.ToPerson();
            _context.Add(person);
            _context.SaveChanges();
            return person.Id;
        }


        public void UpdatePerson(UpdatePersonCommand cmd)
        {
            var person = _context.People.Find(cmd.Id);
            if (person == null) { throw new Exception("Unable to find the person"); }
            if (person.IsDeleted) { throw new Exception("Unable to update a deleted person"); }

            cmd.UpdatePerson(person);
            _context.SaveChanges();
        }

        public void DeletePerson(int id)
        {
            var person = _context.People.Find(id);
            if (person.IsDeleted) { throw new Exception("Unable to delete a deleted person"); }

            person.IsDeleted = true;
            _context.SaveChanges();
        }
    }
}

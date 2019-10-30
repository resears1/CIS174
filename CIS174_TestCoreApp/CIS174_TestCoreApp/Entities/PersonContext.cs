using CIS174_TestCoreApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Entities
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options)
            : base(options)
        {

        }

        readonly PersonContext _context;

        public int CreatePerson(CreatePersonCommand cmd)
        {
            var person = new Person
            {
                FirstName = cmd.FirstName,
                LastName = cmd.LastName,
                Birthdate = cmd.Birthdate,
                City = cmd.City,
                State = cmd.State,
                Accomplishments = cmd.Accomplishments?.Select(i =>
                    new Accomplishment
                    {
                        Name = i.Name,
                        DateOfAccomplishment = i.DateOfAccomplishment,
                    }).ToList()
            };
            _context.Add(person);
            _context.SaveChanges();
            return person.Id;
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Accomplishment> Accomplishments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server=tcp:cis174resears1.database.windows.net,1433;Initial Catalog=CIS174DB;Persist Security Info=False;User ID=cis174;Password=basiciris159.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
    }
}

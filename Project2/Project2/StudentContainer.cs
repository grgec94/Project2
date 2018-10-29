using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class StudentContainer
    {
        private static StudentContainer instance;       //stvorili smo instancu singleton storage-a

        private List<Person> Storage { get; set; }      // kreiranje liste     

        private StudentContainer()                      //konstruktor te klase
        {
            Storage = new List<Person>();               //konstruktor??
        }

        public static StudentContainer Instance => instance ?? (instance = new StudentContainer());  // ???

        public Person Add(Person role)                  // Add metoda povratnog tipa Person
        {
            Storage.Add(role);                          // Dodaj u listu
            return role;
        }
    }
    public IEnumerable<Person> FindAll()
    {
        return StudentContainer.ToList();
    }

    public Person Get(string Roles, string Role)
    {
        if (string.IsNullOrEmpty(Role))
        {
            return StudentContainer.FirstOrDefault(e => e.Roles == Role);
        }

        return StudentContainer.FirstOrDefault(e => e.Roles == Role);
    }
}
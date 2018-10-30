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

        public IEnumerable<Person> FindAll()
        {
            return Storage.ToList();
        }

        public Person Get(int id, string lastName)
        {
            if (string.IsNullOrEmpty(lastName))
            {
                return Storage.FirstOrDefault(e => e.Id == id);
            }

            return Storage.FirstOrDefault(e => e.Id == id && e.LastName == lastName);
        }
    }
}
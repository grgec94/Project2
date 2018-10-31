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

        public Person Get(int id, string roleName)
        {
            if (string.IsNullOrEmpty(roleName))
            {
                return Storage.FirstOrDefault(e => e.Id == id);
            }

            return Storage.FirstOrDefault(e => e.Id == id && e.LastName == roleName);
        }

        public IEnumerable<Person> Find(string roleName)
        {
            if (!string.IsNullOrEmpty(roleName))
            {
                return Storage.Where(e => e.Role == roleName).ToList();
            }

            return Storage.Where(e => e.Role != Roles.Student).ToList();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Project2
{

        public abstract class BaseService<T> where T : Person, new()
        {
            private readonly string roleName;
            private readonly StudentContainer storage;

            protected BaseService(string roleName)
            {
                this.roleName = roleName;
                storage = StudentContainer.Instance;

            }

            protected StudentContainer GetStorageInstance() => storage;
            public virtual T Add()
            {
                T model = new T();

                var valid = false;
                do
                {
                    Console.WriteLine("First name");
                    valid = Console.ReadLine().IsValidString(out var firstName);
                    model.FirstName = firstName;
                } while (!valid);

                do
                {
                    Console.WriteLine("Last name");
                    valid = Console.ReadLine().IsValidString(out var lastName);
                    model.LastName = lastName;
                } while (!valid);

                do
                {
                    Console.WriteLine("Gpa");
                    valid = Console.ReadLine().IsValidInt(out var gpa);
                    int gpa1 = gpa;

                } while (!valid);

                model.FirstName = roleName;

                model = AddSpecific(model);

                return storage.Add(model) as T;
            }
            public virtual T Get(int id)
            {
                var result = storage.Get(id, roleName) as T;

                if (result != null)
                {
                    DisplaySingle(result);
                }

                return result;
            }

            protected IEnumerable<Person> FindAll()
            {

                return storage.FindAll();

            }

            protected abstract T AddSpecific(T model);
        
            protected abstract void DisplayList(IEnumerable<T> list);
        
            protected abstract void DisplaySingle(T model);
        
        }
}
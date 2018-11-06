using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Project.Code
{
    public class StudentService : Person
    {
        private readonly StudentContainer storage;

        public StudentService()
        {
            storage = StudentContainer.Instance;
        }

        protected StudentContainer GetStorageInstance() => storage;

        public virtual Student Add()
        {
            Student model = new Student();
            model.Id = StudentIdGenerator.Instance.GetUniqueId();

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
                valid = Console.ReadLine().IsValidFloat(out var gpa);
                model.Gpa = gpa;
            } while (!valid);
            return storage.Add(model);
        }


        public IEnumerable<Person> FindAll()
        {
            return StudentContainer.Instance.FindAll();
        }

        public IEnumerable<Student> HandleDisplay()
        {

            var list = storage.FindAll().ToArray();

            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine($" {list[i].Id}: {list[i].LastName}, {list[i].FirstName}, {list[i].Gpa}");
            }
            return list;
        }

    }
}
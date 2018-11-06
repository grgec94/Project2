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

        public void HandleAdd()
        {
            string role;
            do
            {
                Console.WriteLine("Select person:");
                role = Console.ReadLine();
                role = role.ToUpper();
                if (role != "STUDENT")
                {
                    Console.WriteLine("Wrong input, only input is student");
                }

            } while (role != "STUDENT");

            switch (role)
            {
                case "STUDENT":
                    Add();
                    break;

            }
        }
        public IEnumerable<Person> FindAll()
        {
            return StudentContainer.Instance.FindAll();
        }

        public IEnumerable<Student> HandleDisplay()
        {

            var List = storage.FindAll().Cast<Student>().ToArray();

            for (int i = 0; i < List.Length; i++)
            {
                Console.WriteLine($" {List[i].Id}: {List[i].LastName}, {List[i].FirstName}, {List[i].Gpa}");
            }
            return List;
        }

    }
}
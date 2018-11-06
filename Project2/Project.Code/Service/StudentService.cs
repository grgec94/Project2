using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Project2
{
    public class StudentService<T> where T : Person, new()
    {
        private readonly StudentContainer storage;

        public StudentService()
        {
            storage = StudentContainer.Instance;
        }

        protected StudentContainer GetStorageInstance() => storage;

        public virtual T Add()
        {
            T model = new T();
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
                valid = Console.ReadLine().IsValidInt(out var gpa);
                model.Gpa = gpa;
            } while (!valid);
            return storage.Add(model) as T;
        }
    }

    public class EmployeeService
    {
        private readonly StudentService<Student> studentService;

        public EmployeeService()
        {
            studentService = new StudentService<Student>();
        }
        public void HandleAdd()
        {

            string role;
            do
            {
                Console.WriteLine("Select person:");
                role = Console.ReadLine();
               if (role != "student")
                {
                    Console.WriteLine("Wrong input");
                }
            } while (role != "student");

            studentService.Add();

        }
        public IEnumerable<Person> HandleDisplay()
        {
            var employeeList = StudentContainer.Instance.FindAll().ToArray();

            for (int i = 0; i < employeeList.Length; i++)
            {
                if (employeeList[i].Role == Roles.Student)
                {
                    studentService.DisplaySingle(employeeList[i] as Student);
                }
                //Console.WriteLine($"#{i + 1}. {employeeList[i].LastName} {employeeList[i].FirstName} {employeeList[i].Role}");

            }

            return employeeList;
        }
    }
}

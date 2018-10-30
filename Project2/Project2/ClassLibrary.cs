using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

//JEZGRA BIZNIS LOGIKE
namespace Project2
{
    class ClassLibrary
    {
        private readonly CommonService commonService;
        private readonly StudentService studentService;

        public ClassLibrary()
        {
            commonService = new CommonService();
            studentService = new StudentService();
        }

        public void HandleAdd()
        {
           string role;
            do
            {
                Console.WriteLine("Select person:");
              role = Console.ReadLine();

            } while (role != "student");
            studentService.Add();

        }
        public IEnumerable<Person> HandleDisplay()
        {
            var employeeList = commonService.FindAll().ToArray();

            for (int i = 0; i < employeeList.Length; i++)
            {
                Console.WriteLine($"#{i + 1}. {employeeList[i].LastName} {employeeList[i].FirstName} - {employeeList[i].Gpa}");
            }

            return employeeList;
        }
    }
}

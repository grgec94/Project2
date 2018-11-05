using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

//JEZGRA BIZNIS LOGIKE
namespace Project2
{
    public class EmployeeService
    {
        private readonly CommonService commonService;
        private readonly StudentService studentService;

        public EmployeeService()
        {
            commonService = new CommonService();
            studentService = new StudentService();
        }

        public void HandleAdd()
        {
            var valid = false;
            string role;
            do
            {
                Console.WriteLine("Select person:");
                role = Console.ReadLine();
                valid =RoleValidator.IsValidRole(role);

            } while (!valid);
            
            studentService.Add();

        }
        public IEnumerable<Person> HandleDisplay()
        {
            var employeeList = commonService.FindAll().ToArray();

            for (int i = 0; i < employeeList.Length; i++)
            {
                if (employeeList[i].Role == Roles.Student)
                {
                    studentService.DisplaySingle(employeeList[i] as StudentRole);
               }
                //Console.WriteLine($"#{i + 1}. {employeeList[i].LastName} {employeeList[i].FirstName} {employeeList[i].Role}");
             
            }

            return employeeList;

        }
        public void HandleList(string roleName)
        {
            switch (roleName)
            {
                case Roles.Student:
                    studentService.Find();
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Project2
{
    public class StudentService : BaseService<StudentRole>
    {
        public StudentService() : base(Roles.Student)
        {
        }
                
        protected override StudentRole AddSpecific(StudentRole model)
        {

            bool valid;
            do
            {
                Console.WriteLine("What Gpa has he/she ?");
                valid = Console.ReadLine().IsValidString(out var gpa);
                model.Gpa = float.Parse(gpa, CultureInfo.InvariantCulture.NumberFormat);
            } while (!valid);
            return model;
        }

        protected override void DisplayList(IEnumerable<StudentRole> list)
        {
            foreach (var item in list)
            {
                DisplaySingle(item);
            }
        }

        public override void DisplaySingle(StudentRole model)
        {
            Console.WriteLine($"{model.Id}: {model.LastName} {model.FirstName}, Gpa: {model.Gpa} ");
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class StudentContainer
    {
        private static StudentContainer instance;      

        private List<Student> Storage { get; set; }        

        private StudentContainer()                 
        {
            Storage = new List<Student>();            
        }

        public static StudentContainer Instance => instance ?? (instance = new StudentContainer());  

        public Student Add(Student role)                  
        {
            Storage.Add(role);                         
            return role;
        }

        public IEnumerable<Student> FindAll()
        {
            return Storage.ToList();
        }

    }
}
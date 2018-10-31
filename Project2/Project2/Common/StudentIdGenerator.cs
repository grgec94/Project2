using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class StudentIdGenerator
    {
        private static StudentIdGenerator instance;

        private int uniqueId;

        private StudentIdGenerator()
        {
            uniqueId = 0;
        }

        public static StudentIdGenerator Instance => instance ?? (instance = new StudentIdGenerator());

        public int GetUniqueId()
        {
            return uniqueId++;
        }
    }
}
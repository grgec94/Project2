using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    public class CommonService : Student<Person>
    {
        public CommonService() : base(string.Empty)
        {
        }

        public new IEnumerable<Student> FindAll()
        {
            return base.FindAll();
        }

        protected override Student AddSpecific(Student model)
        {
            throw new NotImplementedException();
        }

        protected override void DisplayList(IEnumerable<Student> list)
        {
            throw new NotImplementedException();
        }
    }
}
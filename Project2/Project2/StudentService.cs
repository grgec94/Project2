using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    public class StudentService : BaseService<StudentRole>
    {
        protected override StudentRole AddSpecific(StudentRole model)
        {
            throw new NotImplementedException();
        }

        protected override void DisplayList(IEnumerable<StudentRole> list)
        {
            throw new NotImplementedException();
        }

        protected override void DisplaySingle(StudentRole model)
        {
            throw new NotImplementedException();
        }
    }
}

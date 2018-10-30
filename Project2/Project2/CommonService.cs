using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    public class CommonService : BaseService<Person>
    {
        public CommonService() : base(string.Empty)
        {
        }

        public new IEnumerable<Person> FindAll()
        {
            return base.FindAll();
        }


        protected override Person AddSpecific(Person model)
        {
            throw new NotImplementedException();
        }


        protected override void DisplayList(IEnumerable<Person> list)
        {
            throw new NotImplementedException();
        }

        protected override void DisplaySingle(Person model)
        {
            throw new NotImplementedException();
        }
    }
}
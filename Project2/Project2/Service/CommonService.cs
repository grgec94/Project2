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

        public IEnumerable<Person> Find(string roleName)
        {
            return GetStorageInstance().Find(roleName);
        }

        protected override Person AddSpecific(Person model)
        {
            throw new NotImplementedException();
        }


        protected override void DisplayList(IEnumerable<Person> list)
        {
            throw new NotImplementedException();
        }

        public override void DisplaySingle(Person model)
        {
            throw new NotImplementedException();
        }
    }
}
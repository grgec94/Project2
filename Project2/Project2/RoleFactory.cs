using System;
using System.Collections.Generic;
using System.Text;

namespace Project2
{
    public class RoleFactory
    {
        public Person Create(string roleName)
        {
            switch (roleName)
            {
                case Roles.Student:
                    return new StudentRole();
                default:
                    return new Person();
            }
        }
    }
}
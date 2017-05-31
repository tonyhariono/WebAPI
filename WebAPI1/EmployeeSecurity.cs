﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeDataAccess;

namespace WebAPI1
{
    public class EmployeeSecurity
    {
        public static bool Login(string username,string password)
        {
            using(EmployeeDBEntities entities=new EmployeeDBEntities())
            {
                return entities.Users.Any(user => user.Username.Equals(username,
                    StringComparison.OrdinalIgnoreCase) && user.Password == password);
            }
        }
    }
}
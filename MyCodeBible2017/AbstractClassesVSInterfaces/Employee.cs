using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractClassesVSInterfaces
{
    public abstract class Employee
    {
        //we can have fields and properties in the Abstract class

        protected String id;
        protected String lname;
        protected String fname;

        //properties
        public abstract String ID
        {
            get;
            set;
        }

        public abstract String FirstName
        {
            get;
            set;
        }

        public abstract String LastName
        {
            get;
            set;
        }

        //completed methods
        public String Update()
        {
            return "Employee " + id + " " +
                      lname + " " + fname +
                      " updated";
        }

        //completed methods
        public String Add()
        {
            return "Employee " + id + " " +
                      lname + " " + fname +
                      " added";
        }
        
        //completed methods
        public String Delete()
        {
            return "Employee " + id + " " +
                      lname + " " + fname +
                      " deleted";
        }

        //completed methods
        public String Search()
        {
            return "Employee " + id + " " +
                      lname + " " + fname +
                      " found";
        }

        //abstract method that is different from Fulltime and Contractor therefore i keep it 
        // uncompleted and let each implementation complete it the way they calculate the wage.
        public abstract String CalculateWage();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractClassesVSInterfaces
{
    public interface IEmployee
    {
        //cannot have fields. uncommenting will raise error!
        //        protected String id;
        //        protected String lname;
        //        protected String fname;

        //just signature of the properties and methods.  
        // setting a rule or contract to be followed by implementations.
        String ID
        {
            get;
            set;
        }

        String FirstName
        {
            get;
            set;
        }

        String LastName
        {
            get;
            set;
        }

        // cannot have implementation 
        // cannot have modifiers public 
        // etc all are assumed public
        // cannot have virtual
        String Update();

        String Add();

        String Delete();

        String Search();

        String CalculateWage();
    }
}

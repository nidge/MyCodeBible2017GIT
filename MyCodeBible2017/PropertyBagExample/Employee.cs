using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyBagExample
{
    class Employee
    {
        public int id;
        public string name;

        // START Everything you need to add to the Employee class to make it handle PropertyBags
        private PropertyBag _properties; // COMPOSITION

        public PropertyBag Properties
        {
            get { return _properties; }
            set { _properties = value; }
        }

        public Employee()
        {
            this._properties = new PropertyBag();
        }
        // END Everything you need to add to the Employee class to make it handle PropertyBags        

    }
       
}

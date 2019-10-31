using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyBagExample
{
    public class PropertyBag
    {
        private Hashtable _propertyBag = new Hashtable();
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        // Indexer which takes the name of the property and retrieves it from the PropertyBag  
        public Property this[string Name]
        {
            get
            {
                Property prop;
                // if a property with this name already exists, return it     
                if (_propertyBag.Contains(Name))
                    prop = (Property)_propertyBag[Name];
                else // else, create a new property with this name
                {
                    prop = new Property(Name);
                    _propertyBag.Add(Name, prop);
                }
                return prop;
            }
        }

        public class Property : System.Object
        {
            private string _name;                         // name of property
            private System.Object _value;                 // value of property

            public System.Object Value
            {
                get { return _value; }
                set
                {
                    // ensure thread safety
                    lock (this)
                    {
                        _value = this.GetType().GetProperty(_name);
                    }
                }
            }

            public Property(string _inName)
            {
                this._name = _inName;
            }
        }
    }
}

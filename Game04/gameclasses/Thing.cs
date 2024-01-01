using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game04.gameclasses
{
    public class Thing
    {
        private string _name;
        private string _description;
        private bool _cantake;

        public Thing(string aName, string aDescription)
        {
            // standard constructor: 
            _name = aName;
            _description = aDescription;
            _cantake = true;
        }

        public Thing(string aName, string aDescription, bool aCantake)
        {
            // alternative constructor
            _name = aName;
            _description = aDescription;
            _cantake = aCantake;
        }

        //  Name property
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        // Description property
        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public bool CanTake
        {
            get => _cantake;
            set => _cantake = value;
        }

        public virtual string Describe()
        {
            return Name + " " + Description;
        }
    }
}

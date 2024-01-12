using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Game04.gameclasses
{
    [Serializable]
    public class Treasure : Thing
    {
        private bool _isTreasure;

        public Treasure(string aName, string aDescription, bool aCantake, bool isMoveable, bool isTreasure) :
            base(aName, aDescription, aCantake, isMoveable)
        {
            _isTreasure = isTreasure;
        }

        public bool IsTreasure
        {
            get => _isTreasure;
            set => _isTreasure = value;

        }

        public override string Describe()
        {
            return $"The {Name} is a Treasure and is worth keeping. {Description}";
        }
    }
}

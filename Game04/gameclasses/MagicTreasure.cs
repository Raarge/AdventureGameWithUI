using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game04.gameclasses
{
    public class MagicTreasure : Treasure
    {
        private bool _isMagical;

        public MagicTreasure(string aName, string aDescription, bool aCantake, bool isMoveable, bool isTreasure, bool isMagical) : 
            base(aName, aDescription, aCantake, isMoveable, isTreasure)
        {
            _isMagical = isMagical;
        }

        public bool IsMagical
        {
            get => _isMagical;
            set => _isMagical = value;
        }

        public override string Describe()
        {
            return $"The {Name} is a magical treasure you sense power within it. {Description}";
        }
    }
}

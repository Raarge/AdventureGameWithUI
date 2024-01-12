using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game04.gameclasses
{
    [Serializable]
    public class WeaponTreasure : Treasure
    {
        private bool _isWeapon;
        private WeapType _aType;

        public WeaponTreasure(string aName, string aDescription, bool aCantake, bool isMoveable, bool isTreasure, bool isWeapon, WeapType aType) : 
            base(aName, aDescription, aCantake, isMoveable, isTreasure)
        {
            _aType = aType;
            _isWeapon = isWeapon;
        }

        public bool IsWeapon
        {
            get => _isWeapon;
            set => _isWeapon = value;
        }

        public WeapType AType
        {
            get => _aType;
            set => _aType = value;
        }
        
        public override string Describe()
        {
            return $"The {Name} is a weapon of type {AType}. {Description}";
        }
    }
}

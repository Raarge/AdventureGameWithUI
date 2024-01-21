using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game04.gameclasses
{
    [Serializable]
    public class Lockpick : Thing
    {
        private bool _worksOnLocks;
        private LPQuality _lpQ;
        private int _grade;
        private int _durab;
        private int lphp;  //TO DO ** add methods to determing hp of the pick for breaking

        public Lockpick(string aName, string aDescription, bool aCantake, bool isMoveable, bool aWorkOnLocks, LPQuality aLpq, int aGrade, int aDurab) :
            base(aName, aDescription, aCantake, isMoveable)
        {
            _worksOnLocks = aWorkOnLocks;
            _lpQ = aLpq;
            _grade = aGrade;
            _durab = aDurab;

        }

        public void CanWorkOnLocks()
        {
            _worksOnLocks = true;
        }

        public void CanNotWorkOnLocks()
        {
            _worksOnLocks = false;
        }

        public bool WorksOnLocks
        {
            get => _worksOnLocks;
            set => _worksOnLocks = value;
        }

        public LPQuality LPQ
        {
            get => _lpQ;
            set => _lpQ = value;
        }

        public int Grade
        {
            get => _grade;
            set => _grade = value;
        }

        public int Durab
        {
            get => _durab;
            set => _durab = value;
        }

        public override string Describe()
        {
            return $"The {Name} is a lockpick of {LPQ} quality.  {Description}"; 
        }
    }
}

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
        public int lphp;  //TO DO ** add methods to determing hp of the pick for breaking

        public Lockpick(string aName, string aDescription, bool aCantake, bool isMoveable, bool aWorkOnLocks, LPQuality aLpq, int aGrade, int aDurab) :
            base(aName, aDescription, aCantake, isMoveable)
        {
            _worksOnLocks = aWorkOnLocks;
            _lpQ = aLpq;
            _grade = aGrade;
            _durab = aDurab;
            lphp = LP_HitPoits(_grade, _durab, _lpQ);

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

        public int LP_HitPoits(int grade, int durability, LPQuality qual)
        {
            int hp = 0;
            int qualmod = 0;

            Dictionary<LPQuality, int> kv = new Dictionary<LPQuality, int>();
            kv.Add(LPQuality.Dismal, 1);
            kv.Add(LPQuality.Poor, 2);
            kv.Add(LPQuality.Bent, 3);
            kv.Add(LPQuality.Fair, 4);
            kv.Add(LPQuality.Standard, 5);
            kv.Add(LPQuality.Quality, 6);
            kv.Add(LPQuality.Trick, 7);
            kv.Add(LPQuality.Special, 8);
            kv.Add(LPQuality.HighQuality, 9);
            kv.Add(LPQuality.Grandmaster, 10);

            foreach(KeyValuePair<LPQuality, int> kvp in kv)
            {
                if (kvp.Key == qual)
                {
                    qualmod = kvp.Value;
                }
            }

            hp = grade * (qualmod + durability);

            return hp;
        }

        public override string Describe()
        {
            return $"The {Name} is a lockpick of {LPQ} quality.  {Description}"; 
        }
    }
}

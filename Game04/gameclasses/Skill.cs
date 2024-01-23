using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game04.gameclasses
{
    public class Skill
    {
        private string _name;
        private double _level;

        public Skill(string aName, double aLevel)
        {
            _name = aName;
            _level = aLevel;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public double Level
        {
            get => _level;
            set => _level = value;
        }

    }
}

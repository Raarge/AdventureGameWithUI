﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game04.gameclasses
{
    [Serializable]
    public class Actor : ThingHolder
    {
        private Room _location; // Room where Actor is at present
        private SkillList _skillList = new SkillList();

        public Actor(string aName, string aDescription, Room aRoom, ThingList tl, SkillList sl) :
           base(aName, aDescription, tl)
        {
            _location = aRoom;
            _skillList = sl;
        }

        public Room Location
        {
            get => _location;
            set => _location = value;
        }

        public SkillList SkillList
        {
            get => _skillList; 
            set => _skillList = value;
        }
        public override string Describe()
        {
            return $"({Description}) is in {_location.Describe()}";
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game04.gameclasses
{
    public class SkillList : List<Skill>
    {
        public string Describe()
        {
            string s = "";

            if (this.Count == 0)
            {
                s = " nothing.\r\n";
            }
            else
            {
                foreach (Skill sk in this)
                {
                    s = s + sk.Name + " " + sk.Level +"\r\n";
                }
            }
            return s;
        }

        public Skill AddASkill(string sk)
        {
            Skill lockpicking = null;
            // learn skill and return initially set to null

            return lockpicking;
        }
    }
}

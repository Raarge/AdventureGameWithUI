using Game04.gameclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Game04
{
    partial class Adventure
    {
        public SkillList InitSkills(SkillList skillList)
        {
            _skillList = new SkillList();

            _skillList.Add(new Skill("Lockpicking", 0.00));
            _skillList.Add(new Skill("Climbing", 0.00));
            _skillList.Add(new Skill("Swimming", 0.00));
            _skillList.Add(new Skill("Appraisal", 0.00));

            return _skillList;
        }

        public void LockpickingTest (int difficulty)
        {
            Skill sk = null;

            foreach(Skill s in _player.SkillList)
            {
                if(s.Name == "Lockpicking")
                {
                    sk = s;
                }
            }

            if (sk.Level < Convert.ToDouble(difficulty))
            {
                sk.Level += (Convert.ToDouble(difficulty) - sk.Level) * .10;
            }
            _player.SkillList.Where(w => w.Name == "Lockpicking").ToList().ForEach(s => s.Level = sk.Level);
           
        }
    }
}

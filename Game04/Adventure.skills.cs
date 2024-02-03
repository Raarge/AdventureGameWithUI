using Game04.gameclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            _skillList.Add(new Skill("Mechanical Lore", 0.00));

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
                    break;
                }
            }

            if (sk.Level < Convert.ToDouble(difficulty))
            {
                sk.Level += (Convert.ToDouble(difficulty) - sk.Level) * .03;
            }
            _player.SkillList.Where(w => w.Name == "Lockpicking").ToList().ForEach(s => s.Level += sk.Level);
           
        }

        public void MechLoreTest(string typeMech)
        {
            Skill skill = null;
            double skMultiplyer = 0;

            foreach (Skill s in _player.SkillList)
            {
                if (s.Name == "Mechanical Lore")
                {
                    skill = s;
                    break;
                }
            }

            switch (typeMech)
            {
                case "Dismantle":
                    skMultiplyer = 25.000 * .001;
                    break;
                default:
                    skMultiplyer = 0.000;
                    break;
            }

            _player.SkillList.Where(w => w.Name == "Mechanical Lore").ToList().ForEach(s => s.Level += skMultiplyer);


        }

        public string LockPickAppraise(Thing lockpick)
        {
            string st = "";
            double diff = 0.000;
            Lockpick lp = null;
            Random rndD = new Random();
            Random rndI = new Random();
            int sText = 0;
            double lrnAmt = 0.000;

            if (lockpick is Lockpick)
            {
                lp = (Lockpick)lockpick;
                lrnAmt = rndD.NextDouble();
                sText = rndI.Next(1, 10);
                diff = lp.Durab;
                _player.SkillList.Where(w => w.Name == "Appraisal").ToList().ForEach(s => s.Level += lrnAmt);
                st = GetSAppraisal(diff, lp);
            }
            else
            {
                st = $"{lockpick} is not a lockpick.";
            }



            // guts of the lockpick appraisal

            return st;
        }

        private string GetSAppraisal(double diff, Thing lp)
        {
            string st = "";
            double pSkill = _player.SkillList.Where(w => w.Name == "Appraisal").Select(s => s.Level).Sum();
            double diffDiference = 0.000;

            diffDiference = pSkill/diff;


            switch ((int)diffDiference)
            {
                case 0:
                    st = $"You see nothing about {lp.Name}. ";
                    break;
                case 1:
                    st = $"You think the {lp.Name} is in decent condition";
                    break;
                case 2:
                    st = $"You think the {lp.Name} is bent";
                    break;
                case 3:
                    st = $"You think the {lp.Name} is in ok condition";
                    break;
                case 4:
                    st = $"You think the {lp.Name} is rather scuffed up";
                    break;
                case 5:
                    st = $"You think the {lp.Name} is rather bent";
                    break;
                case 6:
                    st = $"You think the {lp.Name} is in satisfactory condition";
                    break;
                case 7:
                    st = $"You think the {lp.Name} is almost broken";
                    break;
                case 8:
                    st = $"You think the {lp.Name} is in good shape"; ;
                    break;
                case 9:
                    st = $"You are resonably sure the {lp.Name} is in decent condition";
                    break;
                case 10:
                    st = $"You are positive the {lp.Name} has good health";
                    break;
                default:
                    st = $"Error Unhandled in GetSAppraisal()";
                    break;
            }




            return st; 
        }
    }
}

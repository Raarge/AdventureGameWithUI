﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game04.gameclasses
{
    [Serializable]
    public class ThingList : List<Thing>
    {

        public string Describe()
        {
            string s = "";

            if (this.Count == 0)
            {
                s = "nothing.\r\n";
            }
            else
            {
                foreach (Thing t in this)
                {
                    s = s + t.Name + ". ";
                }
            }
            return s;
        }

        public Thing ThisOb(string aName)
        {
            Thing athing = null;
            string thingName = "";
            string aNameLowCase = aName.Trim().ToLower();

            foreach (Thing t in this)
            {
                thingName = t.Name.Trim().ToLower();
                if (thingName.Equals(aNameLowCase))
                {
                    athing = t;
                }
            }
            return athing;
        }

        public Thing GetOb(string aName)
        {
            Thing athing = null;
            string thingName = "";
            string aNameLowCase = aName.Trim().ToLower();
            foreach (Thing t in this)
            {
                thingName = t.Name.Trim().ToLower();
                if (thingName.Equals(aNameLowCase))
                {
                    athing = t;
                }
            }
            return athing;
        }

        public MagicTreasure MagGetOb(string aName)
        {

            Thing t = null;
            MagicTreasure athing = null;
            string thingName = "";
            string aNameLowCase = aName.Trim().ToLower();
            foreach (Thing th in this)
            {
               if(th is MagicTreasure)
               {
                    
                        thingName = th.Name.Trim().ToLower();
                        if (thingName.Equals(aNameLowCase))
                        {
                            athing = (MagicTreasure) th;
                        }
                    
               }
                                
            }
            
            return athing;
        }
    }
}

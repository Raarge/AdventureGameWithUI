using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Game04.gameclasses
{
    [Serializable]
    public class GemTreasure : Treasure
    {
        private GemSz _gemSz;
        private GemType _gemType;
        private int _gemValue;

        public GemTreasure(string aName, string aDescription, bool aCanTake, bool isMoveable, bool isTreasure, GemSz aGemSz, GemType aGemType) :
            base (aName, aDescription, aCanTake, isMoveable, isTreasure)
        { 
            _gemSz = aGemSz;
            _gemType = aGemType;
            _gemValue = getGemVal(_gemSz, _gemType);
        }

        public int getGemVal(GemSz gs, GemType gt)
        {
            int gsv = getGemSizeVal(gs);
            int gtv = getGemTypeVal(gt);

            _gemValue = gsv * gtv;

            return _gemValue;
        }

        public int getGemSizeVal(GemSz gs)
        {
            int szMod = 0;

            Dictionary<GemSz, int> gsv = new Dictionary<GemSz, int>();
            gsv.Add(GemSz.Tiny, 1);
            gsv.Add(GemSz.Small, 2);
            gsv.Add(GemSz.Medium, 3);
            gsv.Add (GemSz.Large, 4);
            gsv.Add(GemSz.Humongus, 5);

            foreach(KeyValuePair<GemSz, int> kv in gsv)
            {
                if (kv.Key == _gemSz)
                {
                    szMod = kv.Value;
                }
            }
            return szMod;
        }

        public int getGemTypeVal(GemType gt)
        {
            int typeMod = 0;

            Dictionary<GemType, int> gtv = new Dictionary<GemType, int>();
            gtv.Add(GemType.Diamond, 5);
            gtv.Add(GemType.Hematite, 1);
            gtv.Add(GemType.Quartz, 2);
            gtv.Add(GemType.Garnet, 3);
            gtv.Add(GemType.Saphire, 4);

            foreach(KeyValuePair<GemType, int> kv in gtv)
            {
                if(kv.Key == gt)
                {
                    typeMod = kv.Value;
                }
            }
            return typeMod;
        }
    }
}

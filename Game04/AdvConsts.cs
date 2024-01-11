using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game04
{
    public enum Rm
    {
        TrollRoom,
        Forest,
        Cave,
        Dungeon,
        OakTrunk,
        OakTrunk2,
        OakLimb,
        NOEXIT
    }

    public enum ObID
    {
        Leaflet,
        SignGoreStreet,
        SignOpiumTerrace,
        Bone,
        Coin,
        Knife,
        Lamp,
        Acorn,
        Bed,
        Key,
        Bin,
        Chest
    }

    public enum Dir
    {
        NORTH,
        SOUTH,
        EAST,
        WEST,
        UP,
        DOWN
    }

    public enum WeapType
    {
        Dagger,
        ShortSword,
        Knife,
        LongSword,
        Mace,
        Flail
    }
}

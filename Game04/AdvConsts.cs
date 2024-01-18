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
        DarkEntrance,
        DarkForest,
        Dungeon,
        HoleEntrance,
        OakTrunk,
        OakTrunk2,
        OakLimb,
        Passage,
        RopeBridge,
        RopeBridgeEnd,
        RootCellar,
        RopeLadder,
        SecretClearing,
        SleepingChamber,
        SmallTunnel,
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

    public enum WeapDmgType
    {
        Pierce,
        Slash,
        Blunt
    }

    public enum LPQuality
    {
        Dismal,
        Poor,
        Bent,
        Fair,
        Standard,
        Quality,
        Trick,
        Special,
        HighQuality,
        Grandmaster

    }
}

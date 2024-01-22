using Game04.gameclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Game04
{
    partial class Adventure
    {
        public RoomList InitMap(RoomList _map)
        {

            /*
             * Sleeping Chamber
             *  d 
            *   | Passage --                        Oak Trunk With Limb -- Limb -- Rope Bridge -- end of rope bridge
            *   |  |   Root Cellar                          d                                                 d
            *   |  |    u                                   ^                                                 ^
            *   ^  |    d                               Oak Trunk                                     Secret Clearing       
            *  small tunnel                                 d                                           
           *     |                                          ^                                           
           * Troll Hole -- Hole Entrance -- Dark Forest - Forest
           *    |
           *  Cave  --  DarkEntrance  ---  Dungeon  
           * */

            _map = new RoomList();
            /*                                                                                          N          S          W          E    up   down     */
            _map.Add(Rm.TrollRoom, new Room("Troll Hole", "a dank, dark hole that smells of troll. You see a cave to the south", Rm.SmallTunnel, Rm.Cave, Rm.NOEXIT, Rm.HoleEntrance, new ThingList()));
            _map.Add(Rm.Forest, new Room("Forest", "a light, airy forest shimmering with sunlight", Rm.NOEXIT, Rm.NOEXIT, Rm.DarkForest, Rm.NOEXIT, Rm.OakTrunk, Rm.NOEXIT, new ThingList()));
            _map.Add(Rm.Cave, new Room("Cave", "a vast cave with walls covered by luminous moss", Rm.TrollRoom, Rm.NOEXIT, Rm.NOEXIT, Rm.DarkEntrance, new ThingList()));
            _map.Add(Rm.Dungeon, new Room("Dungeon", "a gloomy dungeon. Rats scurry across its floor", Rm.NOEXIT, Rm.NOEXIT, Rm.DarkEntrance, Rm.NOEXIT, new ThingList()));
            _map.Add(Rm.OakTrunk, new Room("Oak Trunk", "you are halfway up to the first limb of the oak", Rm.NOEXIT, Rm.NOEXIT, Rm.NOEXIT, Rm.NOEXIT, Rm.OakTrunk2, Rm.Forest, new ThingList()));
            _map.Add(Rm.OakTrunk2, new Room("Oak Trunk With Limb", "you are up to the first limb of the oak", Rm.NOEXIT, Rm.NOEXIT, Rm.NOEXIT, Rm.OakLimb, Rm.NOEXIT, Rm.OakTrunk, new ThingList()));
            _map.Add(Rm.OakLimb, new Room("Oak Limb", "you are high off the ground", Rm.NOEXIT, Rm.NOEXIT, Rm.OakTrunk2, Rm.RopeBridge, new ThingList()));
            _map.Add(Rm.RopeBridge, new Room("Vine Rope Bridge", "a winding vine bridge through the tree tops", Rm.NOEXIT, Rm.NOEXIT, Rm.OakLimb, Rm.RopeBridgeEnd, Rm.NOEXIT,
                Rm.NOEXIT, new ThingList()));
            _map.Add(Rm.RopeBridgeEnd, new Room("End of the Rope Bridge", "you have reached the end of the rope bridge, there is a exit onto the tree here",
                Rm.NOEXIT, Rm.NOEXIT, Rm.RopeBridge, Rm.NOEXIT, Rm.NOEXIT, Rm.RopeLadder, new ThingList()));
            _map.Add(Rm.RopeLadder, new Room("Rope Ladder", "a rope ladder extends down through the canopy", Rm.NOEXIT, Rm.NOEXIT, Rm.NOEXIT, Rm.NOEXIT,
                Rm.RopeBridgeEnd, Rm.SecretClearing, new ThingList()));
            _map.Add(Rm.SecretClearing, new Room("Secret Clearing", "you see before you a magical clearing with the suns rays peeking through the canopy",
                Rm.NOEXIT, Rm.NOEXIT, Rm.NOEXIT, Rm.NOEXIT, Rm.RopeLadder, Rm.NOEXIT, new ThingList()));
            _map.Add(Rm.DarkForest, new Room("Dark Forest", "a deep dark forboding forest surrounds you", Rm.NOEXIT, Rm.NOEXIT, Rm.HoleEntrance, Rm.Forest, new ThingList()));
            _map.Add(Rm.HoleEntrance, new Room("Entrance to a Hole", "a hole is here in the side of an embankment", Rm.NOEXIT, Rm.NOEXIT, Rm.TrollRoom, Rm.DarkForest, new ThingList()));
            _map.Add(Rm.DarkEntrance, new Room("A Dark Entrance", "you can barely make out a dark opening to the east", Rm.NOEXIT, Rm.NOEXIT, Rm.Cave, Rm.Dungeon, new ThingList()));
            _map.Add(Rm.SmallTunnel, new Room("Small Tunnel", "you can barely crall through the tunnel.", Rm.Passage, Rm.TrollRoom, Rm.NOEXIT, Rm.NOEXIT, Rm.SleepingChamber, Rm.RootCellar,
                new ThingList()));
            _map.Add(Rm.RootCellar, new Room("Root Cellar", "a small dank root cellar, rubbish litters the ground", Rm.NOEXIT, Rm.NOEXIT, Rm.NOEXIT, Rm.NOEXIT, Rm.SmallTunnel, Rm.NOEXIT,
                new ThingList()));
            _map.Add(Rm.Passage, new Room("Passage", "the small tunnel opens into a standard size passage", Rm.NOEXIT, Rm.SmallTunnel, Rm.NOEXIT, Rm.NOEXIT, new ThingList()));
            _map.Add(Rm.SleepingChamber, new Room("Sleeping Chamber", "a dingy chamber, apparently used for sleeping and smells of troll", Rm.NOEXIT, Rm.NOEXIT, Rm.NOEXIT, Rm.NOEXIT,
                Rm.NOEXIT, Rm.SmallTunnel, new ThingList()));

            ThingList lbList = new ThingList();
            lbList.Add(new GemTreasure("hematite", "a tiny hematite", true, true, true, GemSz.Tiny, GemType.Hematite));

            _map[Rm.TrollRoom].AddThing(new Thing("rod", "A small wooden rod"));
            _map[Rm.OakLimb].AddThing(new Thing("acorn", "A small perfect acorn"));
            _map[Rm.Forest].AddThing(new Thing("tree", "It is a gigantic oak tree", false, false));
            _map[Rm.Cave].AddThing(new ContainerThing("sack", "a worn old sack", true, true, true, true, new ThingList()));
            _map[Rm.Cave].AddThing(new ContainerThing("box", "a wooden box", true, true, true, true, new ThingList()));
            _map[Rm.Dungeon].AddThing(new WeaponTreasure("dagger", "a tarnished dagger", true, true, true, true, WeapType.Dagger, 2, WeapDmgType.Pierce));
            _map[Rm.Forest].AddThing(new Treasure("coin", "a tarnished coin with a faded image on it", true, true, true));
            _map[Rm.Dungeon].AddThing(new MagicTreasure("orb", "a glowing orb that pulses", false, true, true, true));
            _map[Rm.RootCellar].AddThing(new Lockpick("lockpick", "the well worn lockpick is battered and wavy", true, true, true, LPQuality.Bent, 3, 6));
            _map[Rm.SleepingChamber].AddThing(new GemTreasure("quartz", "a very tiny piece of quartz", true, true, true, GemSz.Tiny, GemType.Quartz));
            _map[Rm.SleepingChamber].AddThing(new LockboxContThing("lockbox", "a beat up lockbox", true, true, true, false, lbList, true, true, 2, 1));

            
            return _map;
        }
    }
}

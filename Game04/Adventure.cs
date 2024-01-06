﻿using Game04.gameclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game04
{
    [Serializable]
    public partial class Adventure
    {
        private RoomList _map;
        private Actor _player;

        public Adventure()
        {
            ThingList trollroomlist = new ThingList();
            ThingList forestlist = new ThingList();

            trollroomlist.Add(new Thing("carrot", "It is a very crunchy carrot"));

            forestlist.Add(new Thing("sausage", "It is a plump port sausage"));
            forestlist.Add(new Thing("tree", "It is a gigantic oak tree", false, false));

            /*
            * 
            * Troll Room -- Forest
            *    |
            *  Cave  -----  Dungeon  
            * */

            _map = new RoomList();
            /*                                                                                          N          S          W          E          */
            _map.Add(Rm.TrollRoom, new Room("Troll Room", "a dank, dark room that smells of troll", Rm.NOEXIT, Rm.Cave, Rm.NOEXIT, Rm.Forest, trollroomlist));
            _map.Add(Rm.Forest, new Room("Forest", "a light, airy forest shimmering with sunlight", Rm.NOEXIT, Rm.NOEXIT, Rm.TrollRoom, Rm.NOEXIT, forestlist));
            _map.Add(Rm.Cave, new Room("Cave", "a vast cave with walls covered by luminous moss", Rm.TrollRoom, Rm.NOEXIT, Rm.NOEXIT, Rm.Dungeon, new ThingList()));
            _map.Add(Rm.Dungeon, new Room("Dungeon", "a gloomy dungeon. Rats scurry across its floor", Rm.NOEXIT, Rm.NOEXIT, Rm.Cave, Rm.NOEXIT, new ThingList()));

            _player = new Actor("You", "The Player", _map.RoomAt(Rm.TrollRoom), new ThingList());

        }

        //// --- Player
        public Actor Player
        {
            get => _player;
        } // Player

        private void MoveActorTo(Actor anActor, Room aRoom)
        {
            anActor.Location = aRoom;
        }

        private Rm MoveTo(Actor anActor, Dir direction)
        {
            Room r = anActor.Location;
            Rm exit;

            switch (direction)
            {
                case Dir.NORTH:
                    exit = r.N;
                    break;
                case Dir.SOUTH:
                    exit = r.S;
                    break;
                case Dir.EAST:
                    exit = r.E;
                    break;
                case Dir.WEST:
                    exit = r.W;
                    break;
                default:
                    exit = Rm.NOEXIT;
                    break;
            }
            if (exit != Rm.NOEXIT)
            {
                MoveActorTo(anActor, _map.RoomAt(exit));
            }
            return exit;
        }

        public string MovePlayerTo(Dir direction)
        {
            string s = "";

            if (MoveTo(_player, direction) == Rm.NOEXIT)
            {
                s = $"There is no exit in that direction\r\n You are still in {_player.Location.Name}\r\n Exits: {getExits(_player.Location)}";
            }
            else
            {
               s = $"You are now in the {_player.Location.Name}\r\n{_player.Location.Describe()}\r\nExits: {getExits(_player.Location)}";
            }
            return s;
        }

        public string getExits(Room room)
        {
            string s = "";
            string temp = "";

            if (room.N != Rm.NOEXIT)
            {
                s = "North";
            }
            if (s == "North")
            {
                temp = s + ", ";
                s = temp;
            }
            if (room.S != Rm.NOEXIT)
            {
                temp = "South";
                s = s + temp;
            }
            if (s == "South")
            {
                temp = s + ", ";
                s = temp;
            }
            if (room.E != Rm.NOEXIT)
            {
                temp = "East";
                s = s + temp;
            }
            if (s == "East")
            {
                temp = s + ", ";
                s = temp;
            }
            if (room.W != Rm.NOEXIT)
            {
                temp = "West";
                s = s + temp;
            }
            return s;

        }

        private void TransferOb(Thing t, ThingList fromlist, ThingList tolist)
        {
            fromlist.Remove(t);
            tolist.Add(t);
        }

        public string TakeOb(string obname)
        {
            Thing t = _player.Location.Things.ThisOb(obname);
            string s = "";
            if (obname == "")
            {
                obname = "nameless object"; // if no object specified
            }
            if (t == null)
            {
                s = "There is no " + obname + " here!";
            }
            else
            {
                if (t.CanTake)
                {
                    TransferOb(t, _player.Location.Things, _player.Things);
                    s = t.Name + " taken!";
                }
                else
                {
                    s = "You can't take the " + t.Name + "!";
                }
            }
            return s;
        }

        public string DropOb(string obname)
        {
            Thing t = _player.Things.ThisOb(obname);
            string s = "";
            if (t == null)
            {
                s = "You haven't got one!";
            }
            else
            {
                TransferOb(t, _player.Things, _player.Location.Things);
                s = t.Name + " dropped!";
            }
            return s;
        }

        public string LookAtOb(string obname)
        {
            Thing t;
            string s = "";
            if (obname == "")
            {
                s = "You'll have to say what you want to look at!";
            }
            else
            {
                t = _player.Location.Things.ThisOb(obname);
                if (t == null)
                {
                    t = _player.Things.ThisOb(obname);
                }
                if (t == null)
                {
                    s = "There is no " + obname + " here!";
                }
                else
                {
                    s = t.Description + ".";
                }
            }
            return s;
        }
    }
}


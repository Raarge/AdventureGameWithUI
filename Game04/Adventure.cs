using Game04.gameclasses;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Game04
{
    [Serializable]
    public partial class Adventure
    {
        private RoomList _map;
        private Actor _player;
        private SkillList _skillList;

        public Adventure()
        {
            InitVocab();
            _map = InitMap(_map);

            _skillList = InitSkills(_skillList);
            _player = new Actor("You", "The Player", _map.RoomAt(Rm.TrollRoom), new ThingList(), _skillList);
            
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
                case Dir.UP:
                    exit = r.Up;
                    break;
                case Dir.DOWN:
                    exit = r.Down;
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
                s = $"There is no exit in that direction\r\n You are still in {_player.Location.Name}\r\n ";
            }
            else
            {
                s = $"You are now in the {_player.Location.Name}\r\n{_player.Location.Describe()}\r\n";
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
                temp = s + " ";
                s = temp;
            }
            if (room.S != Rm.NOEXIT)
            {
                temp = "South";
                s = s + temp;
            }
            if (s == "South")
            {
                temp = s + " ";
                s = temp;
            }
            else if (s.EndsWith(" "))
            {

            }
            else 
            {
                temp = s + " ";
                s = temp;
            }
            if (room.W != Rm.NOEXIT)
            {
                temp = "West";
                s = s + temp;
            }
            if (s == "West")
            {
                temp = s + " ";
                s = temp;
            }
            else if (s.EndsWith(" "))
            {

            }
            else
            {
                temp = s + " ";
                s = temp;
            }
            if (room.E != Rm.NOEXIT)
            {
                temp = "East";
                s = s + temp;
            }
            if (s == "East")
            {
                temp = s + " ";
                s = temp;
            }
            else if (s.EndsWith(" "))
            {

            }
            else
            {
                temp = s + " ";
                s = temp;
            }
            if (room.Up != Rm.NOEXIT)
            {
                temp = "Up";
                s = s + temp;
            }
            if (s == "Up")
            {
                temp = s + " ";
                s = temp;
            }
            else if (s.EndsWith(" "))
            {

            }
            else
            {
                temp = s + " ";
                s = temp;
            }
            if (room.Down != Rm.NOEXIT)
            {
                temp = "Down";
                s = s + temp;
            }
            if (s == "Down")
            {
                temp = s + " ";
                s = temp;
            }
            return s;

        }

        private void TransferOb(Thing t, ThingList fromlist, ThingList tolist)
        {
            fromlist.Remove(t);
            tolist.Add(t);
        }

        private KeyValuePair<Thing, ThingList> ObInContainerHere(string obname)
        {
            ContainerThing ct = null;
            Thing t = null;
            ThingList tl = null;
            foreach (Thing ob in _player.Things)
            {
                if (ob is ContainerThing)
                {
                    ct = (ContainerThing)ob;
                    if (ct.IsOpen)
                    {
                        tl = ct.Things;
                        t = ct.Things.GetOb(obname);

                        CheckForLockboxEmpty(ct);
                    }
                }
            }
            return new KeyValuePair<Thing, ThingList>(t, tl);
        }

        private void CheckForLockboxEmpty(ContainerThing ct)
        {
            if (ct is LockboxContThing)
            {
                int numItems = 0;

                foreach (Thing thing in ct.Things)
                {
                    if (thing != null)
                    {
                        numItems++;
                    }
                }

                if (numItems == 0 || numItems == 1)
                {
                    ((LockboxContThing)ct).Empty();
                }
            }
        }

        private KeyValuePair<MagicTreasure, ThingList> MagObInContainerHere(string obname)
        {
            ContainerThing ct = null;
            MagicTreasure t = null;
            ThingList tl = null;
            foreach (Thing ob in _player.Things)
            {
                if (ob is ContainerThing)
                {
                    ct = (ContainerThing)ob;
                    if (ct.IsOpen)
                    {
                        tl = ct.Things;
                        t = ct.Things.MagGetOb(obname);
                    }
                }
            }
            return new KeyValuePair<MagicTreasure, ThingList>(t, tl);
        }

        private Thing ObHere(string obname)
        {
            // look for ob in current room and player's inventory
            // return ob if found, else return null
            KeyValuePair<Thing, ThingList> kv;
            Thing t = null;
            t = _player.Location.Things.GetOb(obname);
            if (t == null)
            {
                t = _player.Things.GetOb(obname);
            }
            if (t == null)
            {
                kv = ObInContainerHere(obname);
                t = kv.Key;
            }
            return t;
        }

        private MagicTreasure MagObHere(string obname)
        {
            // look for ob in current room and player's inventory
            // return ob if found, else return null
            KeyValuePair<MagicTreasure, ThingList> kv;
            MagicTreasure t = null;
            t = _player.Location.Things.MagGetOb(obname);
            if (t == null)
            {
                t = _player.Things.MagGetOb(obname);
            }
            if (t == null)
            {
                kv = MagObInContainerHere(obname);
                t = kv.Key;
            }
            return t;
        }

        private string TryToOpen(ContainerThing t)
        {
            string s = "";
            if (!t.Openable)
            {
                
                s = $"Can't open the {t.Name}";
            }
            else
            {                
                LockboxContThing test = t as LockboxContThing;
                if (test != null)
                {

                    if (test.IsLocked == true)
                    {
                        s = $"Cant open the {t.Name}, it is locked.";
                    }
                    else if (test.IsLocked == false && test.IsOpen == true)
                    {
                        s = $"Can't open the {t.Name} because it is already open.";
                    }
                    else if (test.IsLocked == false && test.IsOpen == false)
                    {
                        s = $"You slowly open the {t.Name} now that the lock is unlocked.";
                        test.Open();
                    }
                }
                else
                {
                    if (t.IsOpen)
                    {
                        s = $"The {t.Name} is already open.";
                    }
                    else
                    {
                        t.IsOpen = true;
                        s = $"You open the {t.Name}";
                    }
                }
             
                    
            }
            return s;

            }

        private string TryToClose(ContainerThing t)
        {
            string s = "";
            if (!t.Openable)
            {
                s = $"Can't close the {t.Name}";
            }
            else
            {
                if (t.IsOpen)
                {
                    t.IsOpen = false;
                    s = $"You close the {t.Name}";
                }
                else
                {
                    s = $"The {t.Name} is already closed.";
                }
            }
            return s;
        }

        public string TakeOb(string obname)
        {
            KeyValuePair<Thing, ThingList> kv;
            Thing t;
            ThingList tl;
            string s = "";
            t = _player.Location.Things.GetOb(obname);
            tl = _player.Location.Things;

            if (obname == "")
            {
                obname = "nameless object"; // if no object specified
            }
            if (t == null)
            {
                kv = ObInContainerHere(obname);
                t = kv.Key;
                tl = kv.Value;
            }
            if (t == null)
            {
                s = "There is no " + obname + " here!";
            }
            else 
            {
                if (t.CanTake)
                {
                    TransferOb(t, tl, _player.Things);
                    s = "\r\n" + t.Name + " taken!";
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

        public string LookInContainer(string obname)
        {
            ContainerThing t;
            ThingList tl;
            string s;
            string temp = null;
            if (obname == "")
            {
                s = "You'll have to say what you want to look into!";
            }
            else 
            {
                t = (ContainerThing)_player.Location.Things.ThisOb(obname);
                if (t == null)
                {
                    t = (ContainerThing)_player.Things.ThisOb(obname);
                }
                if (t == null)
                {
                    s = "There is no " + obname + " here!";
                }
                else 
                {
                    LockboxContThing lb = t as LockboxContThing;
                    if (lb == null)
                    {
                        if (t.IsOpen == true)
                        {
                            s = t.Description + " contains: \r\n";
                            foreach (Thing t2 in t.Things)
                            {
                                temp = temp + t2.Name + "\r\n";
                            }
                            s = s + temp;
                        }
                        else
                        {
                            s = $"You'll need to open the {t.Name} to look inside.";
                        }
                    }
                    else
                    {
                        if(lb.IsLocked == true)
                        {
                            s = $"You cannot see into a {t.Name} it is locked.";
                        }
                        else if (lb.IsOpen == false)
                        {
                            s = $"You cannot see into a {t.Name}, it is unlocked but closed. Try opening it.";
                        }
                        else
                        {
                            s = t.Description + " contains: \r\n";
                            foreach (Thing t2 in t.Things)
                            {
                                temp = temp + t2.Name + "\r\n";
                            }
                            s = s + temp;
                        }
                    }
                }
            }
            
            return s;
        }

        public string PutObInContainer(string obname, string containername)
        {
            string s = "";
            Thing t = _player.Things.GetOb(obname);
            Thing container = ObHere(containername);
            if (t == null)
            {
                s = $"You haven't got the {obname}!";
            }
            else if (container == null)
            {
                s = $"There is no {containername} here!";
            }
            else if (!(container is ContainerThing))
            {
                s = $"You can't put the {obname} into the {containername}!";
            }
            else if (!((ContainerThing)container).IsOpen)
            {
                s = $"You can't put the {obname} into a closed {containername}!";
            }
            else
            {
                TransferOb(t, _player.Things, ((ContainerThing)container).Things);
                s = $"You put the {obname} into the {containername}.";
                if (container is LockboxContThing)
                {
                    if (((LockboxContThing)container).IsEmpty == true)
                    {
                        ((LockboxContThing)container).NotEmpty();
                    }
                }
            }
            return s;
        }

        public string OpenOb(string obname)
        {
            Thing t;
            string s = "";
            if (obname == "")
            {
                s = "You'll have to say what you want to open!";
            }
            else
            {
                t = ObHere(obname);
                if (t == null)
                {
                    s = $"There is no {obname} here!";
                }
                else
                {
                    if (t is ContainerThing)
                    {
                        s = TryToOpen((ContainerThing)t);
                    }
                    else
                    {
                        s = $"Cannot open the {obname}";
                    }
                }
            }
            return s;
        }


        public string CloseOb(string obname)
        {
            Thing t;
            string s = "";
            if (obname == "")
            {
                s = "You'll have to say what you want to close!";
            }
            else
            {
                t = ObHere(obname);
                if (t == null)
                {
                    s = $"There is no {obname} here!";
                }
                else
                {
                    if (t is ContainerThing)
                    {
                        s = TryToClose((ContainerThing)t);
                    }
                    else
                    {
                        s = $"Cannot close the {obname}";
                    }
                }
            }
            return s;
        }

        public string PickOb(string obname)
        {
            Thing t;
            string s = "";
            t = ObHere(obname);
            bool lp_present = false;
            Lockpick lp = null;
            ThingList playerThings = _player.Things;
            if (t == null)
            {
                s = $"There is no {obname} here!";
            }
            else
            {
                LockboxContThing targetbox = t as LockboxContThing;
                if (targetbox == null)
                {
                    s = $"{t.Name} is not a lockbox!";
                }

                foreach (Thing thing in playerThings)
                {
                    if(thing.Name == "lockpick")
                    {
                        lp_present = true;
                        lp = (Lockpick)thing;
                    }
                    
                }

                if (lp_present == false)
                {
                    s = $"You have no lockpick, you cannot pick a box";
                }
                else if (lp_present == true && lp.WorksOnLocks == true)
                {
                    s = AttemptPick(lp, targetbox);
                }
                else
                {
                    s = $"Your {lp.Name} is broken!";
                }
            }
            return s;
        }

        public string PullOb(string obname)
        {
            Thing t;
            string s = "";
            t = ObHere(obname);
            if (t == null)
            {
                s = $"There is no {obname} here!";
            }
            else
            {
                s = PullSpecial(t);
                if (s == "")
                {
                    if (t.Movable)
                    {
                        s = $"The {obname} moves slightly when you pull it.";
                    }
                    else
                    {
                        s = $"You try to pull the {obname} but nothing happens.";
                    }
                }
            }
            return s;
        }


        public string PushOb(string obname)
        {
            Thing t;
            string s = "";
            t = ObHere(obname);
            if (t == null)
            {
                s = $"There is no {obname} here!";
            }
            else
            {
                if (t.Movable)
                {
                    s = $"The {obname} moves slightly when you push it.";
                }
                else
                {
                    s = $"You try to push the {obname} but nothing happens.";
                }
            }
            return s;
        }

        public string RubOb(string obname)
        {
            MagicTreasure t;
            string s = "";
            t = MagObHere(obname);
            if (t == null)
            {
                s = $"\r\nYou rub and prod at a {obname} to no avail.\r\n";
            }
            else
            { 
                if(t.IsMagical == true)
                {
                    switch (obname)
                    {
                        case "orb":
                            s = $"\r\nAs you rub an {obname}, it flares to life you feel it tugging at your soul.\r\n";
                            break;
                        default:
                            s = $"\r\nAs you rub an {obname} flares for a second but nothing happens.\r\n";
                            break;
                    }
                }
                else
                {
                    s = $"\r\nYou rub {obname} but nothing seems to happen.\r\n";
                }
                

            }
            return s;
        }


        public string Look()
        {
            return "You are in " + _player.Location.Describe();
        }

        public string AttemptPick(Lockpick lp, LockboxContThing lb)
        {
            string s = "";
            int lphp = lp.lphp;
            int lockDiff = lb.PickDiff * 6;
            int locklvl = lb.LockLvl * 2;
            Skill sk = null;
            SkillList sl = _player.SkillList;

            foreach(Skill skl in sl)
            {
                if(skl.Name == "Lockpicking")
                {
                    sk = skl;
                    break;
                }
            }

            

            int rndmRoll = RandomInt(1, 30) + lphp + Convert.ToInt32(Math.Round(sk.Level));
            int lockDifficulty = RandomInt(1, lockDiff) + (locklvl * 20);
            

            if (rndmRoll > lockDifficulty)
            {
                LockpickingTest(lockDifficulty);
                lb.Unlock();
                s = $"The {lb.Name} makes an audible click!";
            }
            else if ((lockDifficulty - rndmRoll) > 8)
            {
                LockpickingTest(lockDifficulty);
                lp.lphp -= 2;
                lp.CheckLPHealth(lp);

                if(lp.WorksOnLocks == false)
                {
                    s = $"Your {lp.Name} is broken!";
                }
                else
                {
                    s = $"You feel your {lp.Name} weaken!";
                }
                
            }
            else
            {
                LockpickingTest(lockDifficulty);
                s = $"You work at a {lb.Name} but make no progress on the lock";
            }

            return s;
        }

        public int RandomInt(int min, int max)
        {
            int rn = 0;
            Random rndm = new Random();
            rn = rndm.Next(min, max);

            return rn;
        }

        public string AttemptAppraisal(string item)
        {
            string s = "";
            bool flag = false;
            ThingList tl = _player.Things;

            foreach(Thing t in tl)
            {
                if(t.Name == item)
                {
                    flag = true;
                }
            }

            if (flag == true)
            {
                if (item != "lockpick")
                {
                    s = $"You cannot appraise an {item}.";
                }
                else
                {
                    // appraise & appraisetest
                }
            }
            else
            {
                s = $"You do not have a {item}.";
            }
            




            return s;
        }
    }
}


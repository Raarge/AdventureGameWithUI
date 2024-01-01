using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game04.gameclasses;

namespace Game04
{
    public partial class Game : Form
    {
        /*
         *  Troll Room -- Forest
         *       |
         *    Cave ------ Dungeon
         */

        Room room0;
        Room room1;
        Room room2;
        Room room3;

        private RoomList _map;

        private Actor _player;

        public Game()
        {
            InitializeComponent();
            InitGame();
            StartGame();
        }

        private void InitGame()
        {
            room0 = new Room("Troll Room", "a dank, dark room that smells of troll", Rm.NOEXIT, Rm.Cave, Rm.NOEXIT, Rm.Forest);
            room1 = new Room("Forest", "a light, airy forest shimmering with sunlight", Rm.NOEXIT, Rm.NOEXIT, Rm.TrollRoom, Rm.NOEXIT);
            room2 = new Room("Cave", "a vast cave with walls covered by luminous moss", Rm.TrollRoom, Rm.NOEXIT, Rm.NOEXIT, Rm.Dungeon);
            room3 = new Room("Dungeon", "a gloomy dungeon. Rats scurry across its floor", Rm.NOEXIT, Rm.NOEXIT, Rm.Cave, Rm.NOEXIT);

            _map = new RoomList();

            _map.Add(Rm.TrollRoom, room0);
            _map.Add(Rm.Forest, room1);
            _map.Add(Rm.Cave, room2);
            _map.Add(Rm.Dungeon, room3);

            _player = new Actor("You", "The Player", room0);            
        }

        private void StartGame()
        {
            roomnameTB.Text = _player.Location.Name;
            outputTB.Text = $"Welcome to the Great Adventure!\r\n";
            outputTB.AppendText($"You are in the {_player.Location.Name}.");
            outputTB.AppendText($"It is {_player.Location.Description}\r\n");
            outputTB.AppendText($"Exits: {getExits(_player.Location)}\r\n");
            outputTB.AppendText("Where do you want to go now?\r\n");
            outputTB.AppendText("Click a direction button: North, South, West or East.\r\n");
        }

        private void lookBtn_Click(object sender, EventArgs e)
        {
            outputTB.Text = $"You are in the {_player.Location.Name}.\r\n";
            outputTB.AppendText($"It is {_player.Location.Description}\r\n");
            outputTB.AppendText($"Exits: {getExits(_player.Location)}");
        }

        private void MovePlayer(Rm newpos)
        {
            if (newpos == Rm.NOEXIT)
            {
                outputTB.Text = "There is no exit in that direction\r\n";
            }
            else
            {
                _player.Location = _map.RoomAt(newpos);
                roomnameTB.Text = _player.Location.Name;
                outputTB.Text = $"You are now in the {_player.Location.Name}\r\n";
                outputTB.AppendText($"Exits: {getExits(_player.Location)}");
            }
        }

        private void northBtn_Click(object sender, EventArgs e)
        {
            MovePlayer(_player.Location.N);
        }

        private void westBtn_Click(object sender, EventArgs e)
        {
            MovePlayer(_player.Location.W);
        }

        private void eastBtn_Click(object sender, EventArgs e)
        {
            MovePlayer(_player.Location.E);
        }

        private void southBtn_Click(object sender, EventArgs e)
        {
            MovePlayer(_player.Location.S);
        }

        private string getExits(Room room)
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
    }
}

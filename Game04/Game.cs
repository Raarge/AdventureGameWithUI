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
        Adventure adv;

        public Game()
        {
            InitializeComponent();
            InitGame();
            StartGame();
        }

        private void InitGame()
        {
            adv = new Adventure();        
        }

        private void StartGame()
        {
            roomnameTB.Text = adv.Player.Location.Name;
            outputTB.Text = $"Welcome to the Great Adventure!\r\n";
            outputTB.AppendText($"You are in the {adv.Player.Location.Name}.");
            outputTB.AppendText($"It is {adv.Player.Location.Description}\r\n");
            outputTB.AppendText($"Exits: {getExits(adv.Player.Location)}\r\n");
            outputTB.AppendText("Where do you want to go now?\r\n");
            outputTB.AppendText("Click a direction button: North, South, West or East.\r\n");
        }

        private void lookBtn_Click(object sender, EventArgs e)
        {
            outputTB.Text = $"You are in the {adv.Player.Location.Name}.\r\n";
            outputTB.AppendText($"{adv.Player.Location.Describe()}\r\n");
            outputTB.AppendText($"Exits: {getExits(adv.Player.Location)}\r\n");
            
        }

        private void MovePlayer(Dir direction)
        {
            outputTB.Text = adv.MovePlayerTo(direction);
            roomnameTB.Text = adv.Player.Location.Name;

        }

        private void northBtn_Click(object sender, EventArgs e)
        {
            MovePlayer(Dir.NORTH);
        }

        private void westBtn_Click(object sender, EventArgs e)
        {
            MovePlayer(Dir.WEST);
        }

        private void eastBtn_Click(object sender, EventArgs e)
        {
            MovePlayer(Dir.EAST);
        }

        private void southBtn_Click(object sender, EventArgs e)
        {
            MovePlayer(Dir.SOUTH);
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

        
    }
}

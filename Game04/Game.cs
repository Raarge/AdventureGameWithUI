﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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

        }

        private void InitGame()
        {
            adv = new Adventure();
            StartGame();
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

        private void Wr(string s)
        {
            outputTB.AppendText(s);
        }

        private void WrLn(string s)
        {
            Wr(s + "\r\n");

        }

        private void ShowLocation()
        {
            Wr(adv.Player.Name);
            Wr(" are currently in this room: ");
            WrLn(adv.Player.Location.Describe());
        }

        private void ShowInventory()
        {
            WrLn("You have " + adv.Player.Things.Describe());
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

        private void takeBtn_Click(object sender, EventArgs e)
        {
            WrLn(adv.TakeOb(InputTB.Text));
        }

        private void dropBtn_Click(object sender, EventArgs e)
        {
            WrLn(adv.DropOb(InputTB.Text));
        }

        private void invBtn_Click(object sender, EventArgs e)
        {
            ShowInventory();
        }

        private void LookAtBtn_Click(object sender, EventArgs e)
        {
            WrLn(adv.LookAtOb(InputTB.Text));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream st;
            BinaryFormatter binfmt;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((st = openFileDialog1.OpenFile()) != null)
                {
                    binfmt = new BinaryFormatter();
                    adv = (Adventure)binfmt.Deserialize(st);
                    st.Close();
                }
            }
            outputTB.Clear();
            ShowLocation();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitGame();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream st;
            BinaryFormatter binfmt;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((st = saveFileDialog1.OpenFile()) != null)
                {
                    // Save to disk
                    binfmt = new BinaryFormatter();
                    binfmt.Serialize(st, adv);
                    st.Close();
                    WrLn("Saved");
                }
            }
        }
    }
}

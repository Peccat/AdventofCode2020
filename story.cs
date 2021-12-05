﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventOfCode2020
{
    public partial class story : Form
    {
        public story()
        {
            InitializeComponent();
        }

        private void day_1_Load(object sender, EventArgs e)
        {
            //kiírja a történetet
            lbl_story.Text = "After saving Christmas five years in a row, you've decided to take a vacation at a nice resort on a tropical island. Surely, Christmas will go on without you. The tropical island has its own currency and is entirely cash - only. The gold coins used there have a little picture of a starfish; the locals just call them stars. None of the currency exchanges seem to have heard of them, but somehow, you'll need to find fifty of these coins by the time you arrive so you can pay the deposit on your room. To save your vacation, you need to get all fifty stars by December 25th. Collect stars by solving puzzles.Two puzzles will be made available on each day in the Advent calendar; the second puzzle is unlocked when you complete the first. Each puzzle grants one star.Good luck!";
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            //bezárja az ablakot
            story settings = new story();
            this.Close();
            settings.Close();
        }
    }
}

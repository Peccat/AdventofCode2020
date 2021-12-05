using System;
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
    public partial class AoC_story : Form
    {
        public AoC_story()
        {
            InitializeComponent();
        }

        private void AoC_story_Load(object sender, EventArgs e)
        {
            lbl_story.Text = "Advent of Code is an Advent calendar of small programming puzzles for a variety of skill sets and skill levels that can be solved in any programming language you like. People use them as a speed contest, interview prep, company training, university coursework, practice problems, or to challenge each other. You don't need a computer science background to participate - just a little programming knowledge and some problem solving skills will get you pretty far. Nor do you need a fancy computer; every problem has a solution that completes in at most 15 seconds on ten-year-old hardware.";
            
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //bezárja az ablkot
            AoC_story settings = new AoC_story();
            this.Close();
            settings.Close();
            
        }
    }
}

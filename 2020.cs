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
    public partial class _2020 : Form
    {
        public _2020()
        {
            InitializeComponent();
        }
        int pbvalue = 0;
        int pbplus = 1; 
        private void btn_day1_Click(object sender, EventArgs e)
        {
            _2020_day1 popup = new _2020_day1();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            pbvalue += pbplus;
            pb.Value = pbvalue;
        }
        
        private void _2020_Load(object sender, EventArgs e)
        {
            lbl_2020story.Text = "After saving Christmas five years in a row, you've decided to take a vacation at a nice resort on a tropical island. Surely, Christmas will go on without you. The tropical island has its own currency and is entirely cash - only.The gold coins used there have a little picture of a starfish; the locals just call them stars. None of the currency exchanges seem to have heard of them, but somehow, you'll need to find fifty of these coins by the time you arrive so you can pay the deposit on your room. To save your vacation, you need to get all fifty stars by December 25th. Collect stars by solving puzzles.Two puzzles will be made available on each day in the Advent calendar; the second puzzle is unlocked when you complete the first. Each puzzle grants one star.Good luck!";
            pb.Maximum = 25 * pbplus;
        }

        private void btn_day2_Click(object sender, EventArgs e)
        {
            _2020_day2 popup = new _2020_day2();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            pbvalue += pbplus;
            pb.Value = pbvalue;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            _2020 setting = new _2020();
            this.Close();
            setting.Close();
        }

        private void btn_day3_Click(object sender, EventArgs e)
        {
            _2020_day3 popup = new _2020_day3();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            pbvalue += pbplus;
            pb.Value = pbvalue;
        }

        private void btn_day4_Click(object sender, EventArgs e)
        {
            _2020_day4 popup = new _2020_day4();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            pbvalue += pbplus;
            pb.Value = pbvalue;
        }

        private void btn_day5_Click(object sender, EventArgs e)
        {
            _2020_day5 popup = new _2020_day5();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            pbvalue += pbplus;
            pb.Value = pbvalue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _2020_day6 popup = new _2020_day6();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            pbvalue += pbplus;
            pb.Value = pbvalue;
        }

        private void btn_day7_Click(object sender, EventArgs e)
        {
            _2020_day7 popup = new _2020_day7();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            pbvalue += pbplus;
            pb.Value = pbvalue;
        }
        private void btn_day9_Click(object sender, EventArgs e)
        {
            _2020_day9 popup = new _2020_day9();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            pbvalue += pbplus;
            pb.Value = pbvalue;
        }

        private void btn_day10_Click_1(object sender, EventArgs e)
        {
            _2020_day10 popup = new _2020_day10();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            pbvalue += pbplus;
            pb.Value = pbvalue;
        }
        private void btn_day11_Click_1(object sender, EventArgs e)
        {
            _2020_day11 popup = new _2020_day11();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            pbvalue += pbplus;
            pb.Value = pbvalue;
        }

        private void btn_day8_Click(object sender, EventArgs e)
        {
            _2020_day8 popup = new _2020_day8();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            pbvalue += pbplus;
            pb.Value = pbvalue;
        }

        private void btn_day12_Click(object sender, EventArgs e)
        {
            _2020_day12 popup = new _2020_day12();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            pbvalue += pbplus;
            pb.Value = pbvalue;
        }

        private void btn_day13_Click(object sender, EventArgs e)
        {
            _2020_day13 popup = new _2020_day13();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            pbvalue += pbplus;
            pb.Value = pbvalue;
        }

        private void btn_day14_Click(object sender, EventArgs e)
        {
            _2020_day14 popup = new _2020_day14();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            pbvalue += pbplus;
            pb.Value = pbvalue;
        }

        private void btn_day15_Click(object sender, EventArgs e)
        {
            _2020_day15 popup = new _2020_day15();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            pbvalue += pbplus;
            pb.Value = pbvalue;
        }

        private void btn_day16_Click(object sender, EventArgs e)
        {
            _2020_day16 popup = new _2020_day16();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            pbvalue += pbplus;
            pb.Value = pbvalue;
        }

        private void btn_day17_Click(object sender, EventArgs e)
        {
            _2020_day17 popup = new _2020_day17();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            pbvalue += pbplus;
            pb.Value = pbvalue;
        }

        private void btn_day18_Click(object sender, EventArgs e)
        {
            _2020_day18 popup = new _2020_day18();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            pbvalue += pbplus;
            pb.Value = pbvalue;
        }

        private void btn_day19_Click(object sender, EventArgs e)
        {
            _2020_day19 popup = new _2020_day19();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            pbvalue += pbplus;
            pb.Value = pbvalue;
        }

        private void btn_day20_Click(object sender, EventArgs e)
        {
            _2020_day20 popup = new _2020_day20();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            pbvalue += pbplus;
            pb.Value = pbvalue;
        }

        private void btn_day21_Click(object sender, EventArgs e)
        {
            _2020_day21 popup = new _2020_day21();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            pbvalue += pbplus;
            pb.Value = pbvalue;
        }

        private void btn_day22_Click(object sender, EventArgs e)
        {
            _2020_day22 popup = new _2020_day22();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            pbvalue += pbplus;
            pb.Value = pbvalue;
        }

        private void btn_day23_Click(object sender, EventArgs e)
        {
            _2020_day23 popup = new _2020_day23();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
                pbvalue += pbplus;
            pb.Value = pbvalue;
        }

        private void btn_day24_Click(object sender, EventArgs e)
        {
            _2020_day24 popup = new _2020_day24();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            pbvalue += pbplus;
            pb.Value = pbvalue;
        }

        private void btn_day25_Click(object sender, EventArgs e)
        {
            _2020_day25 popup = new _2020_day25();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            pbvalue += pbplus;
            pb.Value = pbvalue;
        }
        
        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

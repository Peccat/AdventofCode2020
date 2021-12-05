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
    public partial class AdventofCode : Form
    {
        public AdventofCode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AoC_story popup = new AoC_story();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _2020 popup = new _2020();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            notavailable popup = new notavailable();
            DialogResult dialogresult = popup.ShowDialog();
           
        }

        
        
        private void btn_close_Click(object sender, EventArgs e)
        {
            AdventofCode settings = new AdventofCode();
            this.Close();
            settings.Close();
        }

        private void btn_2018_Click(object sender, EventArgs e)
        {
            notavailable popup = new notavailable();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void btn_2017_Click(object sender, EventArgs e)
        {
            notavailable popup = new notavailable();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void btn_2016_Click(object sender, EventArgs e)
        {
            notavailable popup = new notavailable();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void btn_2015_Click(object sender, EventArgs e)
        {
            notavailable popup = new notavailable();
            DialogResult dialogresult = popup.ShowDialog();
        }
    }
}

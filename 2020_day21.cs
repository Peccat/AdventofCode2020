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
    
    public partial class _2020_day21 : Form
    {

        public _2020_day21()
        {
            InitializeComponent();
        }

        

        private void _2020_day21_Load(object sender, EventArgs e)
        {
            btn_solv2.Visible = false;

        }

        private void btn_solv1_Click(object sender, EventArgs e)
        {
            btn_solv2.Visible = true;
        }

        private void btn_solv2_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            _2020_day21 setting = new _2020_day21();
            this.Close();
            setting.Close();
        }
    }
}

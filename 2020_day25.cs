using System;
using System.IO;
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
    public partial class _2020_day25 : Form
    {
        public _2020_day25()
        {
            InitializeComponent();
        }
        int cardspublickey = new int();
        int doorpublickey = new int();
        private void button1_Click(object sender, EventArgs e)
        {
            long cardloopsize = Untransform(7, cardspublickey);
            long doorloopsize = Untransform(7, doorpublickey);

            long encryptionkey = Transform(doorpublickey, cardloopsize);
            lbl_part1answer.Text = "The encryption key: " + encryptionkey;
            btn_solv2.Visible = true;
        }

        static long Untransform(long subject, long target)
        {
            long value = 1;
            int loop = 0;
            while(value != target)
            {
                value *= subject;
                value %= 20201227;
                loop++;
            }
            return loop;
        }
        static long Transform(long subject, long loopsize)
        {
            long value = 1;
            for (int i = 0; i < loopsize; i++)
            {
                value *= subject;
                value %= 20201227;
            }
            return value;
        }

        private void _2020_day25_Load(object sender, EventArgs e)
        {
            btn_solv2.Visible = false;
            StreamReader reader = new StreamReader("2020_day25.txt");
            cardspublickey = int.Parse(reader.ReadLine());
            doorpublickey = int.Parse(reader.ReadLine());
            lb_input.Items.Add("The cards key: " + cardspublickey);
            lb_input.Items.Add("The door key: " + doorpublickey);
        }

        private void btn_solv2_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            _2020_day25 setting = new _2020_day25();
            this.Close();
            setting.Close();
        }
    }
}

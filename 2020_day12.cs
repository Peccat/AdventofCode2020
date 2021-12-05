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
    public partial class _2020_day12 : Form
    {
        struct data
        {
            public char action;
            public int value;
        }
        struct pos
        {
            public int S, W, E, N;
        }
        data[] onedata = new data[1000];
        int way = 0;
        pos position = new pos();
        pos position2 = new pos();
        pos waypoints = new pos();
        StreamReader reader = new StreamReader("2020_day12.txt");
        string oneline = "", helper = "";
        int data_pcs = 0, helper_i = 0;
        public _2020_day12()
        {
            InitializeComponent();
        }

        private void _2020_day12_Load(object sender, EventArgs e)
        {
            btn_solv2.Visible = false;
            // the first waypoint
            waypoints.E = 10;
            waypoints.N = 1;
            while (!reader.EndOfStream)
            {
                oneline = reader.ReadLine();
                onedata[data_pcs].action = oneline[0];

                for (int i = 1; i < oneline.Length; i++)
                {
                    helper += oneline[i];
                }
                onedata[data_pcs].value = int.Parse(helper);
                helper = "";
                switch (onedata[data_pcs].action)
                {
                    case 'N':
                        position.N += onedata[data_pcs].value;
                        waypoints.S -= onedata[data_pcs].value;
                        if (waypoints.S < 0) { waypoints.N += Math.Abs(waypoints.S); waypoints.S = 0; }
                        break;
                    case 'S':
                        position.S += onedata[data_pcs].value;
                        waypoints.N -= onedata[data_pcs].value;
                        if (waypoints.N < 0) { waypoints.S += Math.Abs(waypoints.N); waypoints.N = 0; }
                        break;
                    case 'E':
                        position.E += onedata[data_pcs].value;
                        waypoints.W -= onedata[data_pcs].value;
                        if (waypoints.W < 0) { waypoints.E += Math.Abs(waypoints.W); waypoints.W = 0; }
                        break;
                    case 'W':
                        position.W += onedata[data_pcs].value;
                        waypoints.E -= onedata[data_pcs].value;
                        if (waypoints.E < 0) { waypoints.W += Math.Abs(waypoints.E); waypoints.E = 0; }
                        break;
                    case 'L':
                        if (way < onedata[data_pcs].value) { way = 360 - (onedata[data_pcs].value - way); } else { way -= onedata[data_pcs].value; }
                        if (onedata[data_pcs].value == 90) { helper_i = waypoints.E; waypoints.E = waypoints.S; waypoints.S = waypoints.W; waypoints.W = waypoints.N; waypoints.N = helper_i; }
                        else if (onedata[data_pcs].value == 180) { helper_i = waypoints.E; waypoints.E = waypoints.W; waypoints.W = helper_i; helper_i = waypoints.N; waypoints.N = waypoints.S; waypoints.S = helper_i; }
                        else if (onedata[data_pcs].value == 270) { helper_i = waypoints.E; waypoints.E = waypoints.N; waypoints.N = waypoints.W; waypoints.W = waypoints.S; waypoints.S = helper_i; }
                        break;
                    case 'R':
                        if ((way + onedata[data_pcs].value) > 270) { way += onedata[data_pcs].value; way %= 360; } else { way += onedata[data_pcs].value; }
                        if (onedata[data_pcs].value == 270) { helper_i = waypoints.E; waypoints.E = waypoints.S; waypoints.S = waypoints.W; waypoints.W = waypoints.N; waypoints.N = helper_i; }
                        else if (onedata[data_pcs].value == 180) { helper_i = waypoints.E; waypoints.E = waypoints.W; waypoints.W = helper_i; helper_i = waypoints.N; waypoints.N = waypoints.S; waypoints.S = helper_i; }
                        else if (onedata[data_pcs].value == 90) { helper_i = waypoints.E; waypoints.E = waypoints.N; waypoints.N = waypoints.W; waypoints.W = waypoints.S; waypoints.S = helper_i; }
                        break;
                    case 'F':
                        switch (way)
                        {
                            case 0://E
                                position.E += onedata[data_pcs].value;
                                break;
                            case 90://S
                                position.S += onedata[data_pcs].value;
                                break;
                            case 180://W
                                position.W += onedata[data_pcs].value;
                                break;
                            case 270://N
                                position.N += onedata[data_pcs].value;
                                break;
                        }
                        position2.E += onedata[data_pcs].value * waypoints.E; position2.W += onedata[data_pcs].value * waypoints.W; position2.S += onedata[data_pcs].value * waypoints.S; position2.N += onedata[data_pcs].value * waypoints.N;
                        break;
                }
                //test                
                lb_input.Items.Add(data_pcs+1 + " " + onedata[data_pcs].action + " " + onedata[data_pcs].value);
                //Console.WriteLine("E(0):"+ position.E + " S(90):" + position.S + " W(180):" + position.W + " N(270):" + position.N + " way:" + way);
                //Console.WriteLine("E:" + waypoints.E + "\tS:" + waypoints.S + "\tW:" + waypoints.W + "\tN:" + waypoints.N);
                //Console.WriteLine("E(0):" + position2.E + " S(90):" + position2.S + " W(180):" + position2.W + " N(270):" + position2.N);

                data_pcs++;

            }
            data_pcs--;
        }

        private void btn_solv_Click(object sender, EventArgs e)
        {
            btn_solv2.Visible = true;
            lbl_part1answer.Text = "The rout: " + (Math.Abs(position.N - position.S) + Math.Abs(position.W - position.E)) + "    The coordinates: " + Math.Abs(position.N - position.S) + ";" + Math.Abs(position.W - position.E);
        }

        private void btn_solv2_Click(object sender, EventArgs e)
        {
            lbl_part2answer.Text = "The rout: " + (Math.Abs(position2.N - position2.S) + Math.Abs(position2.W - position2.E)) + "    The coordinates: " + Math.Abs(position2.N - position2.S) + ";" + Math.Abs(position2.W - position2.E);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            _2020_day12 setting = new _2020_day12();
            this.Close();
            setting.Close();
        }
    }
}

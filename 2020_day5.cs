using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventOfCode2020
{
    public partial class _2020_day5 : Form
    {
        public _2020_day5()
        {
            InitializeComponent();
        }

        struct position
        {
            public int row, column, ID;
        }
        int db = -1;
        position[] oneseat = new position[927];
        int max = 0, min = 0;

        private void _2020_day5_Load(object sender, EventArgs e)
        {
            btn_solve2.Visible = false;
            StreamReader reader = new StreamReader("2020_day5.txt");
            
            while (!reader.EndOfStream)
            {
                db ++;
                string egysor = reader.ReadLine();
                lb_input.Items.Add(egysor);
                for(int i = 0; i < 7 ; i++)
                {
                    if (egysor[i] == 'B') //1
                    {
                        switch (i)
                        {
                            case 0:
                                oneseat[db].row+=64;
                                break;
                            case 1:
                                oneseat[db].row+=32;
                                break;
                            case 2:
                                oneseat[db].row+=16;
                                break;
                            case 3:
                                oneseat[db].row+=8;
                                break;
                            case 4:
                                oneseat[db].row+=4;
                                break;
                            case 5:
                                oneseat[db].row+=2;
                                break;
                            case 6: 
                                oneseat[db].row++;
                                break;
                        }
                    }
                    
                }
                
                for (int i = 7; i < 10; i++)
                {
                    if (egysor[i] == 'R')//1
                    {
                        switch (i)
                        {
                            case 7:
                                oneseat[db].column += 4;
                                break;
                            case 8:
                                oneseat[db].column += 2;
                                break;
                            case 9:
                                oneseat[db].column += 1;
                                break;
                        }
                    }
                }
                oneseat[db].ID = (oneseat[db].row * 8) + oneseat[db].column;
                
            }

        }

        private void btn_solve1_Click(object sender, EventArgs e)
        {
            
            for(int i = 1; i <= db; i++)
            {
                if (oneseat[i].ID > oneseat[max].ID)
                {
                    max = i;
                }
            }
            lbl_part1answer.Text = "The bigest seat ID: " + oneseat[max].ID;
            btn_solve2.Visible = true;
        }

        private void btn_solve2_Click(object sender, EventArgs e)
        {
            int myseat = 0;
            List<int> id = new List<int>();
            for (int i = 0; i <= db; i++)
            {
                if (oneseat[i].ID < oneseat[min].ID)
                {
                    min = i; 
                }
                id.Add(oneseat[i].ID);
            }
            
            for (int i = oneseat[min].ID + 1; i < oneseat[max].ID; i++)
            {
                if (!id.Contains(i))
                {
                    myseat = i;
                    lbl_part2answer.Text="My Seat: " + myseat;
                    break;
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            _2020_day5 setting = new _2020_day5();
            this.Close();
            setting.Close();
        }
    }
}

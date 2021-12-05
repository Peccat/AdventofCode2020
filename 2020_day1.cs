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
    public partial class _2020_day1 : Form
    {
        public _2020_day1()
        {
            InitializeComponent();
            
        }
        public int[] input_tmb = new int[200];
        private void _2020_day1_Load(object sender, EventArgs e)
        {
            //feladat kiírása
            lbl_task.Text = "Before you leave, the Elves in accounting just need you to fix your expense report (your puzzle input); apparently, something isn't quite adding up. Specifically, they need you to find the two entries that sum to 2020 and then multiply those two numbers together. For example, suppose your expense report contained the following: 1721; 979; 366; 299; 675; 1456. In this list, the two entries that sum to 2020 are 1721 and 299.Multiplying them together produces 1721 * 299 = 514579, so the correct answer is 514579. Of course, your expense report is much larger. Find the two entries that sum to 2020; what do you get if you multiply them together ? ";
            //input kiírása, mentése másik tömbbe
            
            int i = 0;
            StreamReader reader = new StreamReader("2020_day1.txt");
            while (!reader.EndOfStream)
            {
                input_tmb[i] = int.Parse(reader.ReadLine());
                lb_input.Items.Add(input_tmb[i]);
                i++;
            }
            btn_solv2.Visible = false;
        }

        private void btn_solv_Click(object sender, EventArgs e)
        {
            List<int> list_sum2020 = new List<int>();
            for (int i = 0; i < input_tmb.Length; i++)
            {
                for (int j = 0; j < input_tmb.Length; j++)
                {
                    if(input_tmb[i] + input_tmb[j] == 2020)
                    {
                        list_sum2020.Add(input_tmb[i]);
                        list_sum2020.Add(input_tmb[j]);
                    }
                }
            }

            for(int i = 0; i < (list_sum2020.Count / 2); i++)
            {
                lbl_answer.Text =  list_sum2020[i*2] + "*" + list_sum2020[i*2+1] + "=" + list_sum2020[i*2] * list_sum2020[i*2+1];
            }

            lbl_part2.Text = "The Elves in accounting are thankful for your help; one of them even offers you a starfish coin they had left over from a past vacation.They offer you a second one if you can find three numbers in your expense report that meet the same criteria. Using the above example again, the three entries that sum to 2020 are 979, 366, and 675.Multiplying them together produces the answer, 241861950. In your expense report, what is the product of the three entries that sum to 2020 ? ";
            btn_solv2.Visible = true;
        }

        private void btn_solv2_Click(object sender, EventArgs e)
        {
            List<int> list_sum2020 = new List<int>();
            for (int i = 0; i < input_tmb.Length; i++)
            {
                for (int j = 0; j < input_tmb.Length; j++)
                {
                    for(int k = 0; k < input_tmb.Length; k++)
                    {
                        if (input_tmb[i] + input_tmb[j] + input_tmb[k] == 2020)
                        {
                            list_sum2020.Add(input_tmb[i]);
                            list_sum2020.Add(input_tmb[j]);
                            list_sum2020.Add(input_tmb[k]);
                        }
                    }
                }
            }

            for (int i = 0; i < list_sum2020.Count / 3; i++)
            {
                lbl_part2_answer.Text = list_sum2020[i*3] + "*" + list_sum2020[i*3 + 1] + "*" + list_sum2020[i*3 + 2] + "=" + list_sum2020[i*3] * list_sum2020[i*3 + 1] * list_sum2020[i*3 + 2];
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            _2020_day1 setting = new _2020_day1();
            this.Close();
            setting.Close();
        }
    }
}

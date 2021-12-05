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
    public partial class _2020_day15 : Form
    {
        public _2020_day15()
        {
            InitializeComponent();
        }
        static string[] input = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "2020_day15.txt")).Split(',');
        List<long> inputs = (Array.ConvertAll(input, s => Int64.Parse(s))).ToList();
        private void _2020_day15_Load(object sender, EventArgs e)
        {
            btn_solv2.Visible = false;
            for (int i = 0; i < input.Length; i++)
            {
                lb_input.Items.Add(input[i]);
            }
        }

        private void btn_solv1_Click(object sender, EventArgs e)
        {
            btn_solv2.Visible = true;
            lbl_part1answer.Text =  MemoryGame(inputs, 2020).ToString();
        }

        private void btn_solv2_Click(object sender, EventArgs e)
        {
            lbl_part2answer.Text = MemoryGame(inputs, 30000000).ToString();
        }
        private static long MemoryGame(List<long> inputs, int numberSpoken)
        {
            Dictionary<long, List<long>> numberOfOccurence = new Dictionary<long, List<long>>();
            List<long> occurence = new List<long>();
            for (int i = 1; i <= numberSpoken; i++)
            {
                if (numberOfOccurence.Count < inputs.Count)
                {
                    numberOfOccurence.Add(inputs.ElementAt(i - 1), new List<long>() { i });
                    occurence.Add(inputs.ElementAt(i - 1));

                    continue;
                }

                long lastNumber = occurence.Last();
                if (numberOfOccurence.ContainsKey(lastNumber))
                {
                    if (numberOfOccurence[lastNumber].Count == 1)
                    {
                        if (numberOfOccurence.ContainsKey(0))
                        {
                            numberOfOccurence[0].Add(i);
                        }
                        else
                        {
                            numberOfOccurence.Add(0, new List<long>() { i });
                        }

                        occurence.Add(0);
                    }
                    else
                    {
                        var list = numberOfOccurence[lastNumber];
                        long lastOccurence = list.ElementAt(list.Count - 1);
                        long previuosOccurence = list.ElementAt(list.Count - 2);
                        long newNumber = lastOccurence - previuosOccurence;

                        if (numberOfOccurence.ContainsKey(newNumber))
                        {
                            numberOfOccurence[newNumber].Add(i);
                        }
                        else
                        {
                            numberOfOccurence.Add(newNumber, new List<long>() { i });
                        }

                        occurence.Add(newNumber);
                    }
                }
            }

            return occurence.Last();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            _2020_day15 setting = new _2020_day15();
            this.Close();
            setting.Close();
        }
    }
}

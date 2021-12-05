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
    public partial class _2020_day23 : Form
    {
        public _2020_day23()
        {
            InitializeComponent();
        }
        string input = "962713854";
		
		
        private void _2020_day23_Load(object sender, EventArgs e)
        {
            lb_input.Items.Add(input);
            _2020_day23 p = new _2020_day23();
            lbl_part1answer.Text = p.PartOne();
            lbl_part2answer.Text = p.parttwo().ToString();
		}

        public string PartOne()
        {
            return string.Join("", Solve(input, 9, 100).Take(8));
        }

        public long parttwo()
        {
            var labels = Solve(input, 1000000, 10000000).Take(2).ToArray();
            return labels[0] * labels[1];
        }
        private IEnumerable<long> Solve(string input, int maxLabel, int rotate)
        {
            var digits = input.Select(d => int.Parse(d.ToString())).ToArray();

            // A compact linked list representation. The cup's label can be used as the index into the array. 
            int[] next = Enumerable.Range(1, maxLabel + 1).ToArray();
            next[0] = -1; // not used

            for (var i = 0; i < digits.Length; i++)
            {
                next[digits[i]] = digits[(i + 1) % digits.Length];
            }

            if (maxLabel > input.Length)
            {
                next[maxLabel] = next[digits.Last()];
                next[digits.Last()] = input.Length + 1;
            }

            var current = digits.First();

            for (var i = 0; i < rotate; i++)
            {
                var removed1 = next[current];
                var removed2 = next[removed1];
                var removed3 = next[removed2];
                next[current] = next[removed3];

                // omg
                var destination = current;
                do destination = destination == 1 ? maxLabel : destination - 1;
                while (destination == removed1 || destination == removed2 || destination == removed3);

                next[removed3] = next[destination];
                next[destination] = removed1;
                current = next[current];
            }

            // return the labels starting from the first cup.
            var cup = next[1];
            while (true)
            {
                yield return cup;
                cup = next[cup];
            }
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
            _2020_day23 setting = new _2020_day23();
            this.Close();
            setting.Close();
        }
    }
}

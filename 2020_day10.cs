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
    public partial class _2020_day10 : Form
    {
        public _2020_day10()
        {
            InitializeComponent();
        }
		List<int> jolts = new List<int>();
		long part2solution = 0;
		List<int> joltDiff = new List<int>();
		private void _2020_day10_Load(object sender, EventArgs e)
        {
            btn_solv2.Visible = false;
			List<string> input = new List<string>();
			StreamReader reader = new StreamReader("2020_day10.txt");
			while (!reader.EndOfStream)
			{
				input.Add(reader.ReadLine());
			}
			foreach (var item in input)
			{
				if (int.TryParse(item, out int s))
				{
					jolts.Add(s);
				}
			}
			jolts.Sort();
			
			int joltage = 0;
			bool canIncrement = true;
			int[] permittedAdapt = new int[]
			{
				1, 2, 3
			};
			while (canIncrement)
			{
				int i;
				for (i = 0; i < permittedAdapt.Length; i++)
				{
					if (jolts.Contains(joltage + permittedAdapt[i]))
					{
						joltage += permittedAdapt[i];
						joltDiff.Add(permittedAdapt[i]);
						break;
					}
				}
				if (i == permittedAdapt.Length)
				{
					canIncrement = false;
				}

			}
			joltage += 3;
			joltDiff.Add(3);
			int targetJolt = joltage;
			Dictionary<int, long> cache = new Dictionary<int, long>();
			jolts.Add(targetJolt);
			long CountPaths(int jolt)
			{
				if (jolt == targetJolt) return 1;
				long res = 0;
				if (cache.ContainsKey(jolt)) return cache[jolt];
				for (int i = 0; i < permittedAdapt.Length; i++)
				{
					if (jolts.Contains(jolt + permittedAdapt[i]))
					{
						res += CountPaths(jolt + permittedAdapt[i]);
					}
				}
				cache[jolt] = res;
				return res;
			}
			part2solution = CountPaths(0);
		}

        private void btn_solv1_Click(object sender, EventArgs e)
        {
            btn_solv2.Visible = true;
			lbl_part1answer.Text = (joltDiff.Count(item => item == 1) * joltDiff.Count(item => item == 3)).ToString() ;
        }

        private void btn_solv2_Click(object sender, EventArgs e)
        {
            lbl_part2answer.Text = part2solution.ToString();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
			_2020_day10 setting = new _2020_day10();
			this.Close();
			setting.Close();
        }
    }
}

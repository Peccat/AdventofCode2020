using System;
using System.IO;
using System.Text.RegularExpressions;
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
    public partial class _2020_day19 : Form
    {
        public _2020_day19()
        {
            InitializeComponent();
        }
		Dictionary<int, string> rules = new Dictionary<int, string>();
		List<string> msg = new List<string>();
		string rule = "";
		int valid = 0;
		int valid2 = 0;
		private void _2020_day19_Load(object sender, EventArgs e)
        {
            btn_solv2.Visible = false;
			List<string> input = new List<string>();
			StreamReader reader = new StreamReader("2020_day19.txt");
			while (!reader.EndOfStream)
			{
				input.Add(reader.ReadLine());
			}
			foreach (var item in input)
			{
				if (item != "" && item.Contains(":"))
				{
					rules[int.Parse(item.Split(':')[0])] = item.Split(':')[1].Substring(1);
				}
				else if (item != "")
				{
					msg.Add(item);
				}
			}

			rule = rules[0];
			Regex regex = new Regex(@"\d+", RegexOptions.Compiled);
			while (true)
			{
				Match match = regex.Match(rule);
				if (match.Success)
				{
					string thing = rules[int.Parse(match.Value)];
					if (thing.Contains("\""))
					{
						thing = thing.Substring(1, thing.Length - 2);
					}
					else
					{
						thing = "(" + thing + ")";
					}
					rule = regex.Replace(rule, thing, 1);
				}
				else
				{
					break;
				}
				//Console.WriteLine(rule);
			}
			rule = rule.Replace(" ", "");
			//Console.WriteLine(rule);
			foreach (var item in msg)
			{
				if (Regex.IsMatch(item, "^" + rule + "$")) valid++;
			}


			rules[8] = "42 | 42 (42 | 42 (42 | 42 (42 | 42 (42 | 42 (42 | 42 (42 | 42 (42 | 42 (42 | 42 (42 | 42 (42))))))))))";
			rules[11] = "42 31 | 42 (42 31 | 42 (42 31 | 42 (42 31 | 42 (42 31 | 42 (42 31 | 42 (42 31 | 42 (42 31 | 42 (42 31 | 42 (42 31 | 42 (42 31 | 42 31) 31) 31) 31) 31) 31) 31) 31) 31) 31) 31";

			rule = rules[0];
			while (true)
			{
				Match match = regex.Match(rule);
				if (match.Success)
				{
					string thing = rules[int.Parse(match.Value)];

					if (thing.Contains("\""))
					{
						thing = thing.Substring(1, thing.Length - 2);
					}
					else
					{
						thing = "(" + thing + ")";
					}
					rule = regex.Replace(rule, thing, 1);
				}
				else
				{
					break;
				}
				//Console.WriteLine(rule);
			}
			rule = rule.Replace(" ", "");
			foreach (var item in msg)
			{
				if (Regex.IsMatch(item, "^" + rule + "$")) valid2++;
			}
		}

		private void btn_solv1_Click(object sender, EventArgs e)
        {
            btn_solv2.Visible = true;           
            lbl_part1answer.Text = valid.ToString();
        }

        private void btn_solv2_Click(object sender, EventArgs e)
        {
            lbl_part2answer.Text = valid2.ToString();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            _2020_day19 setting = new _2020_day19();
            this.Close();
            setting.Close();
        }
    }
}

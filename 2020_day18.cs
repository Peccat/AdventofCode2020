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
    public partial class _2020_day18 : Form
    {
        public _2020_day18()
        {
            InitializeComponent();
        }
        private static long EvalatePartOne(string line, bool isPartTwo)
        {
            while (line.Contains("("))
            {
                int level = 0;
                int rightParantesesIndex = 0;
                int leftParantesesIndex = 0;
                bool isLeftSet = false;
                for (int i = line.IndexOf('('); i < line.Length; i++)
                {
                    char currentChar = line[i];
                    if (currentChar == '(')
                    {
                        if (!isLeftSet)
                        {
                            leftParantesesIndex = i;
                            isLeftSet = true;
                        }

                        level++;
                    }
                    if (currentChar == ')')
                    {
                        level--;
                    }
                    if (level == 0)
                    {
                        rightParantesesIndex = i;
                        break;
                    }
                }

                int phaseStartIndex = leftParantesesIndex + 1;
                int phaseLenght = rightParantesesIndex - leftParantesesIndex - 1;
                long phaseResult = EvalatePartOne(line.Substring(phaseStartIndex, phaseLenght), isPartTwo);
                line = line.Substring(0, leftParantesesIndex) + phaseResult + line.Substring(rightParantesesIndex + 1);
            }

            if (isPartTwo)
            {
                string regex = @"(\d+) \+ (\d+)";
                Regex rgx = new Regex(regex);
                while (Regex.IsMatch(line, regex))
                {
                    Match m = Regex.Match(line, regex);
                    long t1 = long.Parse(m.Groups[1].Value);
                    long t2 = long.Parse(m.Groups[2].Value);
                    line = rgx.Replace(line, $"{t1 + t2}", 1);
                }
            }

            long counter = 0;
            bool isFirst = true;
            string[] operators = line.Trim().Split(' ');
            for (int i = 0; i < operators.Length; i++)
            {
                string current = operators[i];
                if (current == "+")
                {
                    counter += long.Parse(operators[i + 1]);
                }
                else if (current == "*")
                {
                    counter *= long.Parse(operators[i + 1]);
                }
                else
                {
                    if (isFirst)
                    {
                        counter = long.Parse(current);
                        isFirst = false;
                    }
                }
            }

            return counter;
        }
        string[] input = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "2020_day18.txt"));

        long resultPartOne = 0;
        long resultPartTwo = 0;
        private void _2020_day18_Load(object sender, EventArgs e)
        {
            btn_solv2.Visible = false;
            foreach (string line in input)
            {
                resultPartOne += EvalatePartOne(line, false);
                resultPartTwo += EvalatePartOne(line, true);
            }
        }

        private void btn_solv1_Click(object sender, EventArgs e)
        {
            btn_solv2.Visible = true;
            lbl_part1answer.Text = "Part one solution: " + resultPartOne;
        }

        private void btn_solv2_Click(object sender, EventArgs e)
        {
            lbl_part2answer.Text = "Part two solution:" + resultPartTwo;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            _2020_day18 setting = new _2020_day18();
            this.Close();
            setting.Close();
        }
    }
}

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
using System.Text.RegularExpressions;

namespace AdventOfCode2020
{
    public partial class _2020_day14 : Form
    {
        public _2020_day14()
        {
            InitializeComponent();
        }
        string[] input = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "2020_day14.txt"));
        private void _2020_day14_Load(object sender, EventArgs e)
        {
            btn_solv2.Visible = false;
            for (int i = 0; i < input.Length; i++)
            {
                lb_input.Items.Add(input[i]);
            }
            lbl_part1.Text = "As your ferry approaches the sea port, the captain asks for your help again. The computer system that runs this port isn't compatible with the docking program on the ferry, so the docking parameters aren't being correctly initialized in the docking program's memory. After a brief inspection, you discover that the sea port's computer system uses a strange bitmask system in its initialization program. Although you don't have the correct decoder chip handy, you can emulate it in software! The initialization program(your puzzle input) can either update the bitmask or write a value to memory.Values and memory addresses are both 36 - bit unsigned integers. For example, ignoring bitmasks for a moment, a line like mem[8] = 11 would write the value 11 to memory address 8. The bitmask is always given as a string of 36 bits, written with the most significant bit(representing 2 ^ 35) on the left and the least significant bit(2 ^ 0, that is, the 1s bit) on the right.The current bitmask is applied to values immediately before they are written to memory: a 0 or 1 overwrites the corresponding bit in the value, while an X leaves the bit in the value unchanged.";
        }

        private void btn_solv1_Click(object sender, EventArgs e)
        {
            btn_solv2.Visible = true;
            lbl_part1answer.Text= $"Part one solution:  {SolvePartOne(input)}";
            lbl_part2.Text = "For some reason, the sea port's computer system still can't communicate with your ferry's docking program. It must be using version 2 of the decoder chip! A version 2 decoder chip doesn't modify the values being written at all. Instead, it acts as a memory address decoder. Immediately before a value is written to memory, each bit in the bitmask modifies the corresponding bit of the destination memory address in the following way: If the bitmask bit is 0, the corresponding memory address bit is unchanged. If the bitmask bit is 1, the corresponding memory address bit is overwritten with 1. If the bitmask bit is X, the corresponding memory address bit is floating. A floating bit is not connected to anything and instead fluctuates unpredictably.In practice, this means the floating bits will take on all possible values, potentially causing many memory addresses to be written all at once!";
        }
        private static long SolvePartOne(string[] inputs)
        {
            Dictionary<long, long> resultSet = new Dictionary<long, long>();
            string regex = @"mem\[(?<adress>\d+)\] = (?<value>\d+)";
            string mask = string.Empty;
            foreach (string line in inputs)
            {
                if (line.Contains("mask"))
                {
                    mask = line.Split('=')[1].Trim();
                    continue;
                }
                else if (line.Contains("mem"))
                {
                    Match match = Regex.Match(line, regex);
                    long address = Int64.Parse(match.Groups["adress"].Value);
                    long value = Int64.Parse(match.Groups["value"].Value);

                    string s = Convert.ToString(value, 2);

                    long[] bits = s.PadLeft(36, '0')
                                 .Select(c => Int64.Parse(c.ToString()))
                                 .ToArray();

                    for (int i = 0; i < mask.Length; i++)
                    {
                        if (mask.ElementAt(i) != 'X')
                        {
                            bits[i] = Int32.Parse(mask[i].ToString());
                        }
                    }

                    long calculatedValue = Convert.ToInt64(String.Join("", bits), 2);
                    if (resultSet.ContainsKey(address))
                    {
                        resultSet[address] = calculatedValue;
                    }
                    else
                    {
                        resultSet.Add(address, calculatedValue);
                    }
                }
            }

            return resultSet.Select(x => x.Value).Aggregate((long)0, (x, y) => x + y);
        }

        private static long SolvePartTwo(string[] inputs)
        {
            Dictionary<long, long> resultSet = new Dictionary<long, long>();
            string regex = @"mem\[(?<adress>\d+)\] = (?<value>\d+)";
            string mask = string.Empty;
            foreach (string line in inputs)
            {
                if (line.Contains("mask"))
                {
                    mask = line.Split('=')[1].Trim();
                    continue;
                }
                else if (line.Contains("mem"))
                {
                    Match match = Regex.Match(line, regex);
                    long address = Int64.Parse(match.Groups["adress"].Value);
                    long value = Int64.Parse(match.Groups["value"].Value);

                    string stringInBits = Convert.ToString(address, 2);
                    char[] bits = stringInBits.PadLeft(36, '0').ToArray();
                    for (int i = 0; i < mask.Length; i++)
                    {
                        if (mask.ElementAt(i) != '0')
                        {
                            bits[i] = mask[i];
                        }
                    }

                    List<string> addresses = GenerateAdresses(String.Join("", bits));
                    foreach (var sss in addresses)
                    {
                        long newAddress = Convert.ToInt64(String.Join("", sss), 2);
                        if (resultSet.ContainsKey(newAddress))
                        {
                            resultSet[newAddress] = value;
                        }
                        else
                        {
                            resultSet.Add(newAddress, value);
                        }
                    }
                }
            }

            return resultSet.Select(x => x.Value).Aggregate((long)0, (x, y) => x + y);
        }

        private static List<string> GenerateAdresses(string searchString)
        {
            List<string> results = new List<string>();
            if (!searchString.Contains('X'))
            {
                results.Add(searchString);
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    string tempString = searchString;
                    results.AddRange(GenerateAdresses(ReplaceFirst(tempString, "X", i.ToString())));
                }
            }

            return results;
        }

        static string ReplaceFirst(string text, string search, string replace)
        {
            int pos = text.IndexOf(search);
            if (pos < 0)
            {
                return text;
            }

            return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
        }
        private void btn_solv2_Click(object sender, EventArgs e)
        {
            lbl_part2answer.Text= $"Part two solution:  {SolvePartTwo(input)}";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            _2020_day14 setting = new _2020_day14();
            this.Close();
            setting.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Numerics;

namespace AdventOfCode2020
{
    public partial class _2020_day16 : Form
    {
        public _2020_day16()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)//back
        {
            _2020_day16 setting = new _2020_day16();
            this.Close();
            setting.Close();
        }
        int count = 0;
        string[] input = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "2020_day16.txt"));
        
        State readState = State.RULES;
        Dictionary<string, List<int>> rules = new Dictionary<string, List<int>>();
        List<int> myTicket = new List<int>();
        List<List<int>> validNearbyTicketsInts = new List<List<int>>();
        private void _2020_day16_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < input.Length; i++)
            {
                lb_input.Items.Add(input[i]);
            }
            foreach (string line in input)
            {
                if (line == String.Empty)
                {
                    int newState = (int)readState + 1;
                    readState = (State)newState;
                    continue;
                }

                if (readState == State.RULES)
                {
                    string regex = @"(.+?): (?<v1>\d+)-(?<v2>\d+) or (?<v3>\d+)-(?<v4>\d+)";
                    Match match = Regex.Match(line, regex);
                    string ruleName = match.Groups[1].Value;
                    int v1 = Int32.Parse(match.Groups["v1"].Value);
                    int v2 = Int32.Parse(match.Groups["v2"].Value);
                    List<int> range1 = Enumerable.Range(v1, v2 - v1 + 1).ToList();
                    int v3 = Int32.Parse(match.Groups["v3"].Value);
                    int v4 = Int32.Parse(match.Groups["v4"].Value);
                    List<int> range2 = Enumerable.Range(v3, v4 - v3 + 1).ToList();
                    List<int> fullRange = new List<int>();
                    fullRange.AddRange(range1);
                    fullRange.AddRange(range2);
                    rules.Add(ruleName, fullRange);
                }
                else if (readState == State.MY_TICKET)
                {
                    if (line.StartsWith("you"))
                    {
                        continue;
                    }

                    myTicket = (Array.ConvertAll(line.Split(','), s => Int32.Parse(s))).ToList();
                }
                else if (readState == State.OTHER_TICKETS)
                {
                    if (line.StartsWith("nearby"))
                    {
                        continue;
                    }

                    List<int> nearbyTickets = new List<int>(Array.ConvertAll(line.Split(','), s => Int32.Parse(s)));
                    if (GetInvalidField(nearbyTickets, rules))
                    {
                        validNearbyTicketsInts.Add(nearbyTickets);
                    }
                    else
                    {
                        count += GetInvalidFieldValue(nearbyTickets, rules);
                    }
                }
            }
        }
        private static long SolvePartTwo(Dictionary<string, List<int>> rules, List<int> myTicket, List<List<int>> validNearbyTicketsInts)
        {
            Dictionary<string, List<int>> indexes = new Dictionary<string, List<int>>();
            List<int> founded = new List<int>();
            foreach (KeyValuePair<string, List<int>> t in rules)
            {
                founded = new List<int>();
                for (int i = 0; i < myTicket.Count; i++)
                {
                    List<int> allValidTickets = validNearbyTicketsInts.Select(x => x.ElementAt(i)).ToList();
                    allValidTickets.Add(myTicket.ElementAt(i));
                    if (allValidTickets.All(x => t.Value.Any(c => c == x)))
                    {
                        founded.Add(i);
                    }
                }

                indexes.Add(t.Key, founded);
            }

            Dictionary<string, int> final = new Dictionary<string, int>();
            var ordered = indexes.OrderBy(x => x.Value.Count).ToDictionary(x => x.Key, x => x.Value);
            List<int> toRemove = new List<int>();
            foreach (var t in ordered)
            {
                if (t.Value.Count == 1)
                {
                    toRemove.AddRange(t.Value);
                    final.Add(t.Key, t.Value.First());
                    continue;
                }

                List<int> s = t.Value.Except(toRemove).ToList();
                toRemove.Add(s.First());
                final.Add(t.Key, s.First());
            }

            long solution = 1;
            foreach (var t in final.Where(x => x.Key.Contains("departure")))
            {
                solution *= myTicket.ElementAt(t.Value);
            }

            return solution;
        }

        private static bool GetInvalidField(List<int> nearbyTickets, Dictionary<string, List<int>> rules)
        {
            foreach (int field in nearbyTickets)
            {
                if (!rules.Values.Any(x => x.Any(c => c == field)))
                {
                    return false;
                }
            }

            return true;
        }

        private static int GetInvalidFieldValue(List<int> nearbyTickets, Dictionary<string, List<int>> rules)
        {
            int invalidField = 0;
            foreach (int field in nearbyTickets)
            {
                if (!rules.Values.Any(x => x.Any(c => c == field)))
                {
                    return field;
                }
            }

            return invalidField;
        }

        enum State
        {
            RULES = 0,
            MY_TICKET = 1,
            OTHER_TICKETS = 2
        }

        private void btn_solv1_Click(object sender, EventArgs e)
        {
            lbl_part1answer.Text = "Part one solution: " + count;
        }

        private void btn_solv2_Click(object sender, EventArgs e)
        {
            lbl_part2answer.Text = "Part two solution: " + SolvePartTwo(rules, myTicket, validNearbyTicketsInts);
        }
    }
}

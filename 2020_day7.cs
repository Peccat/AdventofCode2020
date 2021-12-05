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

//---Day 7: Handy Haversacks ---
//You land at the regional airport in time for your next flight. In fact, it looks like you'll even have time to grab some food: all flights are currently delayed due to issues in luggage processing.

//Due to recent aviation regulations, many rules (your puzzle input) are being enforced about bags and their contents; bags must be color-coded and must contain specific quantities of other color-coded bags. Apparently, nobody responsible for these regulations considered how long they would take to enforce!

//For example, consider the following rules:

//light red bags contain 1 bright white bag, 2 muted yellow bags.
//dark orange bags contain 3 bright white bags, 4 muted yellow bags.
//bright white bags contain 1 shiny gold bag.
//muted yellow bags contain 2 shiny gold bags, 9 faded blue bags.
//shiny gold bags contain 1 dark olive bag, 2 vibrant plum bags.
//dark olive bags contain 3 faded blue bags, 4 dotted black bags.
//vibrant plum bags contain 5 faded blue bags, 6 dotted black bags.
//faded blue bags contain no other bags.
//dotted black bags contain no other bags.
//These rules specify the required contents for 9 bag types. In this example, every faded blue bag is empty, every vibrant plum bag contains 11 bags (5 faded blue and 6 dotted black), and so on.

//You have a shiny gold bag. If you wanted to carry it in at least one other bag, how many different bag colors would be valid for the outermost bag? (In other words: how many colors can, eventually, contain at least one shiny gold bag?)

//In the above rules, the following options would be available to you:

//A bright white bag, which can hold your shiny gold bag directly.
//A muted yellow bag, which can hold your shiny gold bag directly, plus some other bags.
//A dark orange bag, which can hold bright white and muted yellow bags, either of which could then hold your shiny gold bag.
//A light red bag, which can hold bright white and muted yellow bags, either of which could then hold your shiny gold bag.
//So, in this example, the number of bag colors that can eventually contain at least one shiny gold bag is 4.

//How many bag colors can eventually contain at least one shiny gold bag? (The list of rules is quite long; make sure you get all of it.)

namespace AdventOfCode2020
{
    public partial class _2020_day7 : Form
    {
        public _2020_day7()
        {
            InitializeComponent();
        }
        static Dictionary<string, Dictionary<string, int>> bags = new Dictionary<string, Dictionary<string, int>>();
        private void _2020_day7_Load(object sender, EventArgs e)
        {
            btn_solv2.Visible = false;
            StreamReader reader = new StreamReader("2020_day7.txt");
            foreach (var line in File.ReadLines("2020_day7.txt"))
            {
                lb_input.Items.Add(line);
                var matches = Regex.Match(line, @"(\w+ \w+) bags contain (.+)");
                var color = matches.Groups[1].Value;
                var contents = new Dictionary<string, int>();
                foreach (var content in matches.Groups[2].Value.Split(','))
                {
                    if (content.StartsWith("no")) continue;
                    var contentmatch = Regex.Match(content, @"(\d+) (\w+ \w+)");
                    contents.Add(contentmatch.Groups[2].Value, int.Parse(contentmatch.Groups[1].Value));
                }
                bags.Add(color, contents);
            }

        }
        public static bool CanContainGold(string color)
        {
            var bag = bags[color];
            if (bag.Any(d => d.Key == "shiny gold")) return true;
            if (bag.Any(d => d.Key.StartsWith("no"))) return false;
            foreach (var content in bag)
            {
                if (CanContainGold(content.Key)) return true;
            }
            return false;
        }

        public static long BagCount(string color)
        {
            var bag = bags[color];
            long runningCount = 0;
            if (bag.Any(d => d.Key.StartsWith("no"))) return runningCount;
            foreach (var content in bag)
            {
                runningCount += content.Value;
                for (int i = 0; i < content.Value; i++)
                    runningCount += BagCount(content.Key);
            }
            return runningCount;
        }
        private void btn_solv1_Click(object sender, EventArgs e)
        {
            btn_solv2.Visible = true;
            var count = bags.Count(d => CanContainGold(d.Key));
            lbl_part1answer.Text = count.ToString();
        }

        private void btn_solv2_Click(object sender, EventArgs e)
        {
            lbl_part2answer.Text = BagCount("shiny gold").ToString();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            _2020_day7 setting = new _2020_day7();
            this.Close();
            setting.Close();
        }
    }
}

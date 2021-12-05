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
    public partial class _2020_day4 : Form
    {
        public _2020_day4()
        {
            InitializeComponent();

        }

        static List<string> eyeColors = new List<string> { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };
        static Dictionary<string, string> passportData = new Dictionary<string, string>();

        static bool CheckPassportValidity1()
        {
            if (passportData.Count < 7) return false;
            if (passportData.Count == 7 && passportData.ContainsKey("cid")) return false;
            return true;
        }
        static bool CheckPassportValidity2()
        {
            if (passportData.Count < 7) return false;
            if (passportData.Count == 7 && passportData.ContainsKey("cid")) return false;

            if (int.Parse(passportData["byr"]) < 1920 || int.Parse(passportData["byr"]) > 2002) return false;
            if (int.Parse(passportData["iyr"]) < 2010 || int.Parse(passportData["iyr"]) > 2020) return false;
            if (int.Parse(passportData["eyr"]) < 2020 || int.Parse(passportData["eyr"]) > 2030) return false;

            var hgt = int.Parse(passportData["hgt"].Replace("in", "").Replace("cm", ""));
            if (passportData["hgt"].Contains("cm"))
            {
                if (hgt < 150 || hgt > 193) return false;
            }
            else
            {
                if (hgt < 59 || hgt > 76) return false;
            }

            if (!Regex.Match(passportData["hcl"], "^#(?:[0-9a-f]{6})$").Success) return false;

            if (!eyeColors.Contains(passportData["ecl"])) return false;

            if (passportData["pid"].Length != 9 || !passportData["pid"].All(Char.IsDigit)) return false;

            return true;
        }
        private void btn_solv1_Click(object sender, EventArgs e)
        {
            var validPassportCount = 0;

            using (var streamReader = new StreamReader("2020_day4.txt"))
            {
                while (true)
                {
                    var line = streamReader.ReadLine();
                    if (string.IsNullOrEmpty(line))
                    {
                        if (CheckPassportValidity1()) validPassportCount += 1;
                        passportData.Clear();

                        if (streamReader.EndOfStream) break;
                        continue;
                    }

                    var lineData = line.Split(' ');
                    foreach (var data in lineData)
                    {
                        passportData.Add(data.Split(':')[0], data.Split(':')[1]);
                    }
                }
            }

            lbl_part1answer.Text = $"Valid Passports: {validPassportCount}";
            btn_solv2.Visible = true;
        }

        private void btn_solv2_Click(object sender, EventArgs e)
        {
            var validPassportCount = 0;

            using (var streamReader = new StreamReader("2020_day4.txt"))
            {
                while (true)
                {
                    var line = streamReader.ReadLine();
                    if (string.IsNullOrEmpty(line))
                    {
                        if (CheckPassportValidity2()) validPassportCount += 1;
                        passportData.Clear();

                        if (streamReader.EndOfStream) break;
                        continue;
                    }

                    var lineData = line.Split(' ');
                    foreach (var data in lineData)
                    {
                        passportData.Add(data.Split(':')[0], data.Split(':')[1]);
                    }
                }
            }

            lbl_part2answer.Text = $"Valid Passports: {validPassportCount}";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            _2020_day4 setting = new _2020_day4();
            this.Close();
            setting.Close();
        }

        private void _2020_day4_Load(object sender, EventArgs e)
        {
            btn_solv2.Visible = false;
            StreamReader reader = new StreamReader("2020_day4.txt");

            while (!reader.EndOfStream)
            {
                lb_input.Items.Add(reader.ReadLine());
            }
        }
    }
}
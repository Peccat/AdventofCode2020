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
    public partial class _2020_day13 : Form
    {
        public _2020_day13()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        string[] data = File.ReadAllLines("2020_day13.txt");

        private void _2020_day13_Load(object sender, EventArgs e)
        {
            btn_solv2.Visible = false;
            lb_input.Items.Add(data[0]);
            string[] help = data[1].Split(',');
            string bus = "";
            for(int i = 0; i < help.Length; i++)
            {
                if(help[i] != "x") { bus += help[i] + ","; }
            }
            lb_input.Items.Add(bus);
        }

        private void btn_solv1_Click(object sender, EventArgs e)
        {
            btn_solv2.Visible = true;            
            lbl_part1answer.Text = FindEarliestBusId(data);
        }

        private void btn_solv2_Click(object sender, EventArgs e)
        {
            lbl_part2answer.Text = FindSubsequentBusDepartures(data);
        }

        private static string FindEarliestBusId(string[] data)
        {
            var departureTime = int.Parse(data[0]);
            var busIds = data[1].Split(',').Where(s => s != "x").Select(s => int.Parse(s)).ToList();
            var timesToNextDeparture = busIds.Select(id => id - (departureTime % id)).ToList();
            var nextBusIdIndex = timesToNextDeparture.IndexOf(timesToNextDeparture.Min());
            return $"(1) {busIds[nextBusIdIndex]} * {timesToNextDeparture[nextBusIdIndex]} = {busIds[nextBusIdIndex] * timesToNextDeparture[nextBusIdIndex]}";
        }

        private static string FindSubsequentBusDepartures(string[] data)
        {
            var busData = data[1].Split(',').Select(s => s == "x" ? 0 : uint.Parse(s)).ToArray();
            var departureDiffs = GetDepartureDiffs(busData);
            var busIds = busData.Skip(1).Where(d => d != 0).Select(d => Convert.ToUInt32(d)).ToArray();
            // start at first possible departure which is the first busId departing
            var time = (ulong)busData[0];
            Console.WriteLine("\ntime:" + time);
            var candidate = time;
            for (var i = 0; i < busIds.Length; i++)
            {
                while (time % busIds[i] != departureDiffs[i])
                {
                    time += candidate;
                }

                // only check numbers that statisfy time % busId == departureDiff (see below)
                // which is the LCM of the first matching time and the busId
                candidate = Convert.ToUInt64(FindLCM(candidate, busIds[i]));
            }

            return $"\n(2) Earliest timestamp for subsequent departures: {time}";
        }

        // result contains time % busId results that match a given offset from the first ids departure
        // e.g.: id 13 departs i minutes later than the first, then a time candidate t must statisfy t % 13 = 13 - i
        private static uint[] GetDepartureDiffs(uint[] busData)
        {
            var diffs = new List<uint>();
            for (var i = 1U; i < busData.Length; i++)
            {
                if (busData[i] != 0)
                {
                    diffs.Add(busData[i] - i % busData[i]);
                }
            }

            return diffs.ToArray();
        }

        private static ulong FindLCM(ulong a, ulong b)
        {
            return a * b / FindGCD(a, b);
        }

        private static ulong FindGCD(ulong a, ulong b)
        {
            var h = 0UL;
            while (b != 0)
            {
                h = a % b;
                a = b;
                b = h;
            }

            return a;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            _2020_day13 setting = new _2020_day13();
            this.Close();
            setting.Close();
        }

        //private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        //{

        //}
    }
}

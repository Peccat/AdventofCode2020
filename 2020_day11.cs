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
    public partial class _2020_day11 : Form
    {
        public _2020_day11()
        {
            InitializeComponent();
        }
        private void btn_solv1_Click(object sender, EventArgs e)
        {
            btn_solv2.Visible = true;
        }

        private void btn_solv2_Click(object sender, EventArgs e)
        {

        }
    
    private void button1_Click(object sender, EventArgs e)
        {
            //back button
            _2020_day11 setting = new _2020_day11();
            this.Close();
            setting.Close();
        }
        static int counter = 1;
        private void _2020_day11_Load(object sender, EventArgs e)
        {
            btn_solv2.Visible = false;
            //var watch = new System.Diagnostics.Stopwatch();

            //watch.Start();

            string[] input = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "2020_day11.txt"));
            List<Seat> seatsPartOne = new List<Seat>();
            List<Seat> seatsPartTwo = new List<Seat>();
            for (int row = 0; row < input.Length; row++)
            {
                for (int column = 0; column < input[0].Length; column++)
                {
                    if (input[row][column].ToString() != ".")
                    {
                        seatsPartOne.Add(new Seat() { X = column, Y = row, Value = "#", ShouldBeChanged = false, LastTimeChanged = counter });
                        seatsPartTwo.Add(new Seat() { X = column, Y = row, Value = "#", ShouldBeChanged = false, LastTimeChanged = counter });
                    }
                }
            }

            lbl_part1answer.Text =  SolvePartOne(seatsPartOne, 4).ToString();
            counter = 0;
            lbl_part2answer.Text =  SolvePartOne(seatsPartTwo, 5).ToString();
            //watch.Stop();
        }
        private static int SolvePartOne(List<Seat> seats, int tolerance)
        {
            counter++;
            foreach (Seat seat in seats)
            {
                //magic start here with magic number to reduce iteration number
                if (counter - seat.LastTimeChanged < 5)
                {
                    bool ChageState = ChecknNighbors(seat, seats, tolerance);
                    seat.ShouldBeChanged = ChageState;
                }
            }

            if (seats.Any(x => x.ShouldBeChanged == true))
            {
                seats.Where(x => x.ShouldBeChanged == true).ToList().ForEach(x => { x.Value = (x.Value == "#" ? "L" : "#"); x.ShouldBeChanged = false; x.LastTimeChanged = counter; });
                return SolvePartOne(seats, tolerance);
            }
            else
            {
                return seats.Where(x => x.Value == "#").Count();
            }
        }

        private static bool ChecknNighbors(Seat seat, List<Seat> seats, int tolerance)
        {
            int result = 0;
            //left
            result += FoundOccupied(seat.X, seat.Y, -1, 0, seats, (tolerance == 4));
            //right
            result += FoundOccupied(seat.X, seat.Y, 1, 0, seats, (tolerance == 4));
            //down
            result += FoundOccupied(seat.X, seat.Y, 0, 1, seats, (tolerance == 4));
            //up
            result += FoundOccupied(seat.X, seat.Y, 0, -1, seats, (tolerance == 4));
            // upleft
            result += FoundOccupied(seat.X, seat.Y, -1, -1, seats, (tolerance == 4));

            if (result <= tolerance)
            {
                // up-right
                result += FoundOccupied(seat.X, seat.Y, 1, -1, seats, (tolerance == 4));

                // down-letf
                if (result <= tolerance)
                {
                    result += FoundOccupied(seat.X, seat.Y, -1, 1, seats, (tolerance == 4));
                }

                // down-right
                if (result <= tolerance)
                {
                    result += FoundOccupied(seat.X, seat.Y, 1, 1, seats, (tolerance == 4));

                }
            }

            if (seat.Value == "L" && result == 0)
            {
                return true;
            }
            else if (seat.Value == "#" && result >= tolerance)
            {
                return true;
            }

            return false;
        }

        private static int FoundOccupied(int xx, int y, int deltaX, int deltaY, List<Seat> seats, bool isFirstPart)
        {
            var LimitC = seats.Select(x => x.X).Max();
            var LimitR = seats.Select(x => x.Y).Max();
            var tempC = xx + deltaX;
            var tempR = y + deltaY;

            if (tempC < 0 || tempR < 0 || tempC > LimitC || tempR > LimitR)
            {
                return 0;
            }

            if (isFirstPart)
            {
                if (seats.Where(seat => seat.X == tempC && seat.Y == tempR && seat.Value == "#").FirstOrDefault() == null)
                {
                    return 0;
                }

                return 1;
            }
            else
            {
                while (true)
                {
                    var tempSeat = seats.Where(seat => seat.X == tempC && seat.Y == tempR).FirstOrDefault();
                    if (tempSeat != null)
                    {
                        if (tempSeat.Value == "#")
                        {
                            return 1;
                        }

                        break;
                    }

                    tempC += deltaX;
                    tempR += deltaY;

                    if (tempC < 0 || tempR < 0 || tempC > LimitC || tempR > LimitR)
                    {
                        return 0;
                    }
                }

                return 0;
            }
        }
    }

    class Seat
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool ShouldBeChanged { get; set; }
        public string Value { get; set; }
        public int LastTimeChanged { get; set; }

        public override string ToString()
        {
            return $"x: { X }, y: { Y }, type: { Value }, toBeChanged: { ShouldBeChanged }, LastTimeChanged { LastTimeChanged }";
        }
    }
    
}

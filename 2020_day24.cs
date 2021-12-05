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
    public partial class _2020_day24 : Form
    {
        public _2020_day24()
        {
            InitializeComponent();
        }
		static IEnumerable<(int X, int Y)> Neighbours(int X, int Y, bool self = false)
		{
			if (self) yield return (X, Y);
			yield return (X + 1, Y);
			yield return (X + 1, Y + 1);
			yield return (X, Y + 1);
			yield return (X - 1, Y);
			yield return (X - 1, Y - 1);
			yield return (X, Y - 1);
		}

		static void FlipPanel(Dictionary<(int X, int Y), bool> grid, int X, int Y)
		{
			grid.TryGetValue((X, Y), out bool flip);
			if (flip)
			{
				grid.Remove((X, Y));
			}
			else
			{
				grid[(X, Y)] = true;
			}
		}

		static bool Eat(ref string str, string eat)
		{
			if (str.StartsWith(eat))
			{
				str = str.Substring(eat.Length);
				return true;
			}
			return false;
		}
		private void _2020_day24_Load(object sender, EventArgs e)
        {
            btn_solv2.Visible = false;
			Dictionary<(int X, int Y), bool> grid = new Dictionary<(int X, int Y), bool>();
			Dictionary<(int X, int Y), bool> grid2 = new Dictionary<(int X, int Y), bool>();
			StreamReader reader = new StreamReader("2020_day24.txt");
			List<string> input = new List<string>();
			int line = -1;

            while (!reader.EndOfStream)
            {
				line++;
				input.Add(reader.ReadLine());
				lb_input.Items.Add(input[line]);
            }

			foreach (var item in input)
			{
				if (item != "")
				{
					int X = 0, Y = 0;
					string move = item;
					while (move.Length > 0)
					{
						if (Eat(ref move, "e"))
						{
							X++;
						}
						else if (Eat(ref move, "se"))
						{
							X++;
							Y++;
						}
						else if (Eat(ref move, "sw"))
						{
							Y++;
						}
						else if (Eat(ref move, "w"))
						{
							X--;
						}
						else if (Eat(ref move, "nw"))
						{
							X--;
							Y--;
						}
						else if (Eat(ref move, "ne"))
						{
							Y--;
						}
						else
						{
							throw new Exception();
						}
					}
					FlipPanel(grid, X, Y);
				}
			}


			lbl_part1answer.Text= grid.Count(item => item.Value == true).ToString();

			for (int i = 0; i < 100; i++)
			{
				List<(int X, int Y)> flipped = grid.Keys.ToList();

				foreach (var tile in flipped)
				{
					foreach (var neighbour in Neighbours(tile.X, tile.Y, true))
					{
						IEnumerable<(int X, int Y)> neighbours = Neighbours(neighbour.X, neighbour.Y);
						int activeNeighbours = neighbours.Count(item => grid.ContainsKey(item));
						bool currentLit = grid.TryGetValue(neighbour, out bool res);
						if (currentLit)
						{
							if (activeNeighbours != 0 && activeNeighbours < 3)
							{
								grid2[neighbour] = true;
							}
						}
						else
						{
							if (activeNeighbours == 2)
							{
								grid2[neighbour] = true;
							}
						}
					}
				}
				grid.Clear();
				(grid, grid2) = (grid2, grid);
			}

			lbl_part2answer.Text = (grid.Count(item => item.Value == true)).ToString() ;
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
            _2020_day24 setting = new _2020_day24();
            this.Close();
            setting.Close();
        }
    }
}

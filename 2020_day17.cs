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
    public partial class _2020_day17 : Form
    {
        public _2020_day17()
        {
            InitializeComponent();
        }
		Dictionary<(int X, int Y, int Z), char> grid = new Dictionary<(int, int, int), char>();
		Dictionary<(int X, int Y, int Z), char> grid2 = new Dictionary<(int, int, int), char>();
		Dictionary<(int X, int Y, int Z, int W), char> grid4 = new Dictionary<(int, int, int, int), char>();
		Dictionary<(int X, int Y, int Z, int W), char> grid42 = new Dictionary<(int, int, int, int), char>();
		private void _2020_day17_Load(object sender, EventArgs e)
        {
            btn_solv2.Visible = false;
			List<string> _seat = new List<string>();
			List<string> input = new List<string>();
			StreamReader reader = new StreamReader("2020_day17.txt");
			while (!reader.EndOfStream)
			{
				input.Add(reader.ReadLine());
			}
			foreach (var item in input)
			{
				if (item.Length != 0) _seat.Add(item);
			}
			
			char seat(int x, int y, int z)
			{
				return grid.TryGetValue((x, y, z), out char c) ? c : '.';
			}
			void newSeat(int x, int y, int z, char c)
			{
				if (c == '.')
				{
					grid2.Remove((x, y, z));
				}
				else
				{
					grid2[(x, y, z)] = c;
				}
			}

			void setseat(int x, int y, int z, char c)
			{
				grid[(x, y, z)] = c;
			}

			char seat4(int x, int y, int z, int w)
			{
				return grid4.TryGetValue((x, y, z, w), out char c) ? c : '.';
			}
			void newSeat4(int x, int y, int z, int w, char c)
			{
				if (c == '.')
				{
					grid42.Remove((x, y, z, w));
				}
				else
				{
					grid42[(x, y, z, w)] = c;
				}
			}
			void setseat4(int x, int y, int z, int w, char c)
			{
				grid4[(x, y, z, w)] = c;
			}


			for (int i = 0; i < _seat.Count; i++)
			{
				for (int j = 0; j < _seat[0].Length; j++)
				{
					setseat(i, j, 0, _seat[i][j]);
					setseat4(i, j, 0, 0, _seat[i][j]);
				}
			}
			int run = 0;
			while (true)
			{
				int minx = grid.Keys.Min(item => item.X) - 1;
				int miny = grid.Keys.Min(item => item.Y) - 1;
				int minz = grid.Keys.Min(item => item.Z) - 1;
				int maxx = grid.Keys.Max(item => item.X) + 1;
				int maxy = grid.Keys.Max(item => item.Y) + 1;
				int maxz = grid.Keys.Max(item => item.Z) + 1;
				int minw, maxw;

				for (int i = minx; i <= maxx; i++)
				{
					for (int j = miny; j <= maxy; j++)
					{
						for (int k = minz; k <= maxz; k++)
						{
							int neighbors = 0;
							for (int x = -1; x <= 1; x++)
							{
								for (int y = -1; y <= 1; y++)
								{
									for (int z = -1; z <= 1; z++)
									{
										if (x == 0 && y == 0 && z == 0) continue;
										if (seat(i + x, j + y, k + z) == '#')
										{
											neighbors++;
											//break;
										}
									}
								}
							}
							if ((neighbors != 2 && neighbors != 3) && seat(i, j, k) == '#')
							{
								newSeat(i, j, k, '.');
							}
							else if (neighbors == 3 && seat(i, j, k) == '.')
							{
								newSeat(i, j, k, '#');
							}
							else
							{
								newSeat(i, j, k, seat(i, j, k));
							}
						}

					}
				}

				minx = grid4.Keys.Min(item => item.X) - 1;
				miny = grid4.Keys.Min(item => item.Y) - 1;
				minz = grid4.Keys.Min(item => item.Z) - 1;
				minw = grid4.Keys.Min(item => item.W) - 1;
				maxx = grid4.Keys.Max(item => item.X) + 1;
				maxy = grid4.Keys.Max(item => item.Y) + 1;
				maxz = grid4.Keys.Max(item => item.Z) + 1;
				maxw = grid4.Keys.Max(item => item.W) + 1;

				for (int i = minx; i <= maxx; i++)
				{
					for (int j = miny; j <= maxy; j++)
					{
						for (int k = minz; k <= maxz; k++)
						{
							for (int l = minw; l <= maxw; l++)
							{
								int neighbors = 0;
								for (int x = -1; x <= 1; x++)
								{
									for (int y = -1; y <= 1; y++)
									{
										for (int z = -1; z <= 1; z++)
										{
											for (int w = -1; w <= 1; w++)
											{
												if (x == 0 && y == 0 && z == 0 && w == 0) continue;
												if (seat4(i + x, j + y, k + z, l + w) == '#')
												{
													neighbors++;
													//break;
												}
											}
										}
									}
								}
								if ((neighbors != 2 && neighbors != 3) && seat4(i, j, k, l) == '#')
								{
									newSeat4(i, j, k, l, '.');
								}
								else if (neighbors == 3 && seat4(i, j, k, l) == '.')
								{
									newSeat4(i, j, k, l, '#');
								}
								else
								{
									newSeat4(i, j, k, l, seat4(i, j, k, l));
								}
							}
						}

					}
				}

				var swap = grid;
				grid = grid2;
				grid2 = swap;
				grid2.Clear();
				var swap2 = grid4;
				grid4 = grid42;
				grid42 = swap2;
				grid42.Clear();
				/*for (int z = minz; z <= maxz; z++)
				{
					Console.WriteLine($"\nZ: {z}");
					for (int y = miny; y <= maxy; y++)
					{
						for (int x = minx; x <= maxx; x++)
						{
							Console.Write(seat(x, y, z));
						}
						Console.WriteLine();
					}
				}*/
				run++;
				if (run == 6) break;

			}
		}

        private void btn_solv1_Click(object sender, EventArgs e)
        {
            btn_solv2.Visible = true;
            lbl_part1answer.Text = grid.Count(item => item.Value == '#').ToString();
        }

        private void btn_solv2_Click(object sender, EventArgs e)
        {
            lbl_part2answer.Text = grid4.Count(item => item.Value == '#').ToString();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            _2020_day17 setting = new _2020_day17();
            this.Close();
            setting.Close();
        }
    }
}

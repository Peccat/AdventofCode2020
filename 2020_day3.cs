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
    public partial class _2020_day3 : Form
    {
        public _2020_day3()
        {
            InitializeComponent();
        }
        public char[,] map = new char[32, 324];
        public uint[] tree = { 0, 0, 0, 0, 0 };
        private void _2020_day3_Load(object sender, EventArgs e)
        {
            lbl_part1.Text = "With the toboggan login problems resolved, you set off toward the airport. While travel by toboggan might be easy, it's certainly not safe: there's very minimal steering and the area is covered in trees. You'll need to see which angles will take you near the fewest trees. Due to the local geology, trees in this area only grow on exact integer coordinates in a grid. You make a map(input) of the open squares(.) and trees(#) you can see. These aren't the only trees, though; due to something you read about once involving arboreal genetics and biome stability, the same pattern repeats to the right many times. Starting at the top-left corner of your map and following a slope of right 3 and down 1, how many trees would you encounter?";
            btn_solve2.Visible = false;
            string oneline = "";
            int lines = 0;
            StreamReader reader = new StreamReader("2020_day3.txt");
            while (!reader.EndOfStream)
            {
                oneline = reader.ReadLine();
                for (int i = 0; i < oneline.Length; i++) {
                    map[ i + 1, lines + 1] = oneline[i];
                }

                lb_input.Items.Add(oneline);
                lines++;
            }
        }
        private void btn_solv1_Click(object sender, EventArgs e)
        {
            int line = 1, column = 1,  sumcolumn = 31,right =3,down =1;
            
            while (line != 323)
            {
                column += right;
                line += down;
                if (column > sumcolumn)
                {
                    column -= 31;
                }
                if (map[column, line] == '#')
                {
                    //map[oszlop, sor] = 'X';
                    tree[0]++;
                    
                }
                else
                {
                    //map[oszlop, sor] = 'O';
                }
                
            }
            string oneline = "";
            for(int i = 1; i <= 323; i++)
            {
                
                for(int j = 1; j <= 31; j++)
                {
                    oneline += map[j, i];
                }
                
                oneline = "";
            }
            lbl_part1answer.Text = "This map has " + tree[0] + " tree on the way";
            btn_solve2.Visible = true;
            lbl_part2.Text = "Time to check the rest of the slopes - you need to minimize the probability of a sudden arboreal stop, after all. Determine the number of trees you would encounter if, for each of the following slopes, you start at the top - left corner and traverse the map all the way to the bottom: Right 1, down 1; Right 3, down 1 (This is the slope you already checked.); Right 5, down 1; Right 7, down 1; Right 1, down 2. What do you get if you multiply together the number of trees encountered on each of the listed slopes?";
        }

        private void btn_solve2_Click(object sender, EventArgs e)
        {
            int down = 0, right = 0, line = 0, column = 0, sumcolumn = 31;
            uint sum = 0;
            for (int step = 1; step < 5; step++)
            {
                line = 1;column = 1;
                switch (step)
                {
                    case 1: down = 1;right = 1;
                        break;
                    case 2: down = 1;right = 5;
                        break;
                    case 3: down = 1;right = 7;
                        break;
                    case 4: down = 2;right = 1;
                        break;
                }
                
                while (line != 323)
                {
                    column += right;
                    line += down;
                    if (column > sumcolumn)
                    {
                        column -= 31;
                    }
                    if (map[column, line] == '#')
                    {
                        //map[oszlop, sor] = 'X';
                        tree[step]++;
                    }
                    else
                    {
                        //map[oszlop, sor] = 'O';
                    }

                }

            }
            sum = tree[0] * tree[1] * tree[2] * tree[3] * tree[4];
            lbl_part2answer.Text = "This map has " + tree[0] + "*" + tree[1] + "*" + tree[2] + "*" + tree[3] + "*" + tree[4] + "="+ sum + " tree on the way";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            _2020_day3 setting = new _2020_day3();
            this.Close();
            setting.Close();
        }

        
    }
}

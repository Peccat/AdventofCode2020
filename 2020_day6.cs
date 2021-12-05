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

//---Day 6: Custom Customs ---
//As your flight approaches the regional airport where you'll switch to a much larger plane, customs declaration forms are distributed to the passengers.

//The form asks a series of 26 yes-or-no questions marked a through z. All you need to do is identify the questions for which anyone in your group answers "yes". Since your group is just you, this doesn't take very long.

//However, the person sitting next to you seems to be experiencing a language barrier and asks if you can help. For each of the people in their group, you write down the questions for which they answer "yes", one per line. For example:

//abcx
//abcy
//abcz
//In this group, there are 6 questions to which anyone answered "yes": a, b, c, x, y, and z. (Duplicate answers to the same question don't count extra; each question counts at most once.)

//Another group asks for your help, then another, and eventually you've collected answers from every group on the plane (your puzzle input). Each group's answers are separated by a blank line, and within each group, each person's answers are on a single line. For example:

//abc

//a
//b
//c

//ab
//ac

//a
//a
//a
//a

//b
//This list represents answers from five groups:

//The first group contains one person who answered "yes" to 3 questions: a, b, and c.
//The second group contains three people; combined, they answered "yes" to 3 questions: a, b, and c.
//The third group contains two people; combined, they answered "yes" to 3 questions: a, b, and c.
//The fourth group contains four people; combined, they answered "yes" to only 1 question, a.
//The last group contains one person who answered "yes" to only 1 question, b.
//In this example, the sum of these counts is 3 + 3 + 3 + 1 + 1 = 11.

//For each group, count the number of questions to which anyone answered "yes". What is the sum of those counts?

//Your puzzle answer was 6686.

//The first half of this puzzle is complete! It provides one gold star: *

//---Part Two-- -
//As you finish the last group's customs declaration, you notice that you misread one word in the instructions:

//You don't need to identify the questions to which anyone answered "yes"; you need to identify the questions to which everyone answered "yes"!

//Using the same example as above:

//abc

//a
//b
//c

//ab
//ac

//a
//a
//a
//a

//b
//This list represents answers from five groups:

//In the first group, everyone (all 1 person) answered "yes" to 3 questions: a, b, and c.
//In the second group, there is no question to which everyone answered "yes".
//In the third group, everyone answered yes to only 1 question, a.Since some people did not answer "yes" to b or c, they don't count.
//In the fourth group, everyone answered yes to only 1 question, a.
//In the fifth group, everyone (all 1 person) answered "yes" to 1 question, b.
//In this example, the sum of these counts is 3 + 0 + 1 + 1 + 1 = 6.

//For each group, count the number of questions to which everyone answered "yes". What is the sum of those counts?

namespace AdventOfCode2020
{
    public partial class _2020_day6 : Form
    {
        public _2020_day6()
        {
            InitializeComponent();
        }
        int db = -1;
        List<char> tmb = new List<char>();
        List<char> tmb2 = new List<char>();
        List<char> tmb2_seged = new List<char>();
        List<int> valaszok = new List<int>();
        List<int> valaszok2 = new List<int>();
        char[] chartmb = new char[50];

        private void _2020_day6_Load(object sender, EventArgs e)
        {
            btn_solv2.Visible = false;
            string tomb = "";
            string tomb2 = "";
            List<string> veg = new List<string>();
            int blokk = 0;
            int tmb2db = 0;

            StreamReader reader = new StreamReader("2020_day6.txt");
            while (!reader.EndOfStream)
            {

                db++;
                bool volt = false;
                string egysor = reader.ReadLine();
                lb_input.Items.Add(egysor);
                
                if (egysor == "") 
                {
                    tomb = "";
                    tomb2 = "";
                    for (int i = 0; i < tmb.Count; i++)
                    {
                        tomb += tmb[i];
                        
                    }

                    for (int i = 0; i < tmb.Count; i++)
                    {
                        for(int j = 0; j < tmb2.Count; j++)
                        {
                            if(tmb[i] == tmb2[j])
                            {
                                tmb2db++;
                            }
                        }
                        
                        if (blokk == tmb2db)
                        {
                            tmb2_seged.Add(tmb[i]);
                            
                        }
                        tmb2db = 0;
                    }

                    for (int i = 0; i < tmb2_seged.Count; i++)
                    {
                        tomb2 += tmb2_seged[i];
                    }

                    valaszok.Add(tmb.Count);
                    valaszok2.Add(tmb2_seged.Count);
                    listBox1.Items.Add(blokk + " " + tomb + "\t" + tomb2 );
                    tmb.Clear();
                    tmb2.Clear();
                    tmb2_seged.Clear();
                    
                    blokk = 0;
                } 
                else
                {
                    
                    for(int i = 0; i < egysor.Length; i++) 
                    { 
                        for (int j = 0; j <tmb.Count; j++) 
                        { 
                            if(tmb[j] == egysor[i])
                            {
                                volt = true;
                                //volt már ilyen betű
                                
                            }
                        }
                        if (volt == true)
                        {
                            volt = false;
                            // volt mér ilyen betű

                        }
                        else
                        {
                            tmb.Add(egysor[i]);
                        }
                        tmb2.Add(egysor[i]);
                    }
                    blokk++;
                }
            }
            tomb = "";
            for (int i = 0; i < tmb.Count; i++)
            {
                tomb += tmb[i];

            }
            valaszok.Add(tmb.Count);
            listBox1.Items.Add(tomb);
            tmb.Clear();
        }

        private void btn_solv1_Click(object sender, EventArgs e)
        {
            btn_solv2.Visible = true;
            int sum = 0;
            for(int i = 0; i < valaszok.Count; i++)
            {
                sum += valaszok[i];
            }
            lb_part1answer.Text = "The answers sum: " + sum;
        }

        private void btn_solv2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < valaszok2.Count; i++)
            {
                sum += valaszok2[i];
            }
            lb_part2answer.Text = "The answers sum: " + sum;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            _2020_day6 setting = new _2020_day6();
            this.Close();
            setting.Close();
        }
    }
}

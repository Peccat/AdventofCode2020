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
    public partial class _2020_day2 : Form
    {
        public _2020_day2()
        {
            InitializeComponent();
        }

        struct adatok
        {
            public int tol,ig;
            public string karakterek, karakter;
            
        }
        public int jo,jo_2 = 0;

        
        private void _2020_day2_Load(object sender, EventArgs e)
        {
            lbl_story.Text = "Your flight departs in a few days from the coastal airport; the easiest way down to the coast from here is via toboggan. The shopkeeper at the North Pole Toboggan Rental Shop is having a bad day. 'Something's wrong with our computers; we can't log in!' You ask if you can take a look. Their password database seems to be a little corrupted: some of the passwords wouldn't have been allowed by the Official Toboggan Corporate Policy that was in effect when they were chosen. To try to debug the problem, they have created a list(your puzzle input) of passwords(according to the corrupted database) and the corporate policy when that password was set. For example, suppose you have the following list: 1 - 3 a: abcde; 1 - 3 b: cdefg; 2 - 9 c: ccccccccc. Each line gives the password policy and then the password.The password policy indicates the lowest and highest number of times a given letter must appear for the password to be valid.For example, 1 - 3 a means that the password must contain a at least 1 time and at most 3 times. In the above example, 2 passwords are valid.The middle password, cdefg, is not; it contains no instances of b, but needs at least 1.The first and third passwords are valid: they contain one a or nine c, both within the limits of their respective policies. How many passwords are valid according to their policies? ";
            btn_solv2.Visible = false;
            int db = 0;
            
            int sum = 0;
            adatok[] egysor = new adatok[1000];
            bool igaz = false;
            

            StreamReader reader = new StreamReader("2020_day2.txt");
            while (!reader.EndOfStream)
            {
                string[] sor = reader.ReadLine().Split(' ');
                string cut = sor[0];
                string[] cutter = cut.Split('-');
                egysor[db].tol = int.Parse(cutter[0]);
                egysor[db].ig = int.Parse(cutter[1]);
                egysor[db].karakter = sor[1];
                egysor[db].karakterek = sor[2];
                lb_input.Items.Add(db + 1 + " " + egysor[db].tol + "-" + egysor[db].ig + "\t" + egysor[db].karakter + "\t" + egysor[db].karakterek);
                for (int i = 0; i < egysor[db].karakterek.Length; i++)
                {
                    //part 1
                    if (egysor[db].karakterek[i] == egysor[db].karakter[0])
                    {
                        sum++;
                    }   
                }
                if (sum <= egysor[db].ig && sum >= egysor[db].tol) { igaz = true; }
                if (igaz == true) { jo++; igaz = false; }

                //part 2
                //1-4 n: nnnnn
                //7 - 11 m: mmmmmmsmmmmm
                        //1. = n
                        //7. = s
                if (egysor[db].karakterek[egysor[db].tol-1] == egysor[db].karakter[0])
                {
                        //4<=5
                        //11<=12
                    if (egysor[db].ig <= egysor[db].karakterek.Length)
                    {   
                                //4=n
                                //11=m
                        if (egysor[db].karakterek[egysor[db].ig - 1] != egysor[db].karakter[0])
                        {
                            jo_2++;
                        }
                    }
                    
                }else if(egysor[db].karakterek[egysor[db].ig - 1] == egysor[db].karakter[0])
                {
                    jo_2++;
                }


                db++;
                sum = 0;
            }
        }

        private void btn_solv_Click(object sender, EventArgs e)
        {
            
            lbl_answer.Text = "The good answer's sum: " + jo;
            btn_solv2.Visible = true;
            lbl_part2.Text = "While it appears you validated the passwords correctly, they don't seem to be what the Official Toboggan Corporate Authentication System is expecting. The shopkeeper suddenly realizes that he just accidentally explained the password policy rules from his old job at the sled rental place down the street! The Official Toboggan Corporate Policy actually works a little differently. Each policy actually describes two positions in the password, where 1 means the first character, 2 means the second character, and so on. (Be careful; Toboggan Corporate Policies have no concept of 'index zero'!) Exactly one of these positions must contain the given letter. Other occurrences of the letter are irrelevant for the purposes of policy enforcement. Given the same example list from above: 1 - 3 a: abcde is valid: position 1 contains a and position 3 does not. 1 - 3 b: cdefg is invalid: neither position 1 nor position 3 contains b. 2 - 9 c: ccccccccc is invalid: both position 2 and position 9 contain c. How many passwords are valid according to the new interpretation of the policies ? ";
        }

        private void btn_solv2_Click(object sender, EventArgs e)
        {
            lbl_part2_answer.Text = "The correct passwords: " + jo_2;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            _2020_day2 settings = new _2020_day2();
            this.Close();
            settings.Close();
        }
    }
}

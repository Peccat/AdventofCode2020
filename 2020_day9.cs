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
    public partial class _2020_day9 : Form
    {
        public _2020_day9()
        {
            InitializeComponent();
        }
        static int preamble = 25;
        static long invalidNumber;
        static List<long> doubleSums = new List<long>();
        static List<long> preambleList = new List<long>();
        static List<long> invalidTotalList = new List<long>();
        static long min = new long();
        static long max = new long();
        
        private void _2020_day9_Load(object sender, EventArgs e)
        {
            btn_solv2.Visible = false;
            StreamReader reader = new StreamReader("2020_day9.txt");
            while (!reader.EndOfStream)
            {
                lb_input.Items.Add(reader.ReadLine());
            }
            
        }

        private void btn_solv1_Click(object sender, EventArgs e)
        {
            btn_solv2.Visible = true;
            var inputNumbers = File.ReadAllLines("2020_day9.txt");
            SolutionOne(inputNumbers);
            lbl_part1answer.Text = "The invalis number: " + invalidNumber;
        }

        private void btn_solv2_Click(object sender, EventArgs e)
        {
            var inputNumbers = File.ReadAllLines("2020_day9.txt");
            SolutionTwo(inputNumbers);
            lbl_part2answer.Text = "The encryption weakness: " + (min+max);
        }

        static void SolutionOne(string[] inputData)
        {
            var index = 0;
            var doubleIndex = 0;
            for (int i = 0; i < inputData.Length; i++)
            {
                var currentNumber = long.Parse(inputData[i]);
                index = i % preamble;

                if (i >= preamble)
                {
                    index = preamble - 1;
                    if (!doubleSums.Contains(currentNumber))
                    {
                        invalidNumber = currentNumber;
                        //Console.WriteLine($"Invalid Number: {invalidNumber}");
                        break;
                    }
                    else
                    {
                        preambleList.RemoveAt(0);
                        var dsIndex = doubleIndex;
                        for (int p = preamble - 2; p >= 0; p--)
                        {
                            doubleSums.RemoveAt(dsIndex);
                            dsIndex -= p;
                        }
                    }
                }
                else
                {
                    if (i < preamble - 1) doubleIndex += i;
                }

                preambleList.Add(currentNumber);
                for (int j = 0; j < index; j++)
                    doubleSums.Add(preambleList[j] + preambleList[index]);
            }
        }

        static void SolutionTwo(string[] inputData)
        {
            long invalidTotal = 0;
            foreach (var number in inputData)
            {
                long currentNumber = long.Parse(number);
                invalidTotal += currentNumber;
                invalidTotalList.Add(currentNumber);

                if (invalidTotal > invalidNumber)
                {
                    while (invalidTotal > invalidNumber)
                    {
                        invalidTotal -= invalidTotalList[0];
                        invalidTotalList.RemoveAt(0);
                    }
                }

                if (invalidTotal == invalidNumber) break;
            }
            invalidTotalList.Sort();
            _2020_day9.min = invalidTotalList.First();
            _2020_day9.max = invalidTotalList.Last();
            //Console.WriteLine($"Encryption Weakness: {min + max}");
            //Console.ReadKey();
            
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            _2020_day9 setting = new _2020_day9();
            this.Close();
            setting.Close();
        }
    }
}

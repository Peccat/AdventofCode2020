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
    public partial class _2020_day22 : Form
    {
        public _2020_day22()
        {
            InitializeComponent();
        }
		long part1answer = 0;
		long part2answer = 0;
        private void _2020_day22_Load(object sender, EventArgs e)
        {
            btn_solv2.Visible = false;
			Queue<int> p1Cards = new Queue<int>();
			Queue<int> p2Cards = new Queue<int>();
			Queue<int> p1CardsR2 = new Queue<int>();
			Queue<int> p2CardsR2 = new Queue<int>();
			Queue<int> writeto = null;
			Queue<int> writetoR2 = null;
			List<string> input = new List<string>();
			StreamReader reader = new StreamReader("2020_day22.txt");
			while (!reader.EndOfStream)
			{
				input.Add(reader.ReadLine());
			}
			foreach (var item in input)
			{
				if (item == "Player 1:")
				{
					writeto = p1Cards;
					writetoR2 = p1CardsR2;
				}
				else if (item == "Player 2:")
				{
					writeto = p2Cards;
					writetoR2 = p2CardsR2;
				}
				else if (item != "")
				{
					writeto.Enqueue(int.Parse(item));
					writetoR2.Enqueue(int.Parse(item));
				}
			}
			while (p1Cards.Count != 0 && p2Cards.Count != 0)
			{
				int p1 = p1Cards.Dequeue();
				int p2 = p2Cards.Dequeue();
				if (p1 < p2)
				{
					//Console.WriteLine($"Player 2 Win! {p1} < {p2}");
					p2Cards.Enqueue(p2);
					p2Cards.Enqueue(p1);
				}
				else
				{
					//Console.WriteLine($"Player 1 Win! {p1} > {p2}");
					p1Cards.Enqueue(p1);
					p1Cards.Enqueue(p2);
				}
			}
			List<int> cards = p1Cards.Count != 0 ? p1Cards.ToList() : p2Cards.ToList();
			long score = 0;
			for (int i = 0; i < cards.Count; i++)
			{
				score += cards[i] * (cards.Count - i);
				//Console.WriteLine($"{cards[i]} * {(cards.Count - i)}");
			}
			part1answer = score;
			bool winner;
			(winner, p1Cards, p2Cards) = RecursiveCombat(p1CardsR2, p2CardsR2);

			cards = winner ? p1Cards.ToList() : p2Cards.ToList();
			score = 0;
			for (int i = 0; i < cards.Count; i++)
			{
				score += cards[i] * (cards.Count - i);
				//Console.WriteLine($"{cards[i]} * {(cards.Count - i)}");
			}
			part2answer=  score;
		}
		// If both players have at least as many cards remaining in their deck as the value of the card they just drew,
		// the winner of the round is determined by playing a new game of Recursive Combat

		static int gameID = 0;
		/// <summary>
		/// Plays a game of recursive cards.
		/// </summary>
		/// <param name="p1C"></param>
		/// <param name="p2C"></param>
		/// <returns>If true, player 1 won.</returns>
		static (bool p1Win, Queue<int>, Queue<int>) RecursiveCombat(IEnumerable<int> p1C, IEnumerable<int> p2C)
		{
			gameID++;
			//Console.WriteLine($"Starting game of recursive combat #{gameID}");
			var p1CardsR2 = new Queue<int>(p1C);
			var p2CardsR2 = new Queue<int>(p2C);
			List<string> rounds = new List<string>();
			while (p1CardsR2.Count != 0 && p2CardsR2.Count != 0)
			{
				if (rounds.Contains(RoundMemo(p1CardsR2, p2CardsR2)))
				{
					// Player 1 forced win!
					return (true, p1CardsR2, p2CardsR2);
				}
				rounds.Add(RoundMemo(p1CardsR2, p2CardsR2));
				int p1 = p1CardsR2.Dequeue();
				int p2 = p2CardsR2.Dequeue();
				if (p1CardsR2.Count >= p1 && p2CardsR2.Count >= p2)
				{
					if (RecursiveCombat(p1CardsR2.Take(p1), p2CardsR2.Take(p2)).p1Win)
					{
						//Console.WriteLine($"Player 1 Win! (won recursive combat)");
						p1CardsR2.Enqueue(p1);
						p1CardsR2.Enqueue(p2);
					}
					else
					{
						//Console.WriteLine($"Player 2 Win! (won recursive combat)");
						p2CardsR2.Enqueue(p2);
						p2CardsR2.Enqueue(p1);
					}
				}
				else
				{
					if (p1 < p2)
					{
						//Console.WriteLine($"Player 2 Win! {p1} < {p2}");
						p2CardsR2.Enqueue(p2);
						p2CardsR2.Enqueue(p1);
					}
					else
					{
						//Console.WriteLine($"Player 1 Win! {p1} > {p2}");
						p1CardsR2.Enqueue(p1);
						p1CardsR2.Enqueue(p2);
					}
				}
				//System.Threading.Thread.Sleep(125);
			}
			return (p1CardsR2.Count > p2CardsR2.Count, p1CardsR2, p2CardsR2);
		}

		static string RoundMemo(Queue<int> p1, Queue<int> p2)
		{
			string memo = "";
			foreach (var item in p1)
			{
				memo += $"{item},";
			}
			memo += "\n";
			foreach (var item in p2)
			{
				memo += $"{item},";
			}
			return memo;
		}

        private void btn_solve1_Click(object sender, EventArgs e)
        {
            btn_solv2.Visible = true;
			lbl_part1answer.Text = part1answer.ToString();
        }

        private void btn_solv2_Click(object sender, EventArgs e)
        {
			lbl_part2answer.Text = part2answer.ToString();
        }

        

        private void btn_back_Click(object sender, EventArgs e)
        {
            _2020_day22 setting = new _2020_day22();
            this.Close();
            setting.Close();
        }
    }
}

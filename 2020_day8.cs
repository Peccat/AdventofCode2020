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
    
    public partial class _2020_day8 : Form
    {
        
        static bool isSecond = false;
        static bool isLastCommandExecuted = false;
        static List<ICommand> instructionList = new List<ICommand>();
        static Dictionary<int, ICommand> executionOutput = new Dictionary<int, ICommand>();

        static void FindTheCorruptedCommand()
        {
            isSecond = true;
            foreach (var output in executionOutput)
            {
                Globals.Accumulator = 0;
                Globals.InstructionPointer = 0;
                ClearExecutionFlags();

                var oldCommand = SwapCommand(output);
                ExecuteInstructionList();
                instructionList[output.Key] = oldCommand;

                if (isLastCommandExecuted)
                {
                    //Console.WriteLine($"Changed Command: {output.Value.GetType().Name} at IP:{output.Key}");
                    
                    break;
                }
            }
        }

        static void ExecuteInstructionList()
        {
            var output = new StringBuilder();
            while (true)
            {
                var command = instructionList[Globals.InstructionPointer];
                if (command.IsExecuted) break;

                if ((command is Jmp || command is Nop) && !isSecond)
                {
                    executionOutput.Add(Globals.InstructionPointer, command);
                }

                command.Execute();

                if (Globals.InstructionPointer == instructionList.Count)
                {
                    isLastCommandExecuted = true;
                    break;
                }
            }
        }

        static ICommand SwapCommand(KeyValuePair<int, ICommand> output)
        {
            var oldCommand = instructionList[output.Key];
            ICommand newCommand;

            if (output.Value is Nop)
            {
                var command = output.Value;
                newCommand = new Jmp(command.Argument, command.IsPositive);
            }
            else
            {
                var command = output.Value;
                newCommand = new Nop(command.Argument, command.IsPositive);
            }

            instructionList[output.Key] = newCommand;

            return oldCommand;
        }

        static void ClearExecutionFlags()
        {
            foreach (var instruction in instructionList)
            {
                instruction.ClearExecutionFlag();
            }
        }

        static void CreateInstructionList()
        {
            foreach (var line in File.ReadAllLines("2020_day8.txt"))
            {
                var lineData = line.Split(' ');
                var op = lineData[0];
                var opSign = lineData[1][0];
                var arg = int.Parse(lineData[1].Substring(1));

                instructionList.Add(CreateCommand(op, arg, opSign));
            }
        }

        static ICommand CreateCommand(string op, int argument, char opSign)
        {
            switch (op)
            {
                case "nop":
                    return new Nop(argument, opSign.Equals('+'));

                case "acc":
                    return new Acc(argument, opSign.Equals('+'));

                case "jmp":
                    return new Jmp(argument, opSign.Equals('+'));

                default:
                    throw new ArgumentException(nameof(op));
            }
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
        public _2020_day8()
        {
            InitializeComponent();
        }

        static class Globals
        {
            public static int Accumulator = 0;
            public static int InstructionPointer = 0;
        }

        interface ICommand
        {
            bool IsExecuted { get; }
            int Argument { get; }
            bool IsPositive { get; }

            void Execute();
            void ClearExecutionFlag();
        }

        abstract class Command
        {
            protected int Argument;
            protected bool IsPositive;
            protected bool IsExecuted = false;

            public Command(int argument, bool isPositive)
            {
                Argument = argument;
                IsPositive = isPositive;
            }
        }

        class Nop : Command, ICommand
        {
            public Nop(int argument, bool isPositive) : base(argument, isPositive)
            { }

            void ICommand.Execute()
            {
                IsExecuted = true;
                Globals.InstructionPointer++;
            }

            void ICommand.ClearExecutionFlag()
            {
                IsExecuted = false;
            }

            bool ICommand.IsExecuted => IsExecuted;

            int ICommand.Argument => Argument;

            bool ICommand.IsPositive => IsPositive;
        }

        class Acc : Command, ICommand
        {
            public Acc(int argument, bool isPositive) : base(argument, isPositive)
            { }

            void ICommand.Execute()
            {
                if (IsPositive)
                {
                    Globals.Accumulator += Argument;
                }
                else
                {
                    Globals.Accumulator -= Argument;
                }

                IsExecuted = true;
                Globals.InstructionPointer++;
            }

            void ICommand.ClearExecutionFlag()
            {
                IsExecuted = false;
            }

            bool ICommand.IsExecuted => IsExecuted;

            int ICommand.Argument => Argument;

            bool ICommand.IsPositive => IsPositive;
        }

        class Jmp : Command, ICommand
        {
            public Jmp(int argument, bool isPositive) : base(argument, isPositive)
            { }

            void ICommand.Execute()
            {
                if (IsPositive)
                {
                    Globals.InstructionPointer += Argument;
                }
                else
                {
                    Globals.InstructionPointer -= Argument;
                }

                IsExecuted = true;
            }

            void ICommand.ClearExecutionFlag()
            {
                IsExecuted = false;
            }

            bool ICommand.IsExecuted => IsExecuted;

            int ICommand.Argument => Argument;

            bool ICommand.IsPositive => IsPositive;
        }


        private void _2020_day8_Load(object sender, EventArgs e)
        {
            btn_solv2.Visible = false;
            CreateInstructionList();
            StreamReader reader = new StreamReader("2020_day8.txt");
            while (!reader.EndOfStream)
            {
                lb_input.Items.Add(reader.ReadLine());
            }
        }

        private void btn_solv1_Click(object sender, EventArgs e)
        {
            btn_solv2.Visible = true;
            ExecuteInstructionList();
            lbl_part1answer.Text = $"Current Acc Value: {Globals.Accumulator}";
        }

        private void btn_solv2_Click(object sender, EventArgs e)
        {
            FindTheCorruptedCommand();
            lbl_part2answer.Text = $"Corrected Acc Value: {Globals.Accumulator}";
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            _2020_day8 setting = new _2020_day8();
            this.Close();
            setting.Close();
        }
    }
}

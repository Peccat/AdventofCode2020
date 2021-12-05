
namespace AdventOfCode2020
{
    partial class _2020_day6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_part1 = new System.Windows.Forms.Label();
            this.btn_solv1 = new System.Windows.Forms.Button();
            this.lb_part1answer = new System.Windows.Forms.Label();
            this.lb_part2 = new System.Windows.Forms.Label();
            this.btn_solv2 = new System.Windows.Forms.Button();
            this.lb_part2answer = new System.Windows.Forms.Label();
            this.lb_input = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_part1
            // 
            this.lbl_part1.Location = new System.Drawing.Point(13, 13);
            this.lbl_part1.Name = "lbl_part1";
            this.lbl_part1.Size = new System.Drawing.Size(566, 166);
            this.lbl_part1.TabIndex = 0;
            this.lbl_part1.Text = " ";
            // 
            // btn_solv1
            // 
            this.btn_solv1.Location = new System.Drawing.Point(292, 183);
            this.btn_solv1.Name = "btn_solv1";
            this.btn_solv1.Size = new System.Drawing.Size(75, 23);
            this.btn_solv1.TabIndex = 1;
            this.btn_solv1.Text = "Solving";
            this.btn_solv1.UseVisualStyleBackColor = true;
            this.btn_solv1.Click += new System.EventHandler(this.btn_solv1_Click);
            // 
            // lb_part1answer
            // 
            this.lb_part1answer.Location = new System.Drawing.Point(13, 209);
            this.lb_part1answer.Name = "lb_part1answer";
            this.lb_part1answer.Size = new System.Drawing.Size(566, 21);
            this.lb_part1answer.TabIndex = 2;
            this.lb_part1answer.Text = " ";
            // 
            // lb_part2
            // 
            this.lb_part2.Location = new System.Drawing.Point(13, 244);
            this.lb_part2.Name = "lb_part2";
            this.lb_part2.Size = new System.Drawing.Size(566, 93);
            this.lb_part2.TabIndex = 3;
            this.lb_part2.Text = " ";
            // 
            // btn_solv2
            // 
            this.btn_solv2.Location = new System.Drawing.Point(292, 341);
            this.btn_solv2.Name = "btn_solv2";
            this.btn_solv2.Size = new System.Drawing.Size(75, 23);
            this.btn_solv2.TabIndex = 4;
            this.btn_solv2.Text = "Solving";
            this.btn_solv2.UseVisualStyleBackColor = true;
            this.btn_solv2.Click += new System.EventHandler(this.btn_solv2_Click);
            // 
            // lb_part2answer
            // 
            this.lb_part2answer.Location = new System.Drawing.Point(13, 367);
            this.lb_part2answer.Name = "lb_part2answer";
            this.lb_part2answer.Size = new System.Drawing.Size(566, 35);
            this.lb_part2answer.TabIndex = 5;
            this.lb_part2answer.Text = " ";
            // 
            // lb_input
            // 
            this.lb_input.FormattingEnabled = true;
            this.lb_input.Location = new System.Drawing.Point(585, 34);
            this.lb_input.Name = "lb_input";
            this.lb_input.Size = new System.Drawing.Size(202, 381);
            this.lb_input.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(585, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Input:";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(292, 406);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(794, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(275, 381);
            this.listBox1.TabIndex = 9;
            // 
            // _2020_day6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_input);
            this.Controls.Add(this.lb_part2answer);
            this.Controls.Add(this.btn_solv2);
            this.Controls.Add(this.lb_part2);
            this.Controls.Add(this.lb_part1answer);
            this.Controls.Add(this.btn_solv1);
            this.Controls.Add(this.lbl_part1);
            this.Name = "_2020_day6";
            this.Text = "_2020_day6";
            this.Load += new System.EventHandler(this._2020_day6_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_part1;
        private System.Windows.Forms.Button btn_solv1;
        private System.Windows.Forms.Label lb_part1answer;
        private System.Windows.Forms.Label lb_part2;
        private System.Windows.Forms.Button btn_solv2;
        private System.Windows.Forms.Label lb_part2answer;
        private System.Windows.Forms.ListBox lb_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ListBox listBox1;
    }
}

namespace AdventOfCode2020
{
    partial class _2020_day21
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
            this.lbl_part1answer = new System.Windows.Forms.Label();
            this.lbl_part2 = new System.Windows.Forms.Label();
            this.btn_solv2 = new System.Windows.Forms.Button();
            this.lbl_part2answer = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_part1
            // 
            this.lbl_part1.Location = new System.Drawing.Point(13, 3);
            this.lbl_part1.Name = "lbl_part1";
            this.lbl_part1.Size = new System.Drawing.Size(588, 154);
            this.lbl_part1.TabIndex = 0;
            this.lbl_part1.Text = " ";
            // 
            // btn_solv1
            // 
            this.btn_solv1.Location = new System.Drawing.Point(266, 160);
            this.btn_solv1.Name = "btn_solv1";
            this.btn_solv1.Size = new System.Drawing.Size(75, 23);
            this.btn_solv1.TabIndex = 1;
            this.btn_solv1.Text = "Solving";
            this.btn_solv1.UseVisualStyleBackColor = true;
            this.btn_solv1.Click += new System.EventHandler(this.btn_solv1_Click);
            // 
            // lbl_part1answer
            // 
            this.lbl_part1answer.Location = new System.Drawing.Point(13, 196);
            this.lbl_part1answer.Name = "lbl_part1answer";
            this.lbl_part1answer.Size = new System.Drawing.Size(588, 18);
            this.lbl_part1answer.TabIndex = 2;
            this.lbl_part1answer.Text = " ";
            // 
            // lbl_part2
            // 
            this.lbl_part2.Location = new System.Drawing.Point(13, 218);
            this.lbl_part2.Name = "lbl_part2";
            this.lbl_part2.Size = new System.Drawing.Size(588, 108);
            this.lbl_part2.TabIndex = 3;
            this.lbl_part2.Text = " ";
            // 
            // btn_solv2
            // 
            this.btn_solv2.Location = new System.Drawing.Point(266, 345);
            this.btn_solv2.Name = "btn_solv2";
            this.btn_solv2.Size = new System.Drawing.Size(75, 23);
            this.btn_solv2.TabIndex = 4;
            this.btn_solv2.Text = "Solving";
            this.btn_solv2.UseVisualStyleBackColor = true;
            this.btn_solv2.Click += new System.EventHandler(this.btn_solv2_Click);
            // 
            // lbl_part2answer
            // 
            this.lbl_part2answer.Location = new System.Drawing.Point(13, 381);
            this.lbl_part2answer.Name = "lbl_part2answer";
            this.lbl_part2answer.Size = new System.Drawing.Size(588, 23);
            this.lbl_part2answer.TabIndex = 5;
            this.lbl_part2answer.Text = " ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(607, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(181, 407);
            this.listBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(607, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Input:";
            // 
            // btn_back
            // 
            this.btn_back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_back.Location = new System.Drawing.Point(266, 408);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // _2020_day21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbl_part2answer);
            this.Controls.Add(this.btn_solv2);
            this.Controls.Add(this.lbl_part2);
            this.Controls.Add(this.lbl_part1answer);
            this.Controls.Add(this.btn_solv1);
            this.Controls.Add(this.lbl_part1);
            this.Name = "_2020_day21";
            this.Text = "_2020_day21";
            this.Load += new System.EventHandler(this._2020_day21_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_part1;
        private System.Windows.Forms.Button btn_solv1;
        private System.Windows.Forms.Label lbl_part1answer;
        private System.Windows.Forms.Label lbl_part2;
        private System.Windows.Forms.Button btn_solv2;
        private System.Windows.Forms.Label lbl_part2answer;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
    }
}
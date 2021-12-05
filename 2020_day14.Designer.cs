
namespace AdventOfCode2020
{
    partial class _2020_day14
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
            this.btn_solv1 = new System.Windows.Forms.Button();
            this.lbl_part1 = new System.Windows.Forms.Label();
            this.lbl_part1answer = new System.Windows.Forms.Label();
            this.lbl_part2 = new System.Windows.Forms.Label();
            this.btn_solv2 = new System.Windows.Forms.Button();
            this.lbl_part2answer = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.lb_input = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_solv1
            // 
            this.btn_solv1.Location = new System.Drawing.Point(240, 161);
            this.btn_solv1.Name = "btn_solv1";
            this.btn_solv1.Size = new System.Drawing.Size(75, 23);
            this.btn_solv1.TabIndex = 0;
            this.btn_solv1.Text = "Solving";
            this.btn_solv1.UseVisualStyleBackColor = true;
            this.btn_solv1.Click += new System.EventHandler(this.btn_solv1_Click);
            // 
            // lbl_part1
            // 
            this.lbl_part1.Location = new System.Drawing.Point(12, 9);
            this.lbl_part1.Name = "lbl_part1";
            this.lbl_part1.Size = new System.Drawing.Size(539, 149);
            this.lbl_part1.TabIndex = 1;
            this.lbl_part1.Text = " ";
            // 
            // lbl_part1answer
            // 
            this.lbl_part1answer.Location = new System.Drawing.Point(13, 187);
            this.lbl_part1answer.Name = "lbl_part1answer";
            this.lbl_part1answer.Size = new System.Drawing.Size(538, 23);
            this.lbl_part1answer.TabIndex = 2;
            this.lbl_part1answer.Text = " ";
            // 
            // lbl_part2
            // 
            this.lbl_part2.Location = new System.Drawing.Point(15, 214);
            this.lbl_part2.Name = "lbl_part2";
            this.lbl_part2.Size = new System.Drawing.Size(536, 129);
            this.lbl_part2.TabIndex = 3;
            this.lbl_part2.Text = " ";
            // 
            // btn_solv2
            // 
            this.btn_solv2.Location = new System.Drawing.Point(240, 346);
            this.btn_solv2.Name = "btn_solv2";
            this.btn_solv2.Size = new System.Drawing.Size(75, 23);
            this.btn_solv2.TabIndex = 4;
            this.btn_solv2.Text = "Solving";
            this.btn_solv2.UseVisualStyleBackColor = true;
            this.btn_solv2.Click += new System.EventHandler(this.btn_solv2_Click);
            // 
            // lbl_part2answer
            // 
            this.lbl_part2answer.Location = new System.Drawing.Point(13, 372);
            this.lbl_part2answer.Name = "lbl_part2answer";
            this.lbl_part2answer.Size = new System.Drawing.Size(533, 28);
            this.lbl_part2answer.TabIndex = 5;
            this.lbl_part2answer.Text = " ";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(240, 403);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lb_input
            // 
            this.lb_input.FormattingEnabled = true;
            this.lb_input.Location = new System.Drawing.Point(558, 26);
            this.lb_input.Name = "lb_input";
            this.lb_input.Size = new System.Drawing.Size(340, 394);
            this.lb_input.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Input:";
            // 
            // _2020_day14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 442);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_input);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_part2answer);
            this.Controls.Add(this.btn_solv2);
            this.Controls.Add(this.lbl_part2);
            this.Controls.Add(this.lbl_part1answer);
            this.Controls.Add(this.lbl_part1);
            this.Controls.Add(this.btn_solv1);
            this.Name = "_2020_day14";
            this.Text = "_2020_day14";
            this.Load += new System.EventHandler(this._2020_day14_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_solv1;
        private System.Windows.Forms.Label lbl_part1;
        private System.Windows.Forms.Label lbl_part1answer;
        private System.Windows.Forms.Label lbl_part2;
        private System.Windows.Forms.Button btn_solv2;
        private System.Windows.Forms.Label lbl_part2answer;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ListBox lb_input;
        private System.Windows.Forms.Label label2;
    }
}
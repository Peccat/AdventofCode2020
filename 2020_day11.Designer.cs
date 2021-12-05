
namespace AdventOfCode2020
{
    partial class _2020_day11
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
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_part2answer = new System.Windows.Forms.Label();
            this.lbl_part2 = new System.Windows.Forms.Label();
            this.lbl_part1answer = new System.Windows.Forms.Label();
            this.lbl_part1 = new System.Windows.Forms.Label();
            this.btn_solv1 = new System.Windows.Forms.Button();
            this.btn_solv2 = new System.Windows.Forms.Button();
            this.lb_input = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(241, 415);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_part2answer
            // 
            this.lbl_part2answer.Location = new System.Drawing.Point(13, 365);
            this.lbl_part2answer.Name = "lbl_part2answer";
            this.lbl_part2answer.Size = new System.Drawing.Size(526, 23);
            this.lbl_part2answer.TabIndex = 1;
            this.lbl_part2answer.Text = " ";
            // 
            // lbl_part2
            // 
            this.lbl_part2.Location = new System.Drawing.Point(13, 190);
            this.lbl_part2.Name = "lbl_part2";
            this.lbl_part2.Size = new System.Drawing.Size(526, 146);
            this.lbl_part2.TabIndex = 2;
            this.lbl_part2.Text = " ";
            // 
            // lbl_part1answer
            // 
            this.lbl_part1answer.Location = new System.Drawing.Point(13, 167);
            this.lbl_part1answer.Name = "lbl_part1answer";
            this.lbl_part1answer.Size = new System.Drawing.Size(526, 23);
            this.lbl_part1answer.TabIndex = 3;
            this.lbl_part1answer.Text = " ";
            // 
            // lbl_part1
            // 
            this.lbl_part1.Location = new System.Drawing.Point(13, 13);
            this.lbl_part1.Name = "lbl_part1";
            this.lbl_part1.Size = new System.Drawing.Size(526, 111);
            this.lbl_part1.TabIndex = 4;
            this.lbl_part1.Text = " ";
            // 
            // btn_solv1
            // 
            this.btn_solv1.Location = new System.Drawing.Point(241, 127);
            this.btn_solv1.Name = "btn_solv1";
            this.btn_solv1.Size = new System.Drawing.Size(75, 23);
            this.btn_solv1.TabIndex = 5;
            this.btn_solv1.Text = "Solving";
            this.btn_solv1.UseVisualStyleBackColor = true;
            this.btn_solv1.Click += new System.EventHandler(this.btn_solv1_Click);
            // 
            // btn_solv2
            // 
            this.btn_solv2.Location = new System.Drawing.Point(241, 339);
            this.btn_solv2.Name = "btn_solv2";
            this.btn_solv2.Size = new System.Drawing.Size(75, 23);
            this.btn_solv2.TabIndex = 6;
            this.btn_solv2.Text = "Solving";
            this.btn_solv2.UseVisualStyleBackColor = true;
            this.btn_solv2.Click += new System.EventHandler(this.btn_solv2_Click);
            // 
            // lb_input
            // 
            this.lb_input.FormattingEnabled = true;
            this.lb_input.Location = new System.Drawing.Point(545, 33);
            this.lb_input.Name = "lb_input";
            this.lb_input.Size = new System.Drawing.Size(406, 407);
            this.lb_input.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Input:";
            // 
            // _2020_day11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_input);
            this.Controls.Add(this.btn_solv2);
            this.Controls.Add(this.btn_solv1);
            this.Controls.Add(this.lbl_part1);
            this.Controls.Add(this.lbl_part1answer);
            this.Controls.Add(this.lbl_part2);
            this.Controls.Add(this.lbl_part2answer);
            this.Controls.Add(this.btn_back);
            this.Name = "_2020_day11";
            this.Text = "_2020_day11";
            this.Load += new System.EventHandler(this._2020_day11_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_part2answer;
        private System.Windows.Forms.Label lbl_part2;
        private System.Windows.Forms.Label lbl_part1answer;
        private System.Windows.Forms.Label lbl_part1;
        private System.Windows.Forms.Button btn_solv1;
        private System.Windows.Forms.Button btn_solv2;
        private System.Windows.Forms.ListBox lb_input;
        private System.Windows.Forms.Label label5;
    }
}
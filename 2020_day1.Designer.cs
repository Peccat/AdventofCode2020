﻿
namespace AdventOfCode2020
{
    partial class _2020_day1
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
            this.lbl_task = new System.Windows.Forms.Label();
            this.btn_solv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_input = new System.Windows.Forms.ListBox();
            this.lbl_answer = new System.Windows.Forms.Label();
            this.lbl_part2 = new System.Windows.Forms.Label();
            this.btn_solv2 = new System.Windows.Forms.Button();
            this.lbl_part2_answer = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_task
            // 
            this.lbl_task.Location = new System.Drawing.Point(13, 13);
            this.lbl_task.Name = "lbl_task";
            this.lbl_task.Size = new System.Drawing.Size(584, 88);
            this.lbl_task.TabIndex = 0;
            this.lbl_task.Text = " ";
            // 
            // btn_solv
            // 
            this.btn_solv.Location = new System.Drawing.Point(222, 105);
            this.btn_solv.Name = "btn_solv";
            this.btn_solv.Size = new System.Drawing.Size(75, 23);
            this.btn_solv.TabIndex = 1;
            this.btn_solv.Text = "Solving";
            this.btn_solv.UseVisualStyleBackColor = true;
            this.btn_solv.Click += new System.EventHandler(this.btn_solv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input:";
            // 
            // lb_input
            // 
            this.lb_input.FormattingEnabled = true;
            this.lb_input.Location = new System.Drawing.Point(13, 122);
            this.lb_input.Name = "lb_input";
            this.lb_input.Size = new System.Drawing.Size(60, 186);
            this.lb_input.TabIndex = 3;
            // 
            // lbl_answer
            // 
            this.lbl_answer.Location = new System.Drawing.Point(107, 143);
            this.lbl_answer.Name = "lbl_answer";
            this.lbl_answer.Size = new System.Drawing.Size(490, 25);
            this.lbl_answer.TabIndex = 4;
            this.lbl_answer.Text = " ";
            // 
            // lbl_part2
            // 
            this.lbl_part2.Location = new System.Drawing.Point(107, 168);
            this.lbl_part2.Name = "lbl_part2";
            this.lbl_part2.Size = new System.Drawing.Size(487, 67);
            this.lbl_part2.TabIndex = 5;
            this.lbl_part2.Text = " ";
            // 
            // btn_solv2
            // 
            this.btn_solv2.Location = new System.Drawing.Point(222, 238);
            this.btn_solv2.Name = "btn_solv2";
            this.btn_solv2.Size = new System.Drawing.Size(75, 23);
            this.btn_solv2.TabIndex = 6;
            this.btn_solv2.Text = "Solving";
            this.btn_solv2.UseVisualStyleBackColor = true;
            this.btn_solv2.Click += new System.EventHandler(this.btn_solv2_Click);
            // 
            // lbl_part2_answer
            // 
            this.lbl_part2_answer.Location = new System.Drawing.Point(110, 272);
            this.lbl_part2_answer.Name = "lbl_part2_answer";
            this.lbl_part2_answer.Size = new System.Drawing.Size(484, 36);
            this.lbl_part2_answer.TabIndex = 7;
            this.lbl_part2_answer.Text = " ";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(222, 321);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // _2020_day1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 356);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_part2_answer);
            this.Controls.Add(this.btn_solv2);
            this.Controls.Add(this.lbl_part2);
            this.Controls.Add(this.lbl_answer);
            this.Controls.Add(this.lb_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_solv);
            this.Controls.Add(this.lbl_task);
            this.Name = "_2020_day1";
            this.Text = "_2020_day1";
            this.Load += new System.EventHandler(this._2020_day1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_task;
        private System.Windows.Forms.Button btn_solv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_input;
        private System.Windows.Forms.Label lbl_answer;
        private System.Windows.Forms.Label lbl_part2;
        private System.Windows.Forms.Button btn_solv2;
        private System.Windows.Forms.Label lbl_part2_answer;
        private System.Windows.Forms.Button btn_back;
    }
}
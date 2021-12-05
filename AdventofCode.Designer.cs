
namespace AdventOfCode2020
{
    partial class AdventofCode
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_2019 = new System.Windows.Forms.Button();
            this.btn_2018 = new System.Windows.Forms.Button();
            this.btn_2017 = new System.Windows.Forms.Button();
            this.btn_2016 = new System.Windows.Forms.Button();
            this.btn_2015 = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Story";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "2020";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_2019
            // 
            this.btn_2019.Location = new System.Drawing.Point(94, 73);
            this.btn_2019.Name = "btn_2019";
            this.btn_2019.Size = new System.Drawing.Size(75, 23);
            this.btn_2019.TabIndex = 2;
            this.btn_2019.Text = "2019";
            this.btn_2019.UseVisualStyleBackColor = true;
            this.btn_2019.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_2018
            // 
            this.btn_2018.Location = new System.Drawing.Point(175, 73);
            this.btn_2018.Name = "btn_2018";
            this.btn_2018.Size = new System.Drawing.Size(75, 23);
            this.btn_2018.TabIndex = 3;
            this.btn_2018.Text = "2018";
            this.btn_2018.UseVisualStyleBackColor = true;
            this.btn_2018.Click += new System.EventHandler(this.btn_2018_Click);
            // 
            // btn_2017
            // 
            this.btn_2017.Location = new System.Drawing.Point(13, 112);
            this.btn_2017.Name = "btn_2017";
            this.btn_2017.Size = new System.Drawing.Size(75, 23);
            this.btn_2017.TabIndex = 4;
            this.btn_2017.Text = "2017";
            this.btn_2017.UseVisualStyleBackColor = true;
            this.btn_2017.Click += new System.EventHandler(this.btn_2017_Click);
            // 
            // btn_2016
            // 
            this.btn_2016.Location = new System.Drawing.Point(94, 112);
            this.btn_2016.Name = "btn_2016";
            this.btn_2016.Size = new System.Drawing.Size(75, 23);
            this.btn_2016.TabIndex = 5;
            this.btn_2016.Text = "2016";
            this.btn_2016.UseVisualStyleBackColor = true;
            this.btn_2016.Click += new System.EventHandler(this.btn_2016_Click);
            // 
            // btn_2015
            // 
            this.btn_2015.Location = new System.Drawing.Point(175, 112);
            this.btn_2015.Name = "btn_2015";
            this.btn_2015.Size = new System.Drawing.Size(75, 23);
            this.btn_2015.TabIndex = 6;
            this.btn_2015.Text = "2015";
            this.btn_2015.UseVisualStyleBackColor = true;
            this.btn_2015.Click += new System.EventHandler(this.btn_2015_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(94, 183);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // AdventofCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 268);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_2015);
            this.Controls.Add(this.btn_2016);
            this.Controls.Add(this.btn_2017);
            this.Controls.Add(this.btn_2018);
            this.Controls.Add(this.btn_2019);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AdventofCode";
            this.Text = "AdventofCode";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_2019;
        private System.Windows.Forms.Button btn_2018;
        private System.Windows.Forms.Button btn_2017;
        private System.Windows.Forms.Button btn_2016;
        private System.Windows.Forms.Button btn_2015;
        private System.Windows.Forms.Button btn_close;
    }
}
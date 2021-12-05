
namespace AdventOfCode2020
{
    partial class Form1
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
            this.btn_2020_1 = new System.Windows.Forms.Button();
            this.btn_2020 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_2020_1
            // 
            this.btn_2020_1.Location = new System.Drawing.Point(12, 49);
            this.btn_2020_1.Name = "btn_2020_1";
            this.btn_2020_1.Size = new System.Drawing.Size(75, 23);
            this.btn_2020_1.TabIndex = 0;
            this.btn_2020_1.Text = "1";
            this.btn_2020_1.UseVisualStyleBackColor = true;
            this.btn_2020_1.Click += new System.EventHandler(this.btn_2020_1_Click);
            // 
            // btn_2020
            // 
            this.btn_2020.Location = new System.Drawing.Point(12, 13);
            this.btn_2020.Name = "btn_2020";
            this.btn_2020.Size = new System.Drawing.Size(75, 23);
            this.btn_2020.TabIndex = 1;
            this.btn_2020.Text = "2020";
            this.btn_2020.UseVisualStyleBackColor = true;
            this.btn_2020.Click += new System.EventHandler(this.btn_2020_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_2020);
            this.Controls.Add(this.btn_2020_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_2020_1;
        private System.Windows.Forms.Button btn_2020;
    }
}


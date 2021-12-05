
namespace AdventOfCode2020
{
    partial class story
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
            this.lbl_story = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_story
            // 
            this.lbl_story.Location = new System.Drawing.Point(13, 13);
            this.lbl_story.Name = "lbl_story";
            this.lbl_story.Size = new System.Drawing.Size(350, 350);
            this.lbl_story.TabIndex = 0;
            this.lbl_story.Text = " ";
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(151, 376);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // day_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.lbl_story);
            this.Name = "day_1";
            this.Text = "Advent of Calendar 2020";
            this.Load += new System.EventHandler(this.day_1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_story;
        private System.Windows.Forms.Button btn_OK;
    }
}
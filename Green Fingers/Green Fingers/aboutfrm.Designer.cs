namespace Green_Fingers
{
    partial class aboutfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutfrm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OkBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblVer = new System.Windows.Forms.Label();
            this.linkLalLinkedin = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Green_Fingers.Properties.Resources.leaf;
            this.pictureBox1.Location = new System.Drawing.Point(99, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // OkBtn
            // 
            this.OkBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkBtn.Location = new System.Drawing.Point(99, 182);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 1;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Green Fingers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "By Matthew Utin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "2015 - 2016";
            // 
            // LblVer
            // 
            this.LblVer.AutoSize = true;
            this.LblVer.Location = new System.Drawing.Point(98, 116);
            this.LblVer.Name = "LblVer";
            this.LblVer.Size = new System.Drawing.Size(113, 13);
            this.LblVer.TabIndex = 5;
            this.LblVer.Text = "Version: {0}.{1}.{2}.{3}";
            // 
            // linkLalLinkedin
            // 
            this.linkLalLinkedin.AutoSize = true;
            this.linkLalLinkedin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLalLinkedin.Location = new System.Drawing.Point(50, 153);
            this.linkLalLinkedin.Name = "linkLalLinkedin";
            this.linkLalLinkedin.Size = new System.Drawing.Size(192, 13);
            this.linkLalLinkedin.TabIndex = 6;
            this.linkLalLinkedin.TabStop = true;
            this.linkLalLinkedin.Text = "https://uk.linkedin.com/in/matthewutin";
            this.linkLalLinkedin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLalLinkedin_LinkClicked);
            // 
            // aboutfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(283, 216);
            this.Controls.Add(this.linkLalLinkedin);
            this.Controls.Add(this.LblVer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "aboutfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.aboutfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblVer;
        private System.Windows.Forms.LinkLabel linkLalLinkedin;
    }
}
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
            this.OkBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblVer = new System.Windows.Forms.Label();
            this.linkLalLinkedin = new System.Windows.Forms.LinkLabel();
            this.FrmWindowBar = new System.Windows.Forms.Panel();
            this.frmWindowTitleText = new System.Windows.Forms.Label();
            this.FrmExitBtnlbl = new System.Windows.Forms.Label();
            this.IconFrmTitleBar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FrmWindowBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconFrmTitleBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkBtn.Location = new System.Drawing.Point(99, 223);
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
            this.label1.Location = new System.Drawing.Point(101, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Green Fingers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "By Matthew Utin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "2015 - 2016";
            // 
            // LblVer
            // 
            this.LblVer.AutoSize = true;
            this.LblVer.Location = new System.Drawing.Point(98, 157);
            this.LblVer.Name = "LblVer";
            this.LblVer.Size = new System.Drawing.Size(113, 13);
            this.LblVer.TabIndex = 5;
            this.LblVer.Text = "Version: {0}.{1}.{2}.{3}";
            // 
            // linkLalLinkedin
            // 
            this.linkLalLinkedin.AutoSize = true;
            this.linkLalLinkedin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLalLinkedin.Location = new System.Drawing.Point(50, 194);
            this.linkLalLinkedin.Name = "linkLalLinkedin";
            this.linkLalLinkedin.Size = new System.Drawing.Size(192, 13);
            this.linkLalLinkedin.TabIndex = 6;
            this.linkLalLinkedin.TabStop = true;
            this.linkLalLinkedin.Text = "https://uk.linkedin.com/in/matthewutin";
            this.linkLalLinkedin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLalLinkedin_LinkClicked);
            // 
            // FrmWindowBar
            // 
            this.FrmWindowBar.BackColor = System.Drawing.Color.PaleGreen;
            this.FrmWindowBar.Controls.Add(this.frmWindowTitleText);
            this.FrmWindowBar.Controls.Add(this.IconFrmTitleBar);
            this.FrmWindowBar.Controls.Add(this.FrmExitBtnlbl);
            this.FrmWindowBar.Location = new System.Drawing.Point(0, 0);
            this.FrmWindowBar.Name = "FrmWindowBar";
            this.FrmWindowBar.Size = new System.Drawing.Size(290, 30);
            this.FrmWindowBar.TabIndex = 7;
            this.FrmWindowBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmWindowBar_MouseDown);
            // 
            // frmWindowTitleText
            // 
            this.frmWindowTitleText.AutoSize = true;
            this.frmWindowTitleText.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmWindowTitleText.Location = new System.Drawing.Point(33, 10);
            this.frmWindowTitleText.Name = "frmWindowTitleText";
            this.frmWindowTitleText.Size = new System.Drawing.Size(123, 15);
            this.frmWindowTitleText.TabIndex = 17;
            this.frmWindowTitleText.Text = "Green Fingers V1.5";
            this.frmWindowTitleText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmWindowTitleText_MouseDown);
            // 
            // FrmExitBtnlbl
            // 
            this.FrmExitBtnlbl.AutoSize = true;
            this.FrmExitBtnlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrmExitBtnlbl.Location = new System.Drawing.Point(263, 7);
            this.FrmExitBtnlbl.Name = "FrmExitBtnlbl";
            this.FrmExitBtnlbl.Size = new System.Drawing.Size(18, 18);
            this.FrmExitBtnlbl.TabIndex = 17;
            this.FrmExitBtnlbl.Text = "X";
            this.FrmExitBtnlbl.Click += new System.EventHandler(this.FrmExitBtnlbl_Click);
            this.FrmExitBtnlbl.MouseLeave += new System.EventHandler(this.FrmExitBtnlbl_MouseLeave);
            this.FrmExitBtnlbl.MouseHover += new System.EventHandler(this.FrmExitBtnlbl_MouseHover);
            // 
            // IconFrmTitleBar
            // 
            this.IconFrmTitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IconFrmTitleBar.Image = global::Green_Fingers.Properties.Resources.leaf;
            this.IconFrmTitleBar.Location = new System.Drawing.Point(-4, 2);
            this.IconFrmTitleBar.Name = "IconFrmTitleBar";
            this.IconFrmTitleBar.Size = new System.Drawing.Size(31, 32);
            this.IconFrmTitleBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconFrmTitleBar.TabIndex = 17;
            this.IconFrmTitleBar.TabStop = false;
            this.IconFrmTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IconFrmTitleBar_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Green_Fingers.Properties.Resources.leaf;
            this.pictureBox1.Location = new System.Drawing.Point(99, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // aboutfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(288, 264);
            this.Controls.Add(this.FrmWindowBar);
            this.Controls.Add(this.linkLalLinkedin);
            this.Controls.Add(this.LblVer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "aboutfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.aboutfrm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.aboutfrm_MouseDown);
            this.FrmWindowBar.ResumeLayout(false);
            this.FrmWindowBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconFrmTitleBar)).EndInit();
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
        private System.Windows.Forms.Panel FrmWindowBar;
        private System.Windows.Forms.Label frmWindowTitleText;
        private System.Windows.Forms.PictureBox IconFrmTitleBar;
        private System.Windows.Forms.Label FrmExitBtnlbl;
    }
}
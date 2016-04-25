using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Green_Fingers
{
    public partial class aboutfrm : Form
    {
        /*
         * Created By Matthew Utin. https://github.com/mattu08/Green-Fingers/
        */
        public aboutfrm()
        {
            InitializeComponent();
            //Load rounded boreder----START-----
            Region = System.Drawing.Region.FromHrgn(ThemeGUIClass.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //-----END-----
        }

        private void aboutfrm_Load(object sender, EventArgs e)
        {
            Version GfVersion = Assembly.GetExecutingAssembly().GetName().Version;
            this.LblVer.Text = String.Format(this.LblVer.Text, GfVersion.Major, GfVersion.Minor, GfVersion.Build, GfVersion.Revision);
        }

        private void OkBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLalLinkedin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://uk.linkedin.com/in/matthewutin");
        }

        private void IconFrmTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ThemeGUIClass.ReleaseCapture();
            ThemeGUIClass.SendMessage(this.Handle, ThemeGUIClass.WM_NCLBUTTONDOWN, ThemeGUIClass.HT_CAPTION, 0);
        }

        private void frmWindowTitleText_MouseDown(object sender, MouseEventArgs e)
        {
            ThemeGUIClass.ReleaseCapture();
            ThemeGUIClass.SendMessage(this.Handle, ThemeGUIClass.WM_NCLBUTTONDOWN, ThemeGUIClass.HT_CAPTION, 0);
        }

        private void FrmWindowBar_MouseDown(object sender, MouseEventArgs e)
        {
            ThemeGUIClass.ReleaseCapture();
            ThemeGUIClass.SendMessage(this.Handle, ThemeGUIClass.WM_NCLBUTTONDOWN, ThemeGUIClass.HT_CAPTION, 0);
        }

        private void aboutfrm_MouseDown(object sender, MouseEventArgs e)
        {
            ThemeGUIClass.ReleaseCapture();
            ThemeGUIClass.SendMessage(this.Handle, ThemeGUIClass.WM_NCLBUTTONDOWN, ThemeGUIClass.HT_CAPTION, 0);
        }

        private void FrmExitBtnlbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmExitBtnlbl_MouseHover(object sender, EventArgs e)
        {
            FrmExitBtnlbl.ForeColor = Color.Red;
        }

        private void FrmExitBtnlbl_MouseLeave(object sender, EventArgs e)
        {
            FrmExitBtnlbl.ForeColor = Color.Black;
        }
    }
}

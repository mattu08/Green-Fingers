using System;
using System.Reflection;
using System.Windows.Forms;

namespace Green_Fingers
{
    public partial class aboutfrm : Form
    {
        public aboutfrm()
        {
            InitializeComponent();
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
    }
}

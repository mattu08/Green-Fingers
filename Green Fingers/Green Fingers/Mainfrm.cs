using System;
using System.Drawing;
using System.Windows.Forms;

namespace Green_Fingers
{
    public partial class Mainfrm : Form
    {
        /// <summary>
        /// Created By Matthew Utin. https://github.com/mattu08/Green-Fingers/
        /// </summary>

        #region Set Vars
        public String S_Id;
        public String Plant_Name;
        public String Sow_In;
        public String Sow_Un;
        public String Sow_Out;
        public String Plant_Out;
        public String Har_Time;
        public String Notes;
        public String Plt_Num;
        public String Get_SQL_List_Var;
        public String lstToTxt;
        public Icon ico;
        //minamize button--start--
        private delegate void EventHandler(object sender, EventArgs e);
        private event EventHandler MinButtonClick;
        //--end--
        #endregion

        public Mainfrm()
        {
            try
            {
                LoadSetRegistryClass lsr = new LoadSetRegistryClass();
                lsr.chkRegAct();
                lsr.chkRegSysT();
                chkfiles();
                InitializeComponent();
                //Load rounded boreder----START-----
                Region = System.Drawing.Region.FromHrgn(ThemeGUIClass.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
                //-----END-----
            }
            catch (SystemException)
            {
                MessageBox.Show("Something is seriously wrong, must close!", "Green Fingers Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void Mainfrm_Load(object sender, EventArgs e)
        {
            LoadSetRegistryClass lsr = new LoadSetRegistryClass();
            LoadSetRegistryClass.RegGetSysTVel(this);
            lsr.chkRegRun();
            LoadSetRegistryClass.RegGetReminderVel(this);
            SQLToXMLDataOutputClass.xmlRefeshlst(this);
            this.greenFingersTableAdapter.Fill(this.greenFingersDBDataSet.GreenFingers);
            nfyIGf.Visible = true;
            ico = nfyIGf.Icon;
        }

        private void chkfiles()
        {
            if (System.IO.File.Exists(@"GreenFingersDB.mdf")) { }
            else { MessageBox.Show("GreenFingersDB.mdf Database file is missing! Creating a new one, restart Green Fingers after it has closed.", "Green Fingers Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); CreateNewDatabaseClass.ExtDB(this); this.Close(); }

            if (System.IO.File.Exists(@"Resources\SavedReminders.xml")) { }
            else { MessageBox.Show("Resources/SavedReminders.xml is missing! Creating a new one, restart Green Fingers after it has closed.", "Green Fingers Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); SQLToXMLDataOutputClass.makeNewXmlFile(this); this.Close(); }
        }

        private void ExitMnu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutMnu_Click(object sender, EventArgs e)
        {
            aboutfrm AboutForm = new aboutfrm();
            AboutForm.Show();
        }

        private void greenFingersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.greenFingersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.greenFingersDBDataSet);
        }

        public void LstbLoadInSQL_SelectedIndexChanged(object sender, EventArgs e)
        {
            Get_SQL_List_Var = LstbLoadInSQL.GetItemText(LstbLoadInSQL.SelectedItem);
            TxtBSQL.Text = Get_SQL_List_Var;
            SQLDataBaseConnectAndCollectClass.ExtGetDB(this);
        }

        public void btnActivate_Click(object sender, EventArgs e)
        {
            LoadSetRegistryClass.RegActavate(this);
            DatePopupClass open = new DatePopupClass();
            open.Datechecker();
        }

        public void btnDeactivate_Click(object sender, EventArgs e)
        {
            LoadSetRegistryClass.RegDeactivate(this);
        }

        private void BtnSendToSQL_Click(object sender, EventArgs e)
        {
            SQLToXMLDataOutputClass.SQLOutputToXML(this);
        }

        private void delReminder_Click(object sender, EventArgs e)
        {
            SQLToXMLDataOutputClass.DelXML(this);
        }

        private void btnClrXml_Click(object sender, EventArgs e)
        {
            SQLToXMLDataOutputClass.makeNewXmlFile(this);
        }

        private void LstbLoadInSQL_MouseHover(object sender, EventArgs e)
        {
            tTipPlantsInDataBase.SetToolTip(LstbLoadInSQL, "Click on the plant, you would like to send to reminders.");
        }

        private void btnActivate_MouseHover(object sender, EventArgs e)
        {
            tTipActivateReminders.SetToolTip(btnActivate, "Click on this button to activate or deactivate the reminders below.");
        }

        private void btnHideInSysTray_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = true;
            ShowInTaskbar = true;
            Opacity = 100;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutfrm AboutForm = new aboutfrm();
            AboutForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nfyIGf_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Visible = true;
            ShowInTaskbar = true;
            Opacity = 100;
        }
        #region Form GUI Code
        private void frmWindowBar_MouseDown(object sender, MouseEventArgs e)
        {
            ThemeGUIClass.ReleaseCapture();
            ThemeGUIClass.SendMessage(this.Handle, ThemeGUIClass.WM_NCLBUTTONDOWN, ThemeGUIClass.HT_CAPTION, 0);
        }

        private void Mainfrm_MouseDown(object sender, MouseEventArgs e)
        {
            ThemeGUIClass.ReleaseCapture();
            ThemeGUIClass.SendMessage(this.Handle, ThemeGUIClass.WM_NCLBUTTONDOWN, ThemeGUIClass.HT_CAPTION, 0);
        }

        private void tabPage2_MouseDown(object sender, MouseEventArgs e)
        {
            ThemeGUIClass.ReleaseCapture();
            ThemeGUIClass.SendMessage(this.Handle, ThemeGUIClass.WM_NCLBUTTONDOWN, ThemeGUIClass.HT_CAPTION, 0);
        }

        private void tabOviewPage_MouseDown_1(object sender, MouseEventArgs e)
        {
            ThemeGUIClass.ReleaseCapture();
            ThemeGUIClass.SendMessage(this.Handle, ThemeGUIClass.WM_NCLBUTTONDOWN, ThemeGUIClass.HT_CAPTION, 0);
        }

        private void lblDatabaseInfo2_MouseDown(object sender, MouseEventArgs e)
        {
            ThemeGUIClass.ReleaseCapture();
            ThemeGUIClass.SendMessage(this.Handle, ThemeGUIClass.WM_NCLBUTTONDOWN, ThemeGUIClass.HT_CAPTION, 0);
        }

        private void lblDatabaseInfo1_MouseDown(object sender, MouseEventArgs e)
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

        private void FrmMinimizeBtnlbl_Click(object sender, EventArgs e)
        {
            if (MinButtonClick != null)
                MinButtonClick.Invoke(this, e);
            WindowState = FormWindowState.Minimized;
        }

        private void FrmMinimizeBtnlbl_MouseHover(object sender, EventArgs e)
        {
            FrmMinimizeBtnlbl.ForeColor = Color.Blue;
        }

        private void FrmMinimizeBtnlbl_MouseLeave(object sender, EventArgs e)
        {
            FrmMinimizeBtnlbl.ForeColor = Color.Black;
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
        #endregion
    }
}
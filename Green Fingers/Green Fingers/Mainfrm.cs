using System;
using System.Drawing;
using System.Windows.Forms;

namespace Green_Fingers
{
    public partial class Mainfrm : Form
    {
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

        public Mainfrm()
        {
            try
            {
                LoadSetRegistryClass lsr = new LoadSetRegistryClass();
                lsr.chkRegAct();
                lsr.chkRegSysT();
                chkfiles();
                InitializeComponent();
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
            else { MessageBox.Show("GreenFingersDB.mdf Database file is missing!", "Green Fingers Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); }

            if (System.IO.File.Exists(@"Resources\SavedReminders.xml")) { }
            else { MessageBox.Show("Resources/SavedReminders.xml is missing! Creating a new one, restarting Green Fingers.", "Green Fingers Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); SQLToXMLDataOutputClass.makeNewXmlFile(this); this.Close(); }
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
    }
}
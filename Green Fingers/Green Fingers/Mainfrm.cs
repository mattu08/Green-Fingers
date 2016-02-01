using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.IO;
using Microsoft.Win32;
using Green_Fingers.Properties;
using System.Reflection;
using System.Xml;
using System.Xml.XPath;

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
        public static readonly String GFRegAct = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\GreenFingers\AppSettings", "ReminderSet", null);
        public static readonly String GFRegSysTray = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\GreenFingers\AppSettings", "StartInSystemTray", null);
        public static readonly String GFRegRunAtStartUp = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Run", "GreenFinger", null);
        public Icon ico;

        public Mainfrm()
        {
            try
            {
                chkfiles();
                chkRegAct();
                chkRegSysT();
                InitializeComponent();
            }
            catch (SystemException e)
            {
                MessageBox.Show("Something is seriously wrong, must close!", "Green Fingers Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void Mainfrm_Load(object sender, EventArgs e)
        {
            RegGetSysTVel();
            chkRegRun();
            RegGetReminderVel();
            xmlRefeshlst();
            this.greenFingersTableAdapter.Fill(this.greenFingersDBDataSet.GreenFingers);
            //nfyIGf = new System.Windows.Forms.NotifyIcon(components);
            nfyIGf.Visible = true;
            ico = nfyIGf.Icon;
        }

        private void chkRegAct()
        {
            if (GFRegAct == null)
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\GreenFingers\AppSettings");

                //storing the values  
                key.SetValue("ReminderSet", "0");
                key.Close();
            }
        }

        private void chkRegSysT()
        {
            if (GFRegSysTray == null)
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\GreenFingers\AppSettings");

                //storing the values  
                key.SetValue("StartInSystemTray", "0");
                key.Close();
            }
        }

        private void chkRegRun()
        {
            if (GFRegRunAtStartUp == null)
            {
                string Gfdirectory = AppDomain.CurrentDomain.BaseDirectory.ToString();
                string GfName = "GreenFinger.exe";
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                key.SetValue("GreenFinger", Gfdirectory + GfName);
                key.Close();
            }
        }

        public void RegGetSysTVel()
        {
            RegistryKey myKeys = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\GreenFingers\AppSettings", false);
            {
                String values = (String)myKeys.GetValue("StartInSystemTray");

                if (values == "1")
                {
                    Visible = false;
                    ShowInTaskbar = false;
                    Opacity = 0;
                }
            }
        }

        public void RegGetReminderVel()
        {
            RegistryKey myKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\GreenFingers\AppSettings", false);
            {
                String value = (String)myKey.GetValue("ReminderSet");

                if (value == "0")
                {
                    this.btnActivate.Visible = true;
                }

                if (value == "1")
                {
                    this.btnDeactivate.Visible = true;
                    DatePopupClass open = new DatePopupClass();
                    open.Datechecker();
                }
            }
        }

        private void chkfiles()
        {
            if (System.IO.File.Exists(@"GreenFingersDB.mdf")) { }
            else { MessageBox.Show("GreenFingersDB.mdf Database file is missing!", "Green Fingers Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); }

            if (System.IO.File.Exists(@"Resources\SavedReminders.xml")) { }
            else { MessageBox.Show("Resources/SavedReminders.xml is missing! Creating a new one, restarting Green Fingers.", "Green Fingers Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); makeNewXmlFile(); this.Close(); }
        }

        public void ExtGetDB()
        {

            string ConString = Properties.Settings.Default.GreenFingersDBConn;

            try
            {
                using (SqlConnection Conn = new SqlConnection(ConString))
                {

                    string strGf = "SELECT * FROM GreenFingers WHERE [Plant Name] = @List_Var";
                    SqlCommand SqlCmd = new SqlCommand(strGf, Conn);
                    SqlCmd.Parameters.AddWithValue("@List_Var", Get_SQL_List_Var);
                    Conn.Open();

                    SqlDataReader GfReader = SqlCmd.ExecuteReader();

                    if (GfReader.HasRows)
                    {
                        while (GfReader.Read())
                        {
                            if (GfReader["ID"] == null) { S_Id = "N/A"; }
                            else { S_Id = GfReader["ID"].ToString(); }

                            if (GfReader["Plant Name"] == null) { Plant_Name = "N/A"; }
                            else { Plant_Name = GfReader["Plant Name"].ToString(); }

                            if (GfReader["Sow Indoors"] == null) { Sow_In = "N/A"; }
                            else { Sow_In = GfReader["Sow Indoors"].ToString(); }

                            if (GfReader["Sow Under Cover"] == null) { Sow_Un = "N/A"; }
                            else { Sow_Un = GfReader["Sow Under Cover"].ToString(); }

                            if (GfReader["Sow Outdoors"] == null) { Sow_Out = "N/A"; }
                            else { Sow_Out = GfReader["Sow Outdoors"].ToString(); }

                            if (GfReader["Plant Out"] == null) { Plant_Out = "N/A"; }
                            else { Plant_Out = GfReader["Plant Out"].ToString(); }

                            if (GfReader["Harvest Time"] == null) { Har_Time = "N/A"; }
                            else { Har_Time = GfReader["Harvest Time"].ToString(); }

                            if (GfReader["Notes"] == null) { Notes = "N/A"; }
                            else { Notes = GfReader["Notes"].ToString(); }

                            if (GfReader["Plot Number/Name"] == null) { Plt_Num = "N/A"; }
                            else { Plt_Num = GfReader["Plot Number/Name"].ToString(); }

                            //int x = Int32.Parse(mo);
                            //Console.WriteLine(x);
                        }

                    }
                    else
                    {
                        //Console.WriteLine("No Rows found.");
                    }
                    GfReader.Close();
                    Conn.Close();
                }

            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                System.Windows.Forms.MessageBox.Show(sqlException.Message);
            }
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

        private void LstbLoadInSQL_SelectedIndexChanged(object sender, EventArgs e)
        {
            Get_SQL_List_Var = LstbLoadInSQL.GetItemText(LstbLoadInSQL.SelectedItem);
            TxtBSQL.Text = Get_SQL_List_Var;
            ExtGetDB();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\GreenFingers\AppSettings");
            //storing the values  
            key.SetValue("ReminderSet", "1");
            key.Close();

            RegistryKey keys = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\GreenFingers\AppSettings");
            //storing the values  
            keys.SetValue("StartInSystemTray", "1");
            keys.Close();

            btnActivate.Visible = false;
            btnActivate.Enabled = false;
            btnDeactivate.Visible = true;
            btnDeactivate.Enabled = true;
            DatePopupClass open = new DatePopupClass();
            open.Datechecker();
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\GreenFingers\AppSettings");
            //storing the values  
            key.SetValue("ReminderSet", "0");
            key.Close();

            RegistryKey keys = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\GreenFingers\AppSettings");
            //storing the values  
            keys.SetValue("StartInSystemTray", "0");
            keys.Close();

            btnDeactivate.Visible = false;
            btnDeactivate.Enabled = false;
            btnActivate.Visible = true;
            btnActivate.Enabled = true;
        }

        private void BtnSendToSQL_Click(object sender, EventArgs e)
        {
            if (Plant_Name == null)
                {
                    MessageBox.Show("Select a plant! Or if you do not see anything to select add a plant to the database.", "Green Fingers", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XDocument xdoc = XDocument.Load(@"Resources\SavedReminders.xml");
                    XElement root = new XElement("Reminder");
                    root.Add(new XElement("PlantName", Plant_Name));
                    root.Add(new XElement("SowInDoorsDate", Sow_In));
                    root.Add(new XElement("SowUnderCoverDate", Sow_Un));
                    root.Add(new XElement("SowOutDoorsDate", Sow_Out));
                    root.Add(new XElement("PlantOutDoors", Plant_Out));
                    root.Add(new XElement("HarvestTimeDate", Har_Time));
                    root.Add(new XElement("Notes", Notes));
                    root.Add(new XElement("PlotNumber", Plt_Num));
                    xdoc.Element("Reminders").Add(root);
                    xdoc.Save("Resources\\SavedReminders.xml");
                    xmlRefeshlst();
                }
        }

        private void xmlRefeshlst()
        {
            lstVxmlin.Items.Clear();
            XDocument doc = XDocument.Load("Resources\\SavedReminders.xml");

            foreach (var dm in doc.Descendants("Reminder"))
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    dm.Element("PlantName").Value,
                    dm.Element("SowInDoorsDate").Value,
                    dm.Element("SowUnderCoverDate").Value,
                    dm.Element("SowOutDoorsDate").Value,
                    dm.Element("PlantOutDoors").Value,
                    dm.Element("HarvestTimeDate").Value,

                });
                if (item == null)
                {
                    MessageBox.Show("Corrupt XML file!", "Green Fingers Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                lstVxmlin.Items.Add(item);
            }
        }
       
        private void delReminder_Click(object sender, EventArgs e)
        {
            string lstIn;
            try
            {
                int intselectedindex = lstVxmlin.SelectedIndices[0];

                if (intselectedindex >= 0)
                {
                    lstIn = lstVxmlin.SelectedItems[0].ToString();
                    lstToTxt = lstVxmlin.Items[intselectedindex].Text;
                }

                XDocument xdoc = XDocument.Load("Resources\\SavedReminders.xml");
                xdoc.Descendants("Reminder")
                .Where(x => (string)x.Element("PlantName") == lstToTxt)
                .Remove();
                xdoc.Save("Resources\\SavedReminders.xml");
                xmlRefeshlst();
            }
            catch (ArgumentOutOfRangeException outOfRange) {
                MessageBox.Show("Select the plant name from the reminders list below.", "Green Fingers", MessageBoxButtons.OK, MessageBoxIcon.Information);
               outOfRange = null;
            }
        }

        private void btnClrXml_Click(object sender, EventArgs e)
        {
            makeNewXmlFile();
        }

        private void makeNewXmlFile()
        {
            System.IO.File.WriteAllText("Resources\\SavedReminders.xml", string.Empty);
            string xml = (@"<?xml version='1.0' encoding='utf-8'?>
<Reminders>
</Reminders>");
            System.IO.File.WriteAllText(@"Resources\SavedReminders.xml", xml);
            xmlRefeshlst();
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
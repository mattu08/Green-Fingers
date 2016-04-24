using System;
using System.Globalization;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Green_Fingers
{
    public class DatePopupClass : Mainfrm
    {
        public void Datechecker()
        {
            /*
             * Created By Matthew Utin. https://github.com/mattu08/Green-Fingers/
            */

            #region Load in System Date
            DateTime GrabSysDate = DateTime.Today;
            String FullDate = GrabSysDate.ToString("dd'/'MM'/'yyyy", new CultureInfo("en-GB"));
            String MoDate = GrabSysDate.ToString("dd'/'MM", new CultureInfo("en-GB"));
            /*
            Console.WriteLine(FullDate); //For testing
            Console.WriteLine(MoDate); //For testing
            */
            #endregion
            //  Load the XML file
            #region Load in XML Data
            XDocument gfdocxml = XDocument.Load("Resources\\SavedReminders.xml");
            string Pn;
            string Sidd;
            string Sucd;
            string Sodd;
            string Pod;
            string Htd;
            foreach (var desgf in gfdocxml.Descendants("Reminder"))
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    Pn = desgf.Element("PlantName").Value.ToString(),
                    Sidd = desgf.Element("SowInDoorsDate").Value.ToString(),
                    Sucd = desgf.Element("SowUnderCoverDate").Value.ToString(),
                    Sodd = desgf.Element("SowOutDoorsDate").Value.ToString(),
                    Pod = desgf.Element("PlantOutDoors").Value.ToString(),
                    Htd = desgf.Element("HarvestTimeDate").Value.ToString()

                });
                #region Start Of GreenFingers Popup checking code
                if (FullDate == Sidd || MoDate == Sidd)
                {
                    MessageBox.Show("Are ready to sow in doors! " + Sidd, "Your: " + Pn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nfyIGfDPC.BalloonTipText = "Are ready to sow in doors! " + Sidd;
                    nfyIGfDPC.BalloonTipTitle = "Your: " + Pn;
                    nfyIGfDPC.Visible = true;
                    ico = nfyIGfDPC.Icon;
                    nfyIGfDPC.BalloonTipIcon = ToolTipIcon.Info;
                    nfyIGfDPC.ShowBalloonTip(3);
                    nfyIGfDPC.Icon = null;
                    nfyIGfDPC.Visible = false;
                }

                if (FullDate == Sucd || MoDate == Sucd)
                {
                    MessageBox.Show("Are ready to sow under cover! " + Sucd, "Your: " + Pn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nfyIGfDPC.BalloonTipText = "Are ready to sow under cover! " + Sucd;
                    nfyIGfDPC.BalloonTipTitle = "Your: " + Pn;
                    nfyIGfDPC.Visible = true;
                    ico = nfyIGfDPC.Icon;
                    nfyIGfDPC.BalloonTipIcon = ToolTipIcon.Info;
                    nfyIGfDPC.ShowBalloonTip(3);
                    nfyIGfDPC.Icon = null;
                    nfyIGfDPC.Visible = false;
                }

                if (FullDate == Sodd || MoDate == Sodd)
                {
                    MessageBox.Show("Are ready to sow out doors! " + Sodd, "Your: " + Pn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nfyIGfDPC.BalloonTipText = "Are ready to sow out doors! " + Sodd;
                    nfyIGfDPC.BalloonTipTitle = "Your: " + Pn;
                    nfyIGfDPC.Visible = true;
                    ico = nfyIGfDPC.Icon;
                    nfyIGfDPC.BalloonTipIcon = ToolTipIcon.Info;
                    nfyIGfDPC.ShowBalloonTip(3);
                    nfyIGfDPC.Icon = null;
                    nfyIGfDPC.Visible = false;
                }

                if (FullDate == Pod || MoDate == Pod)
                {
                    MessageBox.Show("Are ready to plant out doors! " + Pod, "Your: " + Pn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nfyIGfDPC.BalloonTipText = "Are ready to plant out doors! " + Pod;
                    nfyIGfDPC.BalloonTipTitle = "Your: " + Pn;
                    nfyIGfDPC.Visible = true;
                    ico = nfyIGfDPC.Icon;
                    nfyIGfDPC.BalloonTipIcon = ToolTipIcon.Info;
                    nfyIGfDPC.ShowBalloonTip(3);
                    nfyIGfDPC.Icon = null;
                    nfyIGfDPC.Visible = false;
                }

                if (FullDate == Htd || MoDate == Htd)
                {
                    MessageBox.Show("Are ready for harvest congratulations! " + Htd, "Your: " + Pn, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nfyIGfDPC.BalloonTipText = "Are ready for harvest congratulations! " + Htd;
                    nfyIGfDPC.BalloonTipTitle = "Your: " + Pn;
                    nfyIGfDPC.Visible = true;
                    ico = nfyIGfDPC.Icon;
                    nfyIGfDPC.BalloonTipIcon = ToolTipIcon.Info;
                    nfyIGfDPC.ShowBalloonTip(3);
                    nfyIGfDPC.Icon = null;
                    nfyIGfDPC.Visible = false;
                }

                if (item == null)
                {
                    MessageBox.Show("Corrupt XML file!", "Green Fingers Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                #endregion
            #endregion
            }
        }
    }
}
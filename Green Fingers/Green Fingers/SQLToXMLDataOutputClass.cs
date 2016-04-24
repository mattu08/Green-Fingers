using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Green_Fingers
{
    class SQLToXMLDataOutputClass
    {
        public static void SQLOutputToXML(Mainfrm GetVar)
        {
            if (GetVar.Plant_Name == null)
            {
                MessageBox.Show("Select a plant! Or if you do not see anything to select add a plant to the database.", "Green Fingers", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XDocument xdoc = XDocument.Load(@"Resources\SavedReminders.xml");
                XElement root = new XElement("Reminder");
                root.Add(new XElement("PlantName", GetVar.Plant_Name));
                root.Add(new XElement("SowInDoorsDate", GetVar.Sow_In));
                root.Add(new XElement("SowUnderCoverDate", GetVar.Sow_Un));
                root.Add(new XElement("SowOutDoorsDate", GetVar.Sow_Out));
                root.Add(new XElement("PlantOutDoors", GetVar.Plant_Out));
                root.Add(new XElement("HarvestTimeDate", GetVar.Har_Time));
                root.Add(new XElement("Notes", GetVar.Notes));
                root.Add(new XElement("PlotNumber", GetVar.Plt_Num));
                xdoc.Element("Reminders").Add(root);
                xdoc.Save("Resources\\SavedReminders.xml");
                xmlRefeshlst(GetVar);
            }
        }

        public static void xmlRefeshlst(Mainfrm GetVar)
        {
            GetVar.lstVxmlin.Items.Clear();
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
                GetVar.lstVxmlin.Items.Add(item);
            }
        }

        public static void DelXML(Mainfrm GetVar)
        {
            string lstIn;
            try
            {
                int intselectedindex = GetVar.lstVxmlin.SelectedIndices[0];

                if (intselectedindex >= 0)
                {
                    lstIn = GetVar.lstVxmlin.SelectedItems[0].ToString();
                    GetVar.lstToTxt = GetVar.lstVxmlin.Items[intselectedindex].Text;
                }

                XDocument xdoc = XDocument.Load("Resources\\SavedReminders.xml");
                xdoc.Descendants("Reminder")
                .Where(x => (string)x.Element("PlantName") == GetVar.lstToTxt)
                .Remove();
                xdoc.Save("Resources\\SavedReminders.xml");
                xmlRefeshlst(GetVar);
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {
                MessageBox.Show("Select the plant name from the reminders list below.", "Green Fingers", MessageBoxButtons.OK, MessageBoxIcon.Information);
                outOfRange = null;
            }
        }

        public static void makeNewXmlFile(Mainfrm GetVar)
        {
            System.IO.File.WriteAllText("Resources\\SavedReminders.xml", string.Empty);
            string xml = (@"<?xml version='1.0' encoding='utf-8'?>
<Reminders>
</Reminders>");
            System.IO.File.WriteAllText(@"Resources\SavedReminders.xml", xml);
            xmlRefeshlst(GetVar);
        }
    }
}

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Fingers
{
    class LoadSetRegistryClass
    {
        private static readonly String _GFRegAct = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\GreenFingers\AppSettings", "ReminderSet", null);
        private static readonly String _GFRegSysTray = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\GreenFingers\AppSettings", "StartInSystemTray", null);
        private static readonly String _GFRegRunAtStartUp = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Run", "GreenFinger", null);


        private static bool showErrors = false;
        public bool ShowErrors
        {
            get { return showErrors; }
            set { showErrors = value; }
        }

        private static void ShowErrorMessages(Exception e, string ETitle)
        {
            if (showErrors == true)
                MessageBox.Show(e.Message,
                ETitle
                , MessageBoxButtons.OK
                , MessageBoxIcon.Error);
        }
        
        public bool chkRegAct()
        {
            try
            {
                if (_GFRegAct == null)
                {
                    RegistryKey key5 = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\GreenFingers\AppSettings");

                    //storing the values  
                    key5.SetValue("ReminderSet", "0");
                    key5.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                ShowErrorMessages(e, "Reminder Set to OFF Error!");
                return false;

            }
            return true;
        }

        public bool chkRegSysT()
        {
            try
            {
                if (_GFRegSysTray == null)
                {
                    RegistryKey key4 = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\GreenFingers\AppSettings");

                    //storing the values  
                    key4.SetValue("StartInSystemTray", "0");
                    key4.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                ShowErrorMessages(e, "StartInSystemTray to OFF Error!");
                return false;
            }
            return true;
        }

        public bool chkRegRun()
        {
            try
            {
                if (_GFRegRunAtStartUp == null)
                {
                    string Gfdirectory = AppDomain.CurrentDomain.BaseDirectory.ToString();
                    string GfName = "GreenFinger.exe";
                    RegistryKey key3 = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                    key3.SetValue("GreenFinger", Gfdirectory + GfName);
                    key3.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                ShowErrorMessages(e, "Creating a startup key failed!");
                return false;
            }
            return true;
        }

        public static bool RegGetSysTVel(Mainfrm open4)
        {
            try
            {
                RegistryKey myKeys1 = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\GreenFingers\AppSettings", false);
                {
                    String values = (String)myKeys1.GetValue("StartInSystemTray");
                    if (values == "1")
                    {
                        open4.Visible = false;
                        open4.ShowInTaskbar = false;
                        open4.Opacity = 0;
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                ShowErrorMessages(e, "Could not get system Tray value!");
                return false;
            }
            return true;
        }

        public static bool RegGetReminderVel(Mainfrm open3)
        {
            try
            {
                RegistryKey myKey2 = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\GreenFingers\AppSettings", false);
                {
                    String value = (String)myKey2.GetValue("ReminderSet");
                    
                    if (value == "0")
                    {
                        open3.btnActivate.Visible = true;
                        return true;
                    }

                    if (value == "1")
                    {
                        open3.btnDeactivate.Visible = true;
                        DatePopupClass open = new DatePopupClass();
                        open.Datechecker();
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                ShowErrorMessages(e, "GetReminderVel Error!");
                return false;
            }
            return true;
        }

        public static bool SetReminderAndSystemTray(int switchExpression)
        {
            try
            {
                switch (switchExpression)
                {
                    case 0:
            RegistryKey key0 = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\GreenFingers\AppSettings");
            //storing the values  
            key0.SetValue("ReminderSet", "1");
            key0.Close();
                        break;
                    case 1:
            RegistryKey keys1 = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\GreenFingers\AppSettings");
            //storing the values  
            keys1.SetValue("StartInSystemTray", "1");
            keys1.Close();
                        break;
                    case 2:
            RegistryKey key2 = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\GreenFingers\AppSettings");
            //storing the values  
            key2.SetValue("ReminderSet", "0");
            key2.Close();
                        break;
                    case 3:
            RegistryKey keys3 = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\GreenFingers\AppSettings");
            //storing the values  
            keys3.SetValue("StartInSystemTray", "0");
            keys3.Close();
                        break;
                }
                return true;
            }
            catch (Exception e)
            {
                ShowErrorMessages(e, "SetReminderAndSystemTray Error!");
                return false;
            }

        }

        public static void RegActavate(Mainfrm open2)
        {
            SetReminderAndSystemTray(0); //ReminderSet = 1
            SetReminderAndSystemTray(1); //StartInSystemTray = 1
            open2.btnActivate.Visible = false;
            open2.btnActivate.Enabled = false;
            open2.btnDeactivate.Visible = true;
            open2.btnDeactivate.Enabled = true;
        }

        public static void RegDeactivate(Mainfrm open1)
        {
            SetReminderAndSystemTray(2); //ReminderSet = 0
            SetReminderAndSystemTray(3); //StartInSystemTray = 0
            open1.btnDeactivate.Visible = false;
            open1.btnDeactivate.Enabled = false;
            open1.btnActivate.Visible = true;
            open1.btnActivate.Enabled = true;
        }
    }
}

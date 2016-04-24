using System.IO;

namespace Green_Fingers
{
    class CreateNewDatabaseClass
    {
        public static void ExtDB(Mainfrm Send)
        {
            /*
             * Created By Matthew Utin. https://github.com/mattu08/Green-Fingers/
            */

            if (System.IO.File.Exists(@"GreenFingersDB_log.ldf")) { File.Delete("GreenFingersDB_log.ldf"); }
            if (System.IO.File.Exists(@"GreenFingersDB.mdf")) { File.Delete("GreenFingersDB.mdf"); }
            File.WriteAllBytes("GreenFingersDB.mdf", Properties.Resources.GreenFingersDB);
        }
    }
}

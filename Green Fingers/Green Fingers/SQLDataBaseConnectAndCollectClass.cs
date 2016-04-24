using System.Data.SqlClient;

namespace Green_Fingers
{
    class SQLDataBaseConnectAndCollectClass
    {
        public static void ExtGetDB(Mainfrm send)
        {
            string ConString = Properties.Settings.Default.GreenFingersDBConn;

            try
            {
                using (SqlConnection Conn = new SqlConnection(ConString))
                {
                    string strGf = "SELECT * FROM GreenFingers WHERE [Plant Name] = @List_Var";
                    SqlCommand SqlCmd = new SqlCommand(strGf, Conn);
                    SqlCmd.Parameters.AddWithValue("@List_Var", send.Get_SQL_List_Var);
                    Conn.Open();

                    SqlDataReader GfReader = SqlCmd.ExecuteReader();

                    if (GfReader.HasRows)
                    {
                        while (GfReader.Read())
                        {
                            if (GfReader["ID"] == null) { send.S_Id = "N/A"; }
                            else { send.S_Id = GfReader["ID"].ToString(); }

                            if (GfReader["Plant Name"] == null) { send.Plant_Name = "N/A"; }
                            else { send.Plant_Name = GfReader["Plant Name"].ToString(); }

                            if (GfReader["Sow Indoors"] == null) { send.Sow_In = "N/A"; }
                            else { send.Sow_In = GfReader["Sow Indoors"].ToString(); }

                            if (GfReader["Sow Under Cover"] == null) { send.Sow_Un = "N/A"; }
                            else { send.Sow_Un = GfReader["Sow Under Cover"].ToString(); }

                            if (GfReader["Sow Outdoors"] == null) { send.Sow_Out = "N/A"; }
                            else { send.Sow_Out = GfReader["Sow Outdoors"].ToString(); }

                            if (GfReader["Plant Out"] == null) { send.Plant_Out = "N/A"; }
                            else { send.Plant_Out = GfReader["Plant Out"].ToString(); }

                            if (GfReader["Harvest Time"] == null) { send.Har_Time = "N/A"; }
                            else { send.Har_Time = GfReader["Harvest Time"].ToString(); }

                            if (GfReader["Notes"] == null) { send.Notes = "N/A"; }
                            else { send.Notes = GfReader["Notes"].ToString(); }

                            if (GfReader["Plot Number/Name"] == null) { send.Plt_Num = "N/A"; }
                            else { send.Plt_Num = GfReader["Plot Number/Name"].ToString(); }
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
    }
}

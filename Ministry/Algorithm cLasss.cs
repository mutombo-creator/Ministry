using System;
using System.Data.OleDb;



namespace Ministry
{
    class Algorithm_cLasss
    {
      

        public static string oleStr = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                              @"Data source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Ministry.accdb";

        OleDbCommand cmd;
        // SqlConnection conection = new SqlConnection();

        OleDbConnection conection = new OleDbConnection();

        public string SavingAcount(string user, string pass)
        {
            conection = new OleDbConnection(oleStr);
            conection.Open();
            string comand = "Insert into Acounts(UserName,AccessCode) Values('" + user + "','" + pass + "')";

            cmd = new OleDbCommand(comand, conection);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conection.Close();
            return "Save Succefull";
        }
        public string SaveDataToDatabase(string fName, string Mname, string Lname, string status, long contact, string location, string gender, int age)
        {



            try
            {
                // ConfigurationManager.RefreshSection("connectionStrings");
                // conection.ConnectionString = ConfigurationManager.ConnectionStrings["Ministry.Properties.Settings.GoodnewsStr"].ToString();
                conection = new OleDbConnection(oleStr);

                conection.Open();
                string command = "Insert into Members(firstName,middleName,lastName,maritalStatus,contact,location,gender,age) Values('" + fName + "','" + Mname + "'," +
                    "'" + Lname + "','" + status + "','" + contact + "','" + location + "','" + gender + "','" + age + "')";

                cmd = new OleDbCommand(command, conection);
                cmd.ExecuteNonQuery();
                conection.Close();
                cmd.Dispose();
                return "Save Succefull";

            }
            catch (Exception ex)
            {

                conection.Close();

                return ex.ToString();
            }



            //saving info to the database table 

        }

        public bool ReadAndLogIn(string UserName, string password)
        {
            conection = new OleDbConnection(oleStr);
            string pass;
            conection.Open();
            string command = "Select * from Acounts where UserName ='" + UserName + "' ";
            cmd = new OleDbCommand(command, conection);

            OleDbDataReader read = cmd.ExecuteReader();


            if (read.Read())
            {
                pass = read.GetString(2).Trim();
                if (pass == password)
                {
                    conection.Close();

                    return true;
                    

                }
            }
            conection.Close();
            // reader.Close();

            return false;
        }

        public bool DeleteMember(string fullname)
        {


            string[] names = fullname.Split(' ');
            conection = new OleDbConnection(oleStr);
            conection.Open();

            string command = "delete  from Members where firstName='" + names[0] + "' AND lastName='" + names[2] + "' ";

            try
            {
                cmd = new OleDbCommand(command, conection);

                cmd.ExecuteNonQuery();
                conection.Close();
                cmd.Dispose();
                return true;
            }
            catch (Exception ex)
            {

                conection.Close();
                cmd.Dispose();
                return false;
            }
        }


        //public bool CreateNewAccessDatabase(string fileName)
        //{
        //    bool result = false;

        //    ADOX.Catalog cat = new ADOX.Catalog();
        //    ADOX.Table table = new ADOX.Table();

        //    //Create the table and it's fields. 
        //    table.Name = "Table1";
        //    table.Columns.Append("Field1");
        //    table.Columns.Append("Field2");

        //    try
        //    {
        //        cat.Create("Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + fileName + "; Jet OLEDB:Engine Type=5");
        //        cat.Tables.Append(table);

        //        //Now Close the database
        //        ADODB.Connection con = cat.ActiveConnection as ADODB.Connection;
        //        if (con != null)
        //            con.Close();

        //        result = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        result = false;
        //    }
        //    cat = null;
        //    return result;
        //}
    }
}

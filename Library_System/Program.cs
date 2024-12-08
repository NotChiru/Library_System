using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public static class Gvar
    {
        public static DataTable Account_Manage_Table = new DataTable();
        public static DataTable Book_Menu_Table = new DataTable();
        public static DataTable Book_Report_Table = new DataTable();
        
    }

    public static class database
    {
        //PUT THE CONNECTOR PORT HERE AS A BY RIGHT CLICKING THE DATABASE AND TAKE THE DATAPORT FORM THE PROPERITES
        static string database_properties = "Data Source=localhost; user id='root'; Initial Catalog='libsys_db'";
        //PLS DO THIS OR ELSE PROGRAM WILL FAIL TO RUN DUMB SKIBIDI GYATT

        static MySqlCommand cmd = new MySqlCommand();//DONT TOUCH THIS BTW
        static MySqlConnection con = new MySqlConnection(database_properties);

        public static String returnSingle = "null";
        public static String[] returnColumn = new string[0];
        public static DataTable returnTable = new DataTable();
        static bool isConnectionOpened = false;


        public static void query(string SQLCOMMAND)//Performs a commmand through a string
        {

            try
            {
                if (isConnectionOpened) { con.Close(); }
                con.Open();
                isConnectionOpened = true;
                cmd.CommandText = SQLCOMMAND;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();

                MySqlDataReader table_scanner = cmd.ExecuteReader();

                String[] templar = new String[0];

                try
                {
                    returnSingle = "null";
                    returnColumn = new string[0];
                    returnTable = new DataTable();
                    int index = 0;
                    string storedString = "";

                    while (table_scanner.Read())
                    {
                        storedString = table_scanner.GetValue(0).ToString();
                        Array.Resize(ref templar, templar.Length + 1);
                        templar[index] = storedString;
                        index++;
                        continue;
                    }
                    returnColumn = templar;

                    table_scanner.Close();
                    returnSingle = returnColumn[0];

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(returnTable);
                }
                catch (Exception e) { MessageBox.Show(e.ToString()); }


                
            }
            catch (Exception e)
            {
                returnTable = new DataTable();
                returnColumn = new string[0];
                returnSingle = "null";

                MessageBox.Show(e.ToString());
            }
        }

    }
}

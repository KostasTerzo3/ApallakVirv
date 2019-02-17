using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore4
{
    public class PostGreSQL
    {
        List<string> dataItems = new List<string>();
       public void PostgreSQL()
        {
       }

        public List<string> PostgreSQLtest1()
        {
            try
            {
                string connstring = "Server=127.0.0.1; Port=5432; User Id=postgres; Password=postgres; Database=postgres;";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM Books2", connection);
                NpgsqlDataReader dataReader = command.ExecuteReader();
                for (int i = 0; dataReader.Read(); i++)
                {
                    dataItems.Add(dataReader[0].ToString() + "," + dataReader[1].ToString() + "," + dataReader[2].ToString() + "\r\n");
                }
                connection.Close();
                return dataItems;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }


       

    }

   
}

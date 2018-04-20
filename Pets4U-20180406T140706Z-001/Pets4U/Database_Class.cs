using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Pets4U
{
   
    class Database_Class
    {
        MySqlConnection connection = new MySqlConnection("datasource=den1.mysql2.gear.host; port=3306; Initial Catalog='petclientdb1';username='petclientdb1';password='Ty7H~_KGS4Zf';");
        //==================//_____Deon_____//==================//

        MySqlParameter[] param = new MySqlParameter[2];

        public void insert_staff()
        {
            param[0] = new MySqlParameter("Lname", MySqlDbType.VarChar);
            param[0].Value = "Deon";

            param[1] = new MySqlParameter("Fname", MySqlDbType.VarChar);
            param[1].Value = "Pieterse";

            MySqlCommand command = new MySqlCommand();

            command.Connection = connection;
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "insert_staff";

            command.Parameters.AddRange(param);

            connection.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Query executed.");
            }
            else
            {
                MessageBox.Show("Query not executed.");
            }
            connection.Close();
        }

        //==================//////////////////==================//


        //==================//_____Brandon_____//==================//



        //==================//////////////////==================//
        
        
        //==================//_____Leonard aka ProAmmunition_____//==================//



        //==================//////////////////==================//
    }
}

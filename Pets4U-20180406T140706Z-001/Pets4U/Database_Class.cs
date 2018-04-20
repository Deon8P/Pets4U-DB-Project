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

       public MySqlConnection connection = new MySqlConnection("datasource=den1.mysql2.gear.host; port=3306; Initial Catalog='petclientdb1';username='petclientdb1';password='Ty7H~_KGS4Zf';");
        //==================//_____Deon_____//==================//

        

        public void insert_staff()
        {
            MySqlParameter[] param = new MySqlParameter[2];

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

        public void insert_clinic()
        {
            MySqlParameter[] param = new MySqlParameter[7];

            param[0] = new MySqlParameter("clinic_num", MySqlDbType.Int32);
            param[0].Value = "100000";

            param[1] = new MySqlParameter("clinic_street", MySqlDbType.VarChar);
            param[1].Value = "Willow";

            param[2] = new MySqlParameter("clinic_city", MySqlDbType.VarChar);
            param[2].Value = "Vanderbijlpark";

            param[3] = new MySqlParameter("clinic_state", MySqlDbType.VarChar);
            param[3].Value = "Gauteng";

            param[4] = new MySqlParameter("clinic_zip", MySqlDbType.Int32);
            param[4].Value = "1911";

            param[5] = new MySqlParameter("clinic_tel", MySqlDbType.Int32);
            param[5].Value = "0160841365";

            param[6] = new MySqlParameter("clinic_fax", MySqlDbType.Int32);
            param[6].Value = "1025687698";

            MySqlCommand command = new MySqlCommand();

            command.Connection = connection;
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "insert_clinic";

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

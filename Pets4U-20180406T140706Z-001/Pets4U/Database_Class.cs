﻿using System;
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

        

        public void insert_staff(int Staff_Number, string Staff_Lname, string Staff_Fname, string Staff_Street, string Staff_City,
                                 string Staff_State, int Staff_Zip, int Staff_Tel, string Staff_Birth_Date, string Staff_Sex,
                                 int Staff_ID, string Staff_Position, double Staff_Annual_Salary, int Clinic_Number)
        {
            MySqlParameter[] param = new MySqlParameter[14];

            param[0] = new MySqlParameter("Staff_Number", MySqlDbType.Int32);
            param[0].Value = Staff_Number;

            param[1] = new MySqlParameter("Staff_Lname", MySqlDbType.VarChar);
            param[1].Value = Staff_Lname;

            param[2] = new MySqlParameter("Staff_Fname", MySqlDbType.VarChar);
            param[2].Value = Staff_Fname;

            param[3] = new MySqlParameter("Staff_Street", MySqlDbType.VarChar);
            param[3].Value = Staff_Street;

            param[4] = new MySqlParameter("Staff_City", MySqlDbType.VarChar);
            param[4].Value = Staff_City;

            param[5] = new MySqlParameter("Staff_State", MySqlDbType.VarChar);
            param[5].Value = Staff_State;

            param[6] = new MySqlParameter("Staff_Zip", MySqlDbType.Int32);
            param[6].Value = Staff_Zip;

            param[7] = new MySqlParameter("Staff_Tel", MySqlDbType.Int32);
            param[7].Value = Staff_Tel;

            param[8] = new MySqlParameter("Staff_Birth_Date", MySqlDbType.Date);
            param[8].Value = Staff_Birth_Date;

            param[9] = new MySqlParameter("Staff_Sex", MySqlDbType.VarChar);
            param[9].Value = Staff_Sex;

            param[10] = new MySqlParameter("Staff_ID", MySqlDbType.Int32);
            param[10].Value = Staff_ID;

            param[11] = new MySqlParameter("Staff_Position", MySqlDbType.VarChar);
            param[11].Value = Staff_Position;

            param[12] = new MySqlParameter("Staff_Annual_Salary", MySqlDbType.Double);
            param[12].Value = Staff_Annual_Salary;

            param[13] = new MySqlParameter("Clinic_Number", MySqlDbType.Int32);
            param[13].Value = Clinic_Number;

            MySqlCommand command = new MySqlCommand();

            command.Connection = connection;
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "insert_staff";

            command.Parameters.AddRange(param);

            connection.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Staff member has been registered.", "Registered Staff Member", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Staff member has not been registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show("Clinic has been registered.", "Registered Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Clinic has not been registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            connection.Close();
        }

        //==================//////////////////==================//


        //==================//_____Brandon_____//==================//



        //==================//////////////////==================//
        
        
        //==================//_____Leonard//==================//




        //==================//////////////////==================//
    }
}

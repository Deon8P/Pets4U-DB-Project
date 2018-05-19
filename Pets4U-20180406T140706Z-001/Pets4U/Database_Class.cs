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

                public void insert_staff(string Staff_Number, string Staff_Lname, string Staff_Fname, string Staff_Street, string Staff_City,
                                 string Staff_State, int Staff_Zip, string Staff_Tel, string Staff_Birth_Date, string Staff_Sex,
                                 string Staff_ID, string Staff_Position, double Staff_Annual_Salary, string Staff_Password, int Clinic_Number)
        {
            MySqlParameter[] param = new MySqlParameter[15];

            param[0] = new MySqlParameter("Staff_Number", MySqlDbType.VarChar);
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

            param[7] = new MySqlParameter("Staff_Tel", MySqlDbType.VarChar);
            param[7].Value = Staff_Tel;

            param[8] = new MySqlParameter("Staff_Birth_Date", MySqlDbType.Date);
            param[8].Value = Staff_Birth_Date;

            param[9] = new MySqlParameter("Staff_Sex", MySqlDbType.VarChar);
            param[9].Value = Staff_Sex;

            param[10] = new MySqlParameter("Staff_ID", MySqlDbType.VarChar);
            param[10].Value = Staff_ID;

            param[11] = new MySqlParameter("Staff_Position", MySqlDbType.VarChar);
            param[11].Value = Staff_Position;

            param[12] = new MySqlParameter("Staff_Annual_Salary", MySqlDbType.Double);
            param[12].Value = Staff_Annual_Salary;

            param[13] = new MySqlParameter("Staff_Password", MySqlDbType.VarChar);
            param[13].Value = Staff_Password;

            param[14] = new MySqlParameter("Clinic_Number", MySqlDbType.Int32);
            param[14].Value = Clinic_Number;

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

        public void insert_clinic(int Clinic_num, string Clinic_street, string Clinic_city, string Clinic_state, int Clinic_zip, string Clinic_tel, string Clinic_fax)
        {
            MySqlParameter[] param = new MySqlParameter[7];

            param[0] = new MySqlParameter("Clinic_num", MySqlDbType.Int32);
            param[0].Value = Clinic_num;

            param[1] = new MySqlParameter("Clinic_street", MySqlDbType.VarChar);
            param[1].Value = Clinic_street;

            param[2] = new MySqlParameter("Clinic_city", MySqlDbType.VarChar);
            param[2].Value = Clinic_city;

            param[3] = new MySqlParameter("Clinic_state", MySqlDbType.VarChar);
            param[3].Value = Clinic_state;

            param[4] = new MySqlParameter("Clinic_zip", MySqlDbType.Int32);
            param[4].Value = Clinic_zip;

            param[5] = new MySqlParameter("Clinic_tel", MySqlDbType.VarChar);
            param[5].Value = Clinic_tel;

            param[6] = new MySqlParameter("Clinic_fax", MySqlDbType.VarChar);
            param[6].Value = Clinic_fax;

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

        public void insert_appointment(int Appointment_Number, int Owner_Num, string Owner_Lname, string Owner_Fname, int Owner_Tel, 
                                       int Pet_Number, string Pet_Name, string Pet_Type, string Appointment_Date, string Appointment_Time, int Clinic_Number)
        {
            MySqlParameter[] param = new MySqlParameter[11];

            param[0] = new MySqlParameter("Appointment_Number", MySqlDbType.Int32);
            param[0].Value = Appointment_Number;

            param[1] = new MySqlParameter("Owner_Num", MySqlDbType.Int32);
            param[1].Value = Owner_Num;

            param[2] = new MySqlParameter("Owner_Lname", MySqlDbType.VarChar);
            param[2].Value = Owner_Lname;

            param[3] = new MySqlParameter("Owner_Fname", MySqlDbType.VarChar);
            param[3].Value = Owner_Fname;

            param[4] = new MySqlParameter("Owner_Tel", MySqlDbType.Int32);
            param[4].Value = Owner_Tel;

            param[5] = new MySqlParameter("Pet_Number", MySqlDbType.Int32);
            param[5].Value = Pet_Number;

            param[6] = new MySqlParameter("Pet_Name", MySqlDbType.VarChar);
            param[6].Value = Pet_Name;

            param[7] = new MySqlParameter("Pet_Type", MySqlDbType.VarChar);
            param[7].Value = Pet_Type;

            param[8] = new MySqlParameter("Appointment_Date", MySqlDbType.Date);
            param[8].Value = Appointment_Date;

            param[9] = new MySqlParameter("Appointment_Time", MySqlDbType.Time);
            param[9].Value = Appointment_Time;

            param[10] = new MySqlParameter("Clinic_Number", MySqlDbType.Int32);
            param[10].Value = Clinic_Number;

            MySqlCommand command = new MySqlCommand();

            command.Connection = connection;
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "insert_appointment";

            command.Parameters.AddRange(param);

            connection.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Appointment has been scheduled.", "Scheduled Appointment", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Appointment has not been scheduled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            connection.Close();
        }

        public void insert_examination(int Examination_Number, string Examination_Date, string Examination_Time, string Vet_Name, int Pet_Number, 
                                       string Pet_Name, string Pet_Type, string Resluts_Description, string Staff_Num)
        {

        }

        //==================//////////////////==================//


        //==================//_____Brandon_____//==================//

        public bool validIDnumber(string idNum)
        {
            string[] arrayID = new string[13];

            int odd = 0;
            int even = 0;
            int controlValue = 0;
            int total = 0;

            for (int k = 0; k < 13; k++)
            {
                arrayID[k] = idNum.Substring(k, 1);
            }

            for (int i = 0; i < 6; i++)
            {
                odd += int.Parse(arrayID[2 * i].ToString());
            }

            for (int i = 0; i < 6; i++)
            {
                even = even * 10 + int.Parse(arrayID[2 * i + 1].ToString());
            }

            even *= 2;

            do
            {
                total += even % 10;
                even = even / 10;
            }
            while (even > 0);

            total += odd;

            controlValue = 10 - (total % 10);

            if (controlValue == 10)
                controlValue = 0;

            if (controlValue != Convert.ToInt32(idNum.Substring(12, 1)))
            {
                MessageBox.Show("Invalid IDNumber");
                return false;
            }

            return true;
        }

        public bool EmployeelogIn(string emp_num, string password, int ClinicNum)
        {
            bool login = false;

            try
            {
                connection.Open();

               string query = "Select Staff_Number, Staff_Password, Clinic_Number From staff";

               MySqlCommand  cmd = new MySqlCommand(query, connection);

               MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string emp_number = reader[0].ToString();
                    string emp_password = reader[1].ToString();
                    string clinic_num = reader[2].ToString();

                    if (emp_number.Equals(emp_num) && emp_password.Equals(password))//&& (clinic_num == ClinicNum)
                    {
                        login = true;
                        break;
                    }
                }

                reader.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }

            return login;
        }

        public int getAmount(string tableName, string itemType, string columnQ, string columnN)
        {
            int amount = 0;

            try
            {
                connection.Open();

                string query = "Select " + columnQ + " From " + tableName + " WHERE " + columnN +" = '" + itemType + "'";

                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    amount = Convert.ToInt32(reader[0].ToString());
                    break;
                }

                reader.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
            return amount;

        }

        public void UpdateSupplies(string table, int amount, string itemName, string columnQ, string columnN)
        {
             MySqlCommand cmd;
             MySqlDataAdapter adapter;

            try
            {
                connection.Open();

                adapter = new MySqlDataAdapter();

                cmd = new MySqlCommand("UPDATE " + table + " SET " + columnQ + " = " + amount + " WHERE " + columnN + " = '" + itemName + "'", connection);

                adapter.UpdateCommand = cmd;

                if (adapter.UpdateCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Supplies Updated.", "Supplies", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Supplies not updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //==================//////////////////==================//


        //==================//_____Leonard//==================//

       public void insert_pet_owner(int own_num, string own_LName, string own_FName, string own_street, string own_city, string own_state, int own_zip, int own_tel, string pet_name, int clinic_number)
        {
            MySqlParameter[] param = new MySqlParameter[10];

            param[0] = new MySqlParameter("Owner_Number", MySqlDbType.Int32);
            param[0].Value = own_num;

            param[1] = new MySqlParameter("Owner_Lname", MySqlDbType.VarChar);
            param[1].Value = own_LName;

            param[2] = new MySqlParameter("Owner_Fname", MySqlDbType.VarChar);
            param[2].Value = own_FName;

            param[3] = new MySqlParameter("Owner_Street", MySqlDbType.VarChar);
            param[3].Value = own_street;

            param[4] = new MySqlParameter("Owner_City", MySqlDbType.VarChar);
            param[4].Value = own_city;

            param[5] = new MySqlParameter("Owner_State", MySqlDbType.VarChar);
            param[5].Value = own_state;

            param[6] = new MySqlParameter("Owner_Zip", MySqlDbType.Int32);
            param[6].Value = own_zip;

            param[7] = new MySqlParameter("Owner_Tel", MySqlDbType.Int32);
            param[7].Value = own_tel;

            param[8] = new MySqlParameter("Pet_Name", MySqlDbType.VarChar);
            param[8].Value = pet_name;

            param[9] = new MySqlParameter("Clinic_Number", MySqlDbType.Int32);
            param[9].Value = clinic_number;

            MySqlCommand sql_cmd = new MySqlCommand();
            sql_cmd.Connection = connection;
            sql_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            sql_cmd.CommandText = "insert_pet_owner";
            sql_cmd.Parameters.AddRange(param);

            connection.Open();

            if (sql_cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("The pet owner information has been successfully inserted.", "Pet Owner", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Pet owner information input error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            connection.Close();
        }


       public void insert_pet(int pet_num, string pet_name, string pet_type, string pet_description, string pet_bday, string  pet_reg_date, string pet_status, int own_num, int clinic_number)
        {
            MySqlParameter[] param = new MySqlParameter[9];

            param[0] = new MySqlParameter("Pet_Number", MySqlDbType.Int32);
            param[0].Value = pet_num;

            param[1] = new MySqlParameter("Pet_Name", MySqlDbType.VarChar);
            param[1].Value = pet_name;

            param[2] = new MySqlParameter("Pet_Type", MySqlDbType.VarChar);
            param[2].Value = pet_type;

            param[3] = new MySqlParameter("Pet_Description", MySqlDbType.VarChar);
            param[3].Value = pet_description;

            param[4] = new MySqlParameter("Pet_Birth_Date", MySqlDbType.Date);
            param[4].Value = pet_bday;

            param[5] = new MySqlParameter("Pet_Reg_Date", MySqlDbType.Date);
            param[5].Value = pet_reg_date;

            param[6] = new MySqlParameter("Pet_Status", MySqlDbType.VarChar);
            param[6].Value = pet_status;

            param[7] = new MySqlParameter("Owner_Number", MySqlDbType.Int32);
            param[7].Value = own_num;

            param[8] = new MySqlParameter("Clinic_Number", MySqlDbType.Int32);
            param[8].Value = clinic_number;

           
            MySqlCommand sql_cmd = new MySqlCommand();
            sql_cmd.Connection = connection;
            sql_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            sql_cmd.CommandText = "insert_pet";
            sql_cmd.Parameters.AddRange(param);

            connection.Open();

            if (sql_cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("The pet information has been successfully inserted.", "Pet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Pet information input error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            connection.Close();
        }

        public void insert_surgical_supplies(int supply_num, int clinic_num, string supply_name, string supply_description, int quantity_of_stock, int reorder_level,int reorder_quantity, double supply_cost)
        {
            MySqlParameter[] param = new MySqlParameter[8];

            param[0] = new MySqlParameter("Supply_Number", MySqlDbType.Int32);
            param[0].Value = supply_num;

            param[1] = new MySqlParameter("Clinic_Number", MySqlDbType.Int32);
            param[1].Value = clinic_num;

            param[2] = new MySqlParameter("Supply_Name", MySqlDbType.VarChar);
            param[2].Value = supply_name;

            param[3] = new MySqlParameter("Supply_Description", MySqlDbType.VarChar);
            param[3].Value = supply_description;

            param[4] = new MySqlParameter("Quantity_In_Stock", MySqlDbType.Int32);
            param[4].Value = quantity_of_stock;

            param[5] = new MySqlParameter("Reorder_Level", MySqlDbType.Int32);
            param[5].Value = reorder_level;

            param[6] = new MySqlParameter("Reorder_Quantity", MySqlDbType.Int32);
            param[6].Value = reorder_quantity;

            param[7] = new MySqlParameter("Supply_Cost", MySqlDbType.Double);
            param[7].Value = supply_cost;



            MySqlCommand sql_cmd = new MySqlCommand();
            sql_cmd.Connection = connection;
            sql_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            sql_cmd.CommandText = "insert_surgical_supplies";
            sql_cmd.Parameters.AddRange(param);

            connection.Open();

            if (sql_cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("The surgical supplies information has been successfully inserted.", "Surgical Supplies", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Information input error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            connection.Close();
        }


        public void insert_non_surgical_supplies(int supply_num, string supply_name, string supply_description, int quantity_of_stock, int reorder_level, int reorder_quantity, double supply_cost, int clinic_num)
        {
            MySqlParameter[] param = new MySqlParameter[8];

            param[0] = new MySqlParameter("Supply_Number", MySqlDbType.Int32);
            param[0].Value = supply_num;

            param[1] = new MySqlParameter("Supply_Name", MySqlDbType.VarChar);
            param[1].Value = supply_name;

            param[2] = new MySqlParameter("Supply_Description", MySqlDbType.VarChar);
            param[2].Value = supply_description;

            param[3] = new MySqlParameter("Quantity_Of_Stock", MySqlDbType.Int32);
            param[3].Value = quantity_of_stock;

            param[4] = new MySqlParameter("Reorder_Level", MySqlDbType.Int32);
            param[4].Value = reorder_level;

            param[5] = new MySqlParameter("Reorder_Quantity", MySqlDbType.Int32);
            param[5].Value = reorder_quantity;

            param[6] = new MySqlParameter("Supply_Cost", MySqlDbType.Double);
            param[6].Value = supply_cost;

            param[7] = new MySqlParameter("Clinic_Number", MySqlDbType.Int32);
            param[7].Value = clinic_num;



            MySqlCommand sql_cmd = new MySqlCommand();
            sql_cmd.Connection = connection;
            sql_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            sql_cmd.CommandText = "insert_non_surgical_supplies";
            sql_cmd.Parameters.AddRange(param);

            connection.Open();

            if (sql_cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("The non-surgical supplies information has been successfully inserted.", "Non-Surgical Supplies", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Information input error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            connection.Close();
        }


        public void insert_pharma_supplies(int drug_num, int clinic_number, string drug_name, string drug_description, double drug_dosage, string method_of_admin, int quantity_in_stock, int reorder_level, int reorder_quantity, double drug_cost)
        {
            MySqlParameter[] param = new MySqlParameter[10];

            param[0] = new MySqlParameter("Drug_Number", MySqlDbType.Int32);
            param[0].Value = drug_num;

            param[1] = new MySqlParameter("Clinic_Number", MySqlDbType.Int32);
            param[1].Value = clinic_number;

            param[2] = new MySqlParameter("Drug_Name", MySqlDbType.VarChar);
            param[2].Value = drug_name;

            param[3] = new MySqlParameter("Drug_Description", MySqlDbType.VarChar);
            param[3].Value = drug_description;

            param[4] = new MySqlParameter("Drug_Dosage", MySqlDbType.Double);
            param[4].Value = drug_dosage;

            param[5] = new MySqlParameter("Method_Of_Admin", MySqlDbType.VarChar);
            param[5].Value = method_of_admin;

            param[6] = new MySqlParameter("Quantity_In_Stock", MySqlDbType.Int32);
            param[6].Value = quantity_in_stock;

            param[7] = new MySqlParameter("Reorder_Level", MySqlDbType.Int32);
            param[7].Value = reorder_level;

            param[8] = new MySqlParameter("Reorder_Quantity", MySqlDbType.Int32);
            param[8].Value = reorder_quantity;

            param[9] = new MySqlParameter("Drug_Cost", MySqlDbType.Double);
            param[9].Value = drug_cost;



            MySqlCommand sql_cmd = new MySqlCommand();
            sql_cmd.Connection = connection;
            sql_cmd.CommandType = System.Data.CommandType.StoredProcedure;
            sql_cmd.CommandText = "insert_pharma_supplies";
            sql_cmd.Parameters.AddRange(param);

            connection.Open();

            if (sql_cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("The pharmacutical supplies information has been successfully inserted.", "Pharmacutical Supplies", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Information input error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            connection.Close();
        }



        //==================//////////////////==================//
    }
}

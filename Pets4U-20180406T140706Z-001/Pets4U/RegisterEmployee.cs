using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pets4U
{
    public partial class RegisterEmployee : Form
    {
        public RegisterEmployee()
        {
            InitializeComponent();
        }
        Database_Class database = new Database_Class();

        public MySqlConnection connection;
        public MySqlDataAdapter adapter;
        public DataSet ds;
        public string query;

        public bool flag = false;
        public string emp_num, Position, createPass, confirmPass, Gen, state;
        public Random random;

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mtxtIDNum_Leave(object sender, EventArgs e)
        {
            if (database.validIDnumber(mtxtIDNum.Text) != true)
            {
                mtxtIDNum.Clear();
                mtxtIDNum.Focus();
            }
        }

        private void txtState_Enter(object sender, EventArgs e)
        {
            txtState.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            flag = false;
            string fname, lname, street_address, city, tel, ID;
            int clinic_Number, Zip_Code;
            double anualSalary = 0;
            string date;


            city = txtCity.Text;
            fname = txtFName.Text;
            lname = txtLName.Text;
            street_address = txtAddress.Text;
            tel = mtxtTel.Text;
            ID = mtxtIDNum.Text;
            Zip_Code = Convert.ToInt32(txtZip.Text);
            date = dateTimePicker1.Value.ToString();
            clinic_Number = Convert.ToInt32(comboBox3.SelectedValue.ToString());
            int code = comboBox2.SelectedIndex;
  
            date = date.Substring(0, 9).Replace('/', '-');


            switch (code)
            {
                case 0:
                    anualSalary = 960000;
                    break;
                case 1:
                    anualSalary = 300000;
                    break;
                case 2:
                    anualSalary = 120000;
                    break;
                case 3:
                    anualSalary = 60000;
                    break;
            }

            database.insert_staff(emp_num, lname, fname, street_address, city, state, Zip_Code, tel, date, Gen, ID, Position, anualSalary, createPass, clinic_Number);

            this.Close();
        }

        private void RegisterEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag == false)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
            }
        }

        private void RegisterEmployee_Load(object sender, EventArgs e)
        {
            txtState.Text = "***";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            try
            {
                connection = database.connection;
                connection.Open();

                adapter = new MySqlDataAdapter("SELECT Clinic_Number FROM clinic", connection);

                ds = new DataSet();

                adapter.Fill(ds, "clinic");

                comboBox3.DisplayMember = "Clinic_Number";
                comboBox3.ValueMember = "Clinic_Number";
                comboBox3.DataSource = ds.Tables["clinic"];
            }
            catch (System.Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
                random = new Random();

                state = txtState.Text;
                Gen = comboBox1.SelectedItem.ToString();
                Position = comboBox2.SelectedItem.ToString();
                int num = random.Next(100, 999);
                emp_num = state.Substring(0, 3).ToUpper() + Position.Substring(0, 1) + num;
                txtEmp_num.Text = emp_num;
        }

        private void txtConfirm_pass_Leave(object sender, EventArgs e)
        {
            createPass = txtCreatePass.Text;
            confirmPass = txtConfirm_pass.Text;

            if (!createPass.Equals(confirmPass))
            {
                MessageBox.Show("Password Mismatch");
                txtCreatePass.Clear();
                txtConfirm_pass.Clear();
                txtCreatePass.Focus();
            }
        }
    }
}

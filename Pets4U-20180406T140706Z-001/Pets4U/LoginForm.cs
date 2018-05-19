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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        Database_Class database = new Database_Class();

        public bool flag = false;
        public MySqlConnection connection;
        public MySqlDataAdapter adapter;
        public DataSet ds;
        public string query;

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            flag = true;
            RegisterEmployee registerEmployee = new RegisterEmployee();
            registerEmployee.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flag = true;

            if((txtEmpNum.Text.Equals("")) || (txtPass.Text.Equals("")) || (cmbClinickNum.SelectedValue == null))
                MessageBox.Show("Invalid Login Details");
            else
            {
                if (database.EmployeelogIn(txtEmpNum.Text, txtPass.Text, cmbClinickNum.SelectedValue.ToString()) == true)
                {
                    if (txtEmpNum.Text.Substring(3, 1).Equals("S"))
                    {
                        SecretariesForm SecForm = new SecretariesForm();
                        SecForm.Show();
                        this.Close();
                    }
                    else if (txtEmpNum.Text.Substring(3, 1).Equals("V"))
                    {
                        ManagerForm manager = new ManagerForm();
                        manager.Show();
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Invalid login details");               
            }
        }

        private void btnRegClinic_Click(object sender, EventArgs e)
        {
            flag = true;
            RegisterClinicForm regClinic = new RegisterClinicForm();
            regClinic.Show();
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                connection = database.connection;
                connection.Open();

                adapter = new MySqlDataAdapter("SELECT Clinic_Number FROM clinic", connection);

                ds = new DataSet();

                adapter.Fill(ds, "clinic");

                cmbClinickNum.DisplayMember = "Clinic_Number";
                cmbClinickNum.ValueMember = "Clinic_Number";
                cmbClinickNum.DataSource = ds.Tables["clinic"];
                cmbClinickNum.SelectedIndex = -1;
            }
            catch(System.Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag == false)
            {
                MainLoginForm MainForm = new MainLoginForm();
                MainForm.Show();
            }
        }
    }
}

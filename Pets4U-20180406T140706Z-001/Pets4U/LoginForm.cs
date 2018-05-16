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
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            flag = true;
            RegisterEmployee registerEmployee = new RegisterEmployee();
            registerEmployee.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flag = true;

            if (database.EmployeelogIn(txtEmpNum.Text, txtPass.Text, Convert.ToInt32(cmbClinickNum.SelectedValue.ToString())))
            {
                if (txtEmpNum.Text.Substring(3, 1).Equals("S"))
                {
                    SecretariesForm SecForm = new SecretariesForm();
                    SecForm.ShowDialog();
                    this.Close();
                }
                if(txtEmpNum.Text.Substring(3, 1).Equals("V"))
                {
                    ManagerForm manager = new ManagerForm();
                    manager.ShowDialog();
                    this.Close();
                }
            }
        }

        private void btnRegClinic_Click(object sender, EventArgs e)
        {
            flag = true;
            RegisterClinicForm regClinic = new RegisterClinicForm();
            regClinic.ShowDialog();
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
                MainForm.ShowDialog();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pets4U
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public OleDbConnection connection;
        public OleDbDataAdapter adapter;
        public string sql;

        private void button3_Click(object sender, EventArgs e)
        {
            MainLoginForm MainForm = new MainLoginForm();
            MainForm.ShowDialog();
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            RegisterEmployee registerEmployee = new RegisterEmployee();
            registerEmployee.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SecretariesForm SecForm = new SecretariesForm();
            SecForm.ShowDialog();
            this.Close();
        }

        private void btnRegClinic_Click(object sender, EventArgs e)
        {
            RegisterClinicForm regClinic = new RegisterClinicForm();
            regClinic.ShowDialog();
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                Database_Class database = new Database_Class();
                connection = 
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
    }
}

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
        

        private void button3_Click(object sender, EventArgs e)
        {
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
<<<<<<< HEAD
            try
            {
                Database_Class database = new Database_Class();
                connection = database.connection;
                connection.Open();

                adapter = new MySqlDataAdapter("SELECT Clinic_Number FROM clinic", connection);

                ds = new DataSet();

                adapter.Fill(ds, "clinic");

                comboBox1.DisplayMember = "Clinic_Number";
                comboBox1.ValueMember = "Clinic_Number";
                comboBox1.DataSource = ds.Tables["clinic"];
            }
            catch(System.Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
=======
>>>>>>> 0b30fee99b44f443e74ed267444ad9aa54204451
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainLoginForm MainForm = new MainLoginForm();
            MainForm.ShowDialog();
        }
    }
}

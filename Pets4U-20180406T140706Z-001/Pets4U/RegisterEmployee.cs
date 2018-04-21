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
    public partial class RegisterEmployee : Form
    {
        public RegisterEmployee()
        {
            InitializeComponent();
        }

        public bool flag = false;
        public Random random;

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            flag = true;
            string fname, lname, Gen, Position, address, createPass, confirmPass, emp_num;
            int tel, ID, num;
            DateTime date;

            fname = txtFName.Text;
            lname = txtLName.Text;
            Gen = comboBox1.SelectedItem.ToString();
            Position = comboBox2.SelectedItem.ToString();
            address = txtAddress.Text;
            createPass = txtCreatePass.Text;
            confirmPass = txtConfirm_pass.Text;

            tel = Convert.ToInt32(txtTel.Text);
            ID = Convert.ToInt32(txtTel.Text);

            date = dateTimePicker1.Value;

            num = random.Next(100, 999);
            emp_num = Position.Substring(0, 1) + num;

            MessageBox.Show(date.ToString());
            //call method
            //////////////////////////////////////////////////////
            Database_Class dbc = new Database_Class();

            //dbc.insert_staff(123, lname, fname, );
            /////////////////////////////////////////////////////

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
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }
    }
}

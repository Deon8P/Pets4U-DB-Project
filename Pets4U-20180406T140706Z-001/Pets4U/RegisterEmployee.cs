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
        public string emp_num;
        public string Position;
        public string Gen;
        public Random random;

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        { 
            flag = true;
            string fname, lname, address, createPass, confirmPass;
            int tel, ID;
            DateTime date;

            fname = txtFName.Text;
            lname = txtLName.Text;
            address = txtAddress.Text;
            createPass = txtCreatePass.Text;
            confirmPass = txtConfirm_pass.Text;

            tel = Convert.ToInt32(txtTel.Text);
            ID = Convert.ToInt32(txtTel.Text);

            date = dateTimePicker1.Value;

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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            random = new Random();

            Gen = comboBox1.SelectedItem.ToString();
            Position = comboBox2.SelectedItem.ToString();
            int num = random.Next(100, 999);
            emp_num = Position.Substring(0, 1) + num;
            txtEmp_num.Text = emp_num;
        }
    }
}

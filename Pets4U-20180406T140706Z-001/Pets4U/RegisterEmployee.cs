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

        private void button3_Click(object sender, EventArgs e)
        {
            string fname, lname, Gen, Position, address, createPass, confirmPass;
            int tel, emp_num, ID;
            DateTime date;

            fname = txtFName.Text;
            lname = txtLName.Text;
            Gen = txtGender.Text;
            Position = txtPosition.Text;
            address = txtAddress.Text;
            createPass = txtCreatePass.Text;
            confirmPass = txtConfirm_pass.Text;

            tel = Convert.ToInt32(txtTel.Text);
            emp_num = Convert.ToInt32(txtTel.Text);
            ID = Convert.ToInt32(txtTel.Text);

            date = dateTimePicker1.Value;

            //call method
            //////////////////////////////////////////////////////

            /////////////////////////////////////////////////////

            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }

    }
}

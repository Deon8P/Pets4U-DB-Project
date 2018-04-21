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
    public partial class RegisterClinicForm : Form
    {
        public RegisterClinicForm()
        {
            InitializeComponent();
        }

        private void RegisterClinicForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm LoginForm = new LoginForm();
            LoginForm.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int clinic_number, zip, tel, fax;
            string street, city, state;


            clinic_number = Convert.ToInt32(txtClinic_number.Text);
            zip = Convert.ToInt32(txtZip.Text);
            tel = Convert.ToInt32(txtTel.Text);
            fax = Convert.ToInt32(txtFax.Text);

            street = txtStreet.Text;
            city = txtStreet.Text;
            state = txtStreet.Text;

            //call method
            /////////////////////////////////////////////////////////////
            Database_Class dbc = new Database_Class();

            dbc.insert_clinic(clinic_number, street, city, state, zip, tel, fax);
            /////////////////////////////////////////////////////////////
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();
            this.Close();
        }
    }
}

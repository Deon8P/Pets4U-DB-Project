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

        Database_Class database = new Database_Class();

        private void RegisterClinicForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm LoginForm = new LoginForm();
            LoginForm.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int clinic_number, zip;
            string street, city, state, tel, fax;


            clinic_number = Convert.ToInt32(txtClinic_number.Text);
            zip = Convert.ToInt32(txtZip.Text);
            tel = mtxtTel.Text;
            fax = mtxtFax.Text;

            street = txtStreet.Text;
            city = txtCity.Text;
            state = txtState.Text;

            database.insert_clinic(clinic_number, street, city, state, zip, tel, fax);

            this.Close();
        }
    }
}

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
    public partial class RegisterPetFrom : Form
    {
        public RegisterPetFrom()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SecretariesForm SecForm = new SecretariesForm();
            SecForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string own_fname, own_lname, own_address, pet_name, pet_type, description, status;
            int own_ID, own_tel, pet_num;
            DateTime dob, date_reg;

            //owner
            own_fname = txtOwn_FName.Text;
            own_lname = txtOwn_LName.Text;
            own_address = txtOwn_Address.Text;

            own_ID = Convert.ToInt32(txtOwn_ID.Text);
            own_tel = Convert.ToInt32(txtOwn_tel.Text);

            //pet
            pet_name = txtPet_name.Text;
            pet_type = txtPet_type.Text;
            description = txtDescription.Text;
            status = txtStatus.Text;

            pet_num = Convert.ToInt32(txtPet_num.Text);

            dob = dateTimePicker1.Value;
            date_reg = dateTimePicker2.Value;


           //call method
           ////////////////////////////////////////////////////////

          ////////////////////////////////////////////////////////



        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}

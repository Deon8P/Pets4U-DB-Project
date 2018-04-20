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
    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int appoint_num, own_num, tel_num, pet_num;
            string own_fname, own_lname, pet_name, pet_type;
            DateTime appoint_time;
            DateTime date;

            appoint_num = Convert.ToInt32(txtAppoint_num.Text);
            own_num = Convert.ToInt32(txtOwn_num.Text);
            tel_num = Convert.ToInt32(txtTel.Text);
            pet_num = Convert.ToInt32(txtPet_number.Text);

            own_fname = txtOwn_FName.Text;
            own_lname = txtOwn_LName.Text;
            pet_name = txtPet_name.Text;
            pet_type = txtPet_type.Text;

            appoint_time = Convert.ToDateTime(txtTime.Text);

            date = dateTimePicker1.Value;




            //call method
            /////////////////////////////////////////////////////////////

            /////////////////////////////////////////////////////////////



        }
    }
}

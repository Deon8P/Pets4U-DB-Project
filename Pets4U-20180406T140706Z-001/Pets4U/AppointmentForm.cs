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
    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
        }

        Database_Class database = new Database_Class();
        public MySqlConnection connection;
        public MySqlDataAdapter adapter;
        public DataSet ds;


        private void button1_Click(object sender, EventArgs e)
        {
            int appoint_num, own_num, pet_num, clinicNum;
            string own_fname, own_lname, pet_name, pet_type, appoint_time, tel_num;
            DateTime date;

            if (!txtAppointmentNum.Text.Equals("") || !txtOwn_FName.Text.Equals("") || !txtOwn_LName.Text.Equals("") ||
                !txtOwn_num.Text.Equals("") || !txtPet_name.Text.Equals("") || !txtPet_number.Text.Equals("") ||
                !txtPet_type.Text.Equals("") || !txtTel.Text.Equals("") || cmbClinicNumber.SelectedValue != null ||
                comboBox1.SelectedIndex != -1)
            {
                appoint_num = Convert.ToInt32(txtAppointmentNum.Text);
                own_num = Convert.ToInt32(txtOwn_num.Text);
                tel_num = txtTel.Text;
                pet_num = Convert.ToInt32(txtPet_number.Text);
                clinicNum = Convert.ToInt32(cmbClinicNumber.SelectedValue.ToString());
                own_fname = txtOwn_FName.Text;
                own_lname = txtOwn_LName.Text;
                pet_name = txtPet_name.Text;
                pet_type = txtPet_type.Text;

                appoint_time = comboBox1.SelectedItem.ToString(); ;

                date = dateTimePicker1.Value;

                //call method
                database.insert_appointment(appoint_num, own_num, own_lname, own_fname, tel_num, pet_num, pet_name, pet_type, date, appoint_time, clinicNum);
                this.Close();
            }
            else
                MessageBox.Show("Some Info is still needed");
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            try
            {
                connection = database.connection;
                connection.Open();

                adapter = new MySqlDataAdapter("SELECT Clinic_Number FROM clinic", connection);

                ds = new DataSet();

                adapter.Fill(ds, "clinic");

                cmbClinicNumber.DisplayMember = "Clinic_Number";
                cmbClinicNumber.ValueMember = "Clinic_Number";
                cmbClinicNumber.DataSource = ds.Tables["clinic"];
                cmbClinicNumber.SelectedIndex = -1;
            }
            catch (System.Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void AppointmentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SecretariesForm form = new SecretariesForm();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

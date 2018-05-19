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
    public partial class RegisterPetFrom : Form
    {
        public RegisterPetFrom()
        {
            InitializeComponent();
        }

        Database_Class database = new Database_Class();

        public MySqlConnection connection;
        public MySqlDataAdapter adapter;
        public DataSet ds;

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string own_fname, own_lname, own_address, pet_name, pet_type, description, status, city, state, own_tel;
            int own_ID, zipCode, pet_num, clinicNum;
            DateTime dob, date_reg;

            if (!txtCity.Text.Equals("") || !txtDescription.Text.Equals("") || !txtOwn_Address.Text.Equals("") ||
               !txtOwn_FName.Text.Equals("") || !txtOwn_ID.Text.Equals("") || !txtOwn_LName.Text.Equals("") ||
               !txtOwn_tel.Text.Equals("") || !txtPet_name.Text.Equals("") || !txtPet_num.Text.Equals("") ||
               !txtPet_type.Text.Equals("") || !txtState.Text.Equals("") || !txtStatus.Text.Equals("") ||
               !txtZip.Text.Equals("") || cmbCliniNumber.SelectedValue != null)
            {
                //owner
                own_fname = txtOwn_FName.Text;
                own_lname = txtOwn_LName.Text;
                own_address = txtOwn_Address.Text;
                city = txtCity.Text;
                state = txtState.Text;
                clinicNum = Convert.ToInt32(cmbCliniNumber.SelectedValue.ToString());
                zipCode = Convert.ToInt32(txtZip.Text);
                own_ID = Convert.ToInt32(txtOwn_ID.Text);
                own_tel = txtOwn_tel.Text;

                //pet
                pet_name = txtPet_name.Text;
                pet_type = txtPet_type.Text;
                description = txtDescription.Text;
                status = txtStatus.Text;
                pet_num = Convert.ToInt32(txtPet_num.Text);
                dob = dateTimePicker1.Value;
                date_reg = dateTimePicker2.Value;

                //call methods
                database.insert_pet_owner(own_ID, own_lname, own_fname, own_address, city, state, zipCode, own_tel, pet_name, clinicNum);
                database.insert_pet(pet_num, pet_name, pet_type, description, dob, date_reg, status, own_ID, clinicNum);
                clear();
            }
            else
                MessageBox.Show("Please enter values in all fields");

        }

        public void clear()
        {
            txtCity.Clear();
            txtDescription.Clear();
            txtOwn_Address.Clear();
            txtOwn_FName.Clear();
            txtOwn_ID.Clear();
            txtOwn_LName.Clear();
            txtOwn_tel.Clear();
            txtPet_name.Clear();
            txtPet_num.Clear();
            txtPet_type.Clear();
            txtState.Clear();
            txtStatus.Clear();
            txtZip.Clear();
            cmbCliniNumber.SelectedIndex = -1;
        }

        private void RegisterPetFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            SecretariesForm SecForm = new SecretariesForm();
            SecForm.Show();
        }

        private void RegisterPetFrom_Load(object sender, EventArgs e)
        {
            try
            {
                connection = database.connection;
                connection.Open();

                adapter = new MySqlDataAdapter("SELECT Clinic_Number FROM clinic", connection);

                ds = new DataSet();

                adapter.Fill(ds, "clinic");

                cmbCliniNumber.DisplayMember = "Clinic_Number";
                cmbCliniNumber.ValueMember = "Clinic_Number";
                cmbCliniNumber.DataSource = ds.Tables["clinic"];
                cmbCliniNumber.SelectedIndex = -1;
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
    }
}

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
    public partial class ExaminationFom : Form
    {
        public ExaminationFom()
        {
            InitializeComponent();
        }

        Database_Class database = new Database_Class();

        public MySqlConnection connection;
        public MySqlDataAdapter adapter;
        public DataSet ds;
        public string query;

        private void button7_Click(object sender, EventArgs e)
        {
            Database_Class db = new Database_Class();

            string vetname, petName, petType, desctiption;
            int examNum;
            int staff_number = 0;
            int pet_number = 0;
            string examDate, examTime;

            Random ran = new Random();

            vetname = txtVetFName.Text;
            petName = txtPet_name.Text;
            petType = txtTypePet.Text;
            examTime = txtTime.Text;
            desctiption = richTextBox1.Text;

          

            examDate = dateTimePicker1.Value.ToString();
            examDate = examDate.Substring(0, 10).Replace('/', '-');

            if (cmbStaffNum.SelectedItem != null)
            {
                staff_number = int.Parse(cmbStaffNum.SelectedItem.ToString());
            }

            if (cmbPetNum.SelectedItem != null)
            {
                pet_number = int.Parse(cmbPetNum.SelectedItem.ToString());
            }

            examNum = staff_number + pet_number + ran.Next(111, 999);



            db.insert_examination(examNum, examDate, examTime, vetname, pet_number,
                             petName, petType, desctiption, staff_number);



            TreatmentReportForm treatmentForm = new TreatmentReportForm();
            treatmentForm.ShowDialog();
            this.Close();
                

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ExaminationFom_Load(object sender, EventArgs e)
        {
            try
            {
                connection = database.connection;
                connection.Open();

                adapter = new MySqlDataAdapter("SELECT Staff_Number FROM staff", connection);

                ds = new DataSet();

                adapter.Fill(ds, "staff");

                cmbStaffNum.DisplayMember = "Staff_Number";
                cmbStaffNum.ValueMember = "Staff_Number";
                cmbStaffNum.DataSource = ds.Tables["staff"];
                cmbStaffNum.SelectedIndex = -1;
            }
            catch (System.Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }

            try
            {
                connection = database.connection;
                connection.Open();

                adapter = new MySqlDataAdapter("SELECT Pet_Number FROM pet", connection);

                ds = new DataSet();

                adapter.Fill(ds, "pet");

                cmbPetNum.DisplayMember = "Pet_Number";
                cmbPetNum.ValueMember = "Pet_Number";
                cmbPetNum.DataSource = ds.Tables["pet"];
                cmbPetNum.SelectedIndex = -1;
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

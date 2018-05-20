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
    public partial class ExaminationForm : Form
    {
        public ExaminationForm()
        {
            InitializeComponent();
        }

        Database_Class database = new Database_Class();

        public MySqlConnection connection;
        public MySqlCommand cmd;
        public MySqlDataAdapter adapter;
        public DataSet ds;
        public string query;
        public bool loadedState = false;

        private void button7_Click(object sender, EventArgs e)
        {
            Database_Class db = new Database_Class();
            
            string vetname, petName, petType, desctiption;
            string examNum;
            string staff_number = "TestValue";
            int pet_number = 0;
            string examDate, examTime;

            Random ran = new Random();

            vetname = txtVetFName.Text;
            petName = lblPetName.Text;
            petType = lblTypeOfPet.Text;
            examTime = txtTime.Text;
            desctiption = richTextBox1.Text;

          

            examDate = dateTimePicker1.Value.ToString();
            examDate = examDate.Substring(0, 10).Replace('/', '-');
            MessageBox.Show(examDate.ToString());

            if (cmbStaffNum.SelectedItem != null)
            {
                try
                {
                    staff_number = cmbStaffNum.SelectedValue.ToString();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
                finally
                {
                    cmbStaffNum.SelectedIndex = -1;
                }
            }

            if (cmbPetNum.SelectedItem != null)
            {
                try
                {
                    pet_number = Convert.ToInt32(cmbPetNum.SelectedValue);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
                finally
                {
                    cmbPetNum.SelectedIndex = -1;
                }
            }

            examNum = staff_number + pet_number + ran.Next(1111, 9999);



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
            richTextBox1.Text = "";
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

                cmbPetNum.ValueMember = "Pet_Number";
                cmbPetNum.DisplayMember = "Pet_Number";
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

            loadedState = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbPetNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loadedState == true)
            {

                if (cmbPetNum.SelectedIndex >= 0)
                {
                    DialogResult result = MessageBox.Show("Are you sure you wish to retrieve the name of pet " + cmbPetNum.SelectedValue.ToString() + "?", "Retrieve Pet Name", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            connection = database.connection;
                            connection.Open();

                            cmd = new MySqlCommand("SELECT Pet_Name FROM pet WHERE Pet_Number = " + cmbPetNum.SelectedValue.ToString() + " ", connection);

                            lblPetName.Text = cmd.ExecuteScalar().ToString();

                            cmd = new MySqlCommand("SELECT Pet_Type FROM pet WHERE Pet_Number = " + cmbPetNum.SelectedValue.ToString() + " ", connection);

                            lblTypeOfPet.Text = cmd.ExecuteScalar().ToString();
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
                    else
                    {
                        cmbPetNum.SelectedIndex = -1;
                        lblPetName.Text = "Please select a \"Pet number\".";
                        lblTypeOfPet.Text = "Please select a \"Pet number\".";
                    }
                }
            }
        }

        private void txtTypePet_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTypeOfPet_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

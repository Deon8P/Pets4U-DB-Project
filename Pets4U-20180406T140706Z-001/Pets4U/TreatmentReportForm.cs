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
    public partial class TreatmentReportForm : Form
    {
        Database_Class database = new Database_Class();

        public MySqlConnection connection;
        public MySqlCommand cmd;
        public MySqlDataAdapter adapter;
        public DataSet ds;
        public string query;
        public bool loadedState = false;
        public int petNumber, treatmentQuantity;
        public string examinationNumber, examinationDate, petName, petType, treatmentNumber,
                dateTreatmentBegin, dateTreatmentEnd, additionalComments, fullTreatmentDescription;

        private void txtDescriptionOfTreatment_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdditionalComments_TextChanged(object sender, EventArgs e)
        {
            if (txtAdditionalComments.TextLength > 0)
            {
                btnCreateTreatment.Enabled = true;
                lblReqD.Text = txtAdditionalComments.TextLength.ToString();
            }
            else
            {
                btnCreateTreatment.Enabled = false;
                lblReqD.Visible = true;
                lblReqD.Text = "*";
            }
        }

        public TreatmentReportForm()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void TreatmentReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                connection = database.connection;
                connection.Open();

                adapter = new MySqlDataAdapter("SELECT Examination_Number FROM examination", connection);

                ds = new DataSet();

                adapter.Fill(ds, "examination");

                cmbExaminationNumber.DisplayMember = "Examination_Number";
                cmbExaminationNumber.ValueMember = "Examination_Number";
                cmbExaminationNumber.DataSource = ds.Tables["examination"];
                cmbExaminationNumber.SelectedIndex = -1;
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

                adapter = new MySqlDataAdapter("SELECT Treatment_Number FROM treatments", connection);

                ds = new DataSet();

                adapter.Fill(ds, "treatments");

                cmbTreatmentNumber.DisplayMember = "Treatment_Number";
                cmbTreatmentNumber.ValueMember = "Treatment_Number";
                cmbTreatmentNumber.DataSource = ds.Tables["treatments"];
                cmbTreatmentNumber.SelectedIndex = -1;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }

            loadedState = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            additionalComments = txtAdditionalComments.Text;
            database.insert_pet_treatments(examinationNumber, petNumber, examinationDate, petName, petType, treatmentNumber, treatmentQuantity, dateTreatmentBegin, dateTreatmentEnd, additionalComments);
        }

        private void cmbExaminationNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loadedState == true)
            {

                if (cmbExaminationNumber.SelectedIndex >= 0)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want \nto retrieve the details of examination: " + cmbExaminationNumber.SelectedValue.ToString(), "Retrieve Examination Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            connection = database.connection;
                            connection.Open();

                            cmd = new MySqlCommand("SELECT Examination_Date FROM examination WHERE Examination_Number = '" + cmbExaminationNumber.SelectedValue.ToString() + "'", connection);

                            lblExaminationDate.Text = cmd.ExecuteScalar().ToString().Substring(0, 10).Replace('/', '-');
                            
                            cmd = new MySqlCommand("SELECT Pet_Number FROM examination WHERE Examination_Number = '" + cmbExaminationNumber.SelectedValue.ToString() + "'", connection);

                            lblPetNumber.Text = cmd.ExecuteScalar().ToString();

                            cmd = new MySqlCommand("SELECT Pet_Name FROM examination WHERE Examination_Number = '" + cmbExaminationNumber.SelectedValue.ToString() + "'", connection);

                            lblPetName.Text = cmd.ExecuteScalar().ToString();

                            cmd = new MySqlCommand("SELECT Pet_Type FROM examination WHERE Examination_Number = '" + cmbExaminationNumber.SelectedValue.ToString() + "'", connection);

                            lblPetType.Text = cmd.ExecuteScalar().ToString();
                        }
                        catch (System.Exception exc)
                        {
                            MessageBox.Show(exc.Message);
                        }
                        finally
                        {
                            connection.Close();

                        }

                        if (cmbTreatmentNumber.SelectedIndex >= 0)
                        {
                            btnTreatmentDescription.Enabled = true;
                        }
                    }
                    else
                    {
                        cmbExaminationNumber.SelectedIndex = -1;
                        lblExaminationDate.Text = "Please select an \"Examination Number\".";
                        lblPetNumber.Text = "Please select a \"Examination Number\".";
                        lblPetName.Text = "Please select a \"Examination Number\".";
                        lblPetType.Text = "Please select a \"Examination Number\".";

                        btnTreatmentDescription.Enabled = false;
                    }
                }
            }
        }

        private void cmbTreatmentNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loadedState == true)
            {

                if (cmbTreatmentNumber.SelectedIndex >= 0)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want \nto retrieve the details of treatment: " + cmbTreatmentNumber.SelectedValue.ToString(), "Retrieve Treatment Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            connection = database.connection;
                            connection.Open();

                            cmd = new MySqlCommand("SELECT Treatment_Description FROM treatments WHERE Treatment_Number = '" + cmbTreatmentNumber.SelectedValue.ToString() + "'", connection);

                            lblDescription.Text = cmd.ExecuteScalar().ToString();
                        }
                        catch (System.Exception exc)
                        {
                            MessageBox.Show(exc.Message);
                        }
                        finally
                        {
                            connection.Close();

                        }

                        if (cmbExaminationNumber.SelectedIndex >= 0)
                        {
                            btnTreatmentDescription.Enabled = true;
                        }
                    }
                    else
                    {
                        cmbTreatmentNumber.SelectedIndex = -1;
                        lblDescription.Text = "Please select a \"Treatment Number\".";
                        
                        btnTreatmentDescription.Enabled = false;
                    }
                }
            }
        }

        private void btnTreatmentDescription_Click(object sender, EventArgs e)
        {
            txtAdditionalComments.Enabled = true;

            

            examinationNumber = cmbExaminationNumber.SelectedValue.ToString();
            examinationDate = lblExaminationDate.Text;
            petNumber = Convert.ToInt32(lblPetNumber.Text);
            petName = lblPetName.Text;
            petType = lblPetType.Text;
            treatmentNumber = cmbTreatmentNumber.SelectedValue.ToString();
            treatmentQuantity = Convert.ToInt32(numQuantityOfTreatment.Value);
            dateTreatmentBegin = calBeginTreatment.Value.ToString().Substring(0, 10).Replace('/', '-');
            dateTreatmentEnd = calEndTreatment.Value.ToString().Substring(0, 10).Replace('/', '-');

            fullTreatmentDescription = "Examination Number: " + examinationNumber +
                                        "\nExamination Date: " + examinationDate +
                                        "\nPet Number: " + petNumber +
                                        "\nPet Name: " + petName +
                                        "\nPet Type:" + petType +
                                        "\nTreatment Number: " + treatmentNumber +
                                        "\nTreatment Quantity: " + treatmentQuantity +
                                        "\nBeginning Date of Treatment: " + dateTreatmentBegin +
                                        "\nEnd Date of Treatment: " + dateTreatmentEnd;

            txtDescriptionOfTreatment.Text = fullTreatmentDescription;
            txtAdditionalComments.Enabled = true;
            btnCreateTreatment.Enabled = true;
        }
    }
}

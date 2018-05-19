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
    public partial class BookPenForm : Form
    {
        public BookPenForm()
        {
            InitializeComponent();
        }

        Database_Class database = new Database_Class();

        public string penStatus;

        public MySqlConnection connection;
        public MySqlDataAdapter adapter;
        public DataSet ds;

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BookPenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SecretariesForm form = new SecretariesForm();
            form.Show();
        }

        private void BookPenForm_Load(object sender, EventArgs e)
        {
            cmbPen();
            cmbClin();
        }

        public void cmbPen()
        {
            try
            {
                connection = database.connection;
                connection.Open();

                adapter = new MySqlDataAdapter("SELECT DISTINCT Pen_Number FROM pens WHERE Pen_Status = 'Open'", connection);

                ds = new DataSet();

                adapter.Fill(ds, "pens");

                cmbPenNumber.DisplayMember = "Pen_Number";
                cmbPenNumber.ValueMember = "Pen_Number";
                cmbPenNumber.DataSource = ds.Tables["pens"];
                //cmbPenNumber.SelectedIndex = -1;
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

        public void cmbClin()
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

        public string PenStat()
        {
            return penStatus = database.getStatus(Convert.ToInt32(cmbPenNumber.SelectedValue.ToString()));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int penNumber, penCap, petNumber, clinicNumber;
            string petComments;
            DateTime DateIN, DateOUT;

            penNumber = Convert.ToInt32(cmbPenNumber.SelectedValue.ToString());
            penCap = 4;
            petNumber = Convert.ToInt32(txtPNum.Text);
            petComments = rtbComments.Text;
            DateIN = dateTimePicker1.Value;
            DateOUT = dateTimePicker2.Value;
            clinicNumber = Convert.ToInt32(cmbClinicNumber.SelectedValue.ToString());

            database.BookPen(penNumber, penCap, penStatus, petNumber, petComments, DateIN, DateOUT, clinicNumber);

            this.Close();
        }

        private void cmbPenNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            PenStat();
            txtStat.Text = penStatus;   
        }
    }

   
}

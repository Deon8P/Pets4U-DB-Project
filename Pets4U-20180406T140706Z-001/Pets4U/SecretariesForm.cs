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
    public partial class SecretariesForm : Form
    {
        public SecretariesForm()
        {
            InitializeComponent();
        }

        Database_Class database = new Database_Class();

        public MySqlConnection connection;
        public MySqlDataAdapter adapter;
        public DataSet ds;

        public bool flag = false;

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag = true;
            RegisterPetFrom RegPetForm = new RegisterPetFrom();
            RegPetForm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flag = true;
            BookPenForm BookForm = new BookPenForm();
            BookForm.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            flag = true;
            AddSurgicalSuppForm AddSurSupp = new AddSurgicalSuppForm();
            AddSurSupp.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            flag = true;
            AddNonSurgicalSuppForm NonSurSuppForm = new AddNonSurgicalSuppForm();
            NonSurSuppForm.Show();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            flag = true;
            AddPharmacticalSuppForm PharmSuppForm = new AddPharmacticalSuppForm();
            PharmSuppForm.Show();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            flag = true;
            AppointmentForm AppForm = new AppointmentForm();
            AppForm.Show();
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            flag = true;
            InvoiceForm InvoiceFForm = new InvoiceForm();
            InvoiceFForm.Show();
            this.Close();
        }

        private void SecretariesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag == false)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                connection = database.connection;
                connection.Open();
                adapter = new MySqlDataAdapter("SELECT * FROM appointment", connection);

                ds = new DataSet();

                adapter.Fill(ds, "appointment");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "appointment";

                lblDisplayGW.Text = "Appointments";
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void BookingReportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection = database.connection;
                connection.Open();
                adapter = new MySqlDataAdapter("SELECT * FROM pet", connection);

                ds = new DataSet();

                adapter.Fill(ds, "pet");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "pet";

                lblDisplayGW.Text = "pet";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connection = database.connection;
                connection.Open();
                adapter = new MySqlDataAdapter("SELECT DISTINCT Pen_Number FROM pens WHERE Pen_Status = 'Closed'", connection);

                ds = new DataSet();

                adapter.Fill(ds, "pens");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "pens";

                lblDisplayGW.Text = "Booked Pens";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                connection = database.connection;
                connection.Open();
                adapter = new MySqlDataAdapter("SELECT * FROM surgical_supplies", connection);

                ds = new DataSet();

                adapter.Fill(ds, "surgical_supplies");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "surgical_supplies";

                lblDisplayGW.Text = "Surgical Supplies";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                connection = database.connection;
                connection.Open();
                adapter = new MySqlDataAdapter("SELECT * FROM non_surgical_supplies", connection);

                ds = new DataSet();

                adapter.Fill(ds, "non_surgical_supplies");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "non_surgical_supplies";

                lblDisplayGW.Text = "Non Surgical Supplies";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                connection = database.connection;
                connection.Open();
                adapter = new MySqlDataAdapter("SELECT * FROM pharma_supplies", connection);

                ds = new DataSet();

                adapter.Fill(ds, "pharma_supplies");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "pharma_supplies";

                lblDisplayGW.Text = "Pharmasutical Supplies";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connection = database.connection;
                connection.Open();
                adapter = new MySqlDataAdapter("SELECT * FROM staff", connection);

                ds = new DataSet();

                adapter.Fill(ds, "staff");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "staff";

                lblDisplayGW.Text = "Employees";
            }
            catch (Exception exc)
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

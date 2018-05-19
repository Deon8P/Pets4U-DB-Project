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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        Database_Class database = new Database_Class();

        public MySqlConnection connection;
        public MySqlDataAdapter adapter;
        public DataSet ds;

        bool flag = false;

        private void button13_Click(object sender, EventArgs e)
        {
            flag = true;
            ExaminationFom ExamForm = new ExaminationFom();
            ExamForm.Show();
            this.Close();
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
                adapter = new MySqlDataAdapter("SELECT * FROM pharm_supplies", connection);

                ds = new DataSet();

                adapter.Fill(ds, "pharm_supplies");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "pharm_supplies";

                lblDisplayGW.Text = "Pharm Supplies";
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

        private void ManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(flag == false)
            {
                LoginForm login = new LoginForm();
                login.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            flag = false;
            this.Close();
        }
    }
}

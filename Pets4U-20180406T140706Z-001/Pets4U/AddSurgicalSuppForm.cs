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
    public partial class AddSurgicalSuppForm : Form
    {
        public AddSurgicalSuppForm()
        {
            InitializeComponent();
        }

        Database_Class database = new Database_Class();

        public MySqlConnection connection;
        public MySqlDataAdapter adapter;
        public DataSet ds;
        public string query;

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void AddSurgicalSuppForm_Load(object sender, EventArgs e)
        {
            try
            {
                connection = database.connection;
                connection.Open();

                adapter = new MySqlDataAdapter("SELECT Clinic_Number FROM clinic", connection);

                ds = new DataSet();

                adapter.Fill(ds, "clinic");

                cmbClinicNum.DisplayMember = "Clinic_Number";
                cmbClinicNum.ValueMember = "Clinic_Number";
                cmbClinicNum.DataSource = ds.Tables["clinic"];
                cmbClinicNum.SelectedIndex = -1;
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database_Class db = new Database_Class();

            string item_name, item_description;
            int item_num;
            double item_cost;

            int clinic_num = 0;
            int reorder_lvl = 0;
            int reorder_quantity = 0;
            int quantity = 0;

            item_name = txtItemName.Text;
            item_description = txtItemDescription.Text;

            item_num = Convert.ToInt32(txtItemNumber.Text);
            


            if (cmbQuantity.SelectedItem != null)
            {
                quantity = int.Parse(cmbQuantity.SelectedItem.ToString());
            }

            if (cmbReorderLevel.SelectedItem != null)
            {
                reorder_lvl = int.Parse(cmbReorderLevel.SelectedItem.ToString());
            }

            if (cmbReorderQuantity.SelectedItem != null)
            {
                reorder_quantity = int.Parse(cmbReorderQuantity.SelectedItem.ToString());
            }

            if (cmbClinicNum.SelectedItem != null)
            {
                clinic_num = int.Parse(cmbClinicNum.SelectedItem.ToString());
            }

            item_cost = Convert.ToDouble(txtItemCost.Text);

          
            if (!txtItemName.Text.Equals(null) || !txtItemDescription.Equals(null) || !txtItemNumber.Equals(null) || !txtItemCost.Equals(null) || cmbQuantity.SelectedItem != null || cmbReorderLevel.SelectedItem != null || cmbReorderQuantity.SelectedItem != null || cmbClinicNum.SelectedItem != null || cmbClinicNum.SelectedItem != null)
            {
                db.insert_surgical_supplies(item_num, clinic_num, item_name, item_description, quantity, reorder_lvl, reorder_quantity, item_cost);
            }
            else
            {
                MessageBox.Show("Please enter all required information", "Surgical Supplies", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cmbReorderQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

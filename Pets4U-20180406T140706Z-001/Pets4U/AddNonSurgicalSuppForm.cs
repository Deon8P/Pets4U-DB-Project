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
    public partial class AddNonSurgicalSuppForm : Form
    {
        public AddNonSurgicalSuppForm()
        {
            InitializeComponent();
        }

        Database_Class database = new Database_Class();

        public MySqlConnection connection;
        public MySqlDataAdapter adapter;
        public DataSet ds;
        public string query;

        private void AddNonSurgicalSuppForm_Load(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            SecretariesForm SecForm = new SecretariesForm();
            SecForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database_Class db = new Database_Class();

            string item_name, item_description;

            int item_num = 0; 
            int clinic_number = 0;
            int quantity = 0;
            int reorder_level = 0;
            int reorder_quantity = 0;

            double item_cost = 0;

            item_name = txtItemName.Text;
            item_description = txtItemDescription.Text;

            item_num = Convert.ToInt32(txtItem_num.Text);

           
            if (cmbQuantity.SelectedItem != null)
            {
                quantity = int.Parse(cmbQuantity.SelectedItem.ToString());
            }

            if (cmbReorderLevel.SelectedItem != null)
            {
                reorder_level = int.Parse(cmbReorderLevel.SelectedItem.ToString());
            }

            if (cmbReorderQuantity.SelectedItem != null)
            {
                reorder_quantity = int.Parse(cmbReorderQuantity.SelectedItem.ToString());
            }

            if (cmbClinicNum.SelectedValue != null)
            {
                clinic_number = int.Parse(cmbClinicNum.SelectedValue.ToString());
            }


            item_cost = Convert.ToDouble(txtItemCost.Text);

          
            if (!txtItemName.Text.Equals(null) || !txtItemDescription.Equals(null) || !txtItem_num.Equals(null) || !txtItemCost.Equals(null) || cmbQuantity.SelectedItem != null || cmbReorderLevel.SelectedItem != null || cmbReorderQuantity.SelectedItem != null || cmbClinicNum.SelectedValue != null)
            {
                db.insert_non_surgical_supplies(item_num, item_name, item_description, quantity, reorder_level, reorder_quantity, item_cost, clinic_number);
            }
            else
            {
                MessageBox.Show("Please enter all required information", "Non-Surgical Supplies", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }  

    }
}

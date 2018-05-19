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
    public partial class AddPharmacticalSuppForm : Form
    {
        public AddPharmacticalSuppForm()
        {
            InitializeComponent();
        }

        Database_Class database = new Database_Class();

        public MySqlConnection connection;
        public MySqlDataAdapter adapter;
        public DataSet ds;
        public string query;


        private void AddPharmacticalSuppForm_Load(object sender, EventArgs e)
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database_Class db = new Database_Class();

            int drug_num;
            int clinic_number = 0;
            int quantity_stock = 0;
            int reorder_lvl = 0;
            int reorder_quantity = 0;


            string drug_name, drug_description, method_admin;
            double dosage, drug_cost;

            drug_name = txtDrugName.Text;
            drug_description = txtDrugDescription.Text;
            method_admin = txtMethodAdministration.Text;

            drug_num = Convert.ToInt32(txtDrugNum.Text);
          
            if (cmbQuantity_In_Stock.SelectedItem != null)
            {
                quantity_stock = int.Parse(cmbQuantity_In_Stock.SelectedItem.ToString());
            }

            if (cmbReorder_lvl.SelectedItem != null)
            {
                reorder_lvl = int.Parse(cmbReorder_lvl.SelectedItem.ToString());
            }

            if (cmb_Drug_Quantity.SelectedItem != null)
            {
                reorder_quantity = int.Parse(cmb_Drug_Quantity.SelectedItem.ToString());
            }

            if (cmbClinicNumber.SelectedItem != null)
            {
                clinic_number = int.Parse(cmbClinicNumber.SelectedItem.ToString());
            }


            dosage = Convert.ToDouble(txtDosage.Text);
            drug_cost = Convert.ToDouble(txtDrugCost.Text);


            if (!txtDrugName.Text.Equals(null) || !txtDrugDescription.Text.Equals(null) || !txtMethodAdministration.Text.Equals(null) || cmbQuantity_In_Stock.SelectedItem != null || cmbReorder_lvl.SelectedItem != null || cmbClinicNumber.SelectedItem != null || cmb_Drug_Quantity != null || !txtDosage.Text.Equals(null) || !txtDrugCost.Text.Equals(null))
            {
                db.insert_pharma_supplies(drug_num, clinic_number, drug_name, drug_description, dosage, method_admin, quantity_stock, reorder_lvl, reorder_quantity, drug_cost);
            }
            else
            {
                MessageBox.Show("Please enter all required information", "Pharmacutical Supplies", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}

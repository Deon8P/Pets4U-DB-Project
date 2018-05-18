using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pets4U
{
    public partial class AddPharmacticalSuppForm : Form
    {
        public AddPharmacticalSuppForm()
        {
            InitializeComponent();
        }

      

        private void AddPharmacticalSuppForm_Load(object sender, EventArgs e)
        {
          

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database_Class db = new Database_Class();

            int drug_num,clinic_number;

            int quantity_stock = 0;
            int reorder_lvl = 0;
            int drug_quantity = 0;


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
                drug_quantity = int.Parse(cmb_Drug_Quantity.SelectedItem.ToString());
            }


            dosage = Convert.ToDouble(txtDosage.Text);
            drug_cost = Convert.ToDouble(txtDrugCost.Text);
            clinic_number = Convert.ToInt32(txtClinicNumber.Text);


            db.insert_pharma_supplies(drug_num, clinic_number, drug_name, drug_description, dosage, method_admin, quantity_stock, reorder_lvl, drug_quantity, drug_cost);


        }
    }
}

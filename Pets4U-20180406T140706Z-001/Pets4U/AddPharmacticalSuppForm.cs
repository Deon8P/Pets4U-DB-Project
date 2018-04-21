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
            int drug_num, quantity_stock, reorder_lvl, reorder_quantity;

            string drug_name, drug_description, method_admin;
            double dosage, drug_cost;

            drug_name = txtDrugName.Text;
            drug_description = txtDrugDescription.Text;
            method_admin = txtMethodAdministration.Text;

            drug_num = Convert.ToInt32(txtDrugNum.Text);
            quantity_stock = Convert.ToInt32(txtQuantityStock.Text);
            reorder_quantity = Convert.ToInt32(txtReorderQuantity.Text);
            reorder_lvl = Convert.ToInt32(txtReorderLvl.Text);

            dosage = Convert.ToDouble(txtDosage.Text);
            drug_cost = Convert.ToDouble(txtDrugCost.Text);

        }
    }
}

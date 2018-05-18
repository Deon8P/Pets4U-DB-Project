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
    public partial class AddSurgicalSuppForm : Form
    {
        public AddSurgicalSuppForm()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void AddSurgicalSuppForm_Load(object sender, EventArgs e)
        {

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
            int item_num, clinic_num;
            double item_cost;

            int reorder_lvl = 0;
            int quantity = 0;

            item_name = txtItemName.Text;
            item_description = txtItemDescription.Text;

            item_num = Convert.ToInt32(txtItemNumber.Text);
            clinic_num = Convert.ToInt32(txtClinicNumber.Text);


            if (cmbQuantity.SelectedItem != null)
            {
                quantity = int.Parse(cmbQuantity.SelectedItem.ToString());
            }

            if (cmbReorderLevel.SelectedItem != null)
            {
                reorder_lvl = int.Parse(cmbReorderLevel.SelectedItem.ToString());
            }

            item_cost = Convert.ToDouble(txtItemCost.Text);

            //call method
            ///////////////////////////////////////////////////////////////////
            db.insert_surgical_supplies(item_num, clinic_num, item_name, item_description, quantity, reorder_lvl, item_cost);
            ///////////////////////////////////////////////////////////////////
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cmbReorderQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

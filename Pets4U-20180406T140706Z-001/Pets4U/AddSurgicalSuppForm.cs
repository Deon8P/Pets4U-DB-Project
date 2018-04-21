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
            string item_name, item_description;
            int item_num, reorder_level, reoreder_quantity, quantity;
            double item_cost;

            item_name = txtItemName.Text;
            item_description = txtItemDescription.Text;

            item_num = Convert.ToInt32(txtItemNumber.Text);


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
                reoreder_quantity = int.Parse(cmbReorderQuantity.SelectedItem.ToString());
            }

            item_cost = Convert.ToDouble(txtItemCost.Text);

            //call method
            ///////////////////////////////////////////////////////////////////

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

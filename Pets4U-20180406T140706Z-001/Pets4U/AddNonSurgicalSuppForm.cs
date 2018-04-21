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
    public partial class AddNonSurgicalSuppForm : Form
    {
        public AddNonSurgicalSuppForm()
        {
            InitializeComponent();
        }

        private void AddNonSurgicalSuppForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SecretariesForm SecForm = new SecretariesForm();
            SecForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string item_name, item_description;
            int item_num,reorder_level, reoreder_quantity, quantity;
            double item_cost;

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
                reoreder_quantity = int.Parse(cmbReorderQuantity.SelectedItem.ToString());
            }

            //call method
            ///////////////////////////////////////////////////////////////////

            ///////////////////////////////////////////////////////////////////



        }  

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}

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
            Database_Class db = new Database_Class();

            string item_name, item_description;

            int item_num, clinic_number;
            int quantity = 0;
            int reorder_level = 0;

            double item_cost;

            item_name = txtItemName.Text;
            item_description = txtItemDescription.Text;

            item_num = Convert.ToInt32(txtItem_num.Text);

            clinic_number = Convert.ToInt32(txtClinicNumber.Text);
            

            if (cmbQuantity.SelectedItem != null)
            {
                quantity = int.Parse(cmbQuantity.SelectedItem.ToString());
            }

            if (cmbReorderLevel.SelectedItem != null)
            {
                reorder_level = int.Parse(cmbReorderLevel.SelectedItem.ToString());
            }


            item_cost = Convert.ToDouble(txtItemCost.Text);

            //call method
            ///////////////////////////////////////////////////////////////////
            db.insert_non_surgical_supplies(item_num, item_name, item_description, quantity, reorder_level, item_cost, clinic_number);

            ///////////////////////////////////////////////////////////////////



        }  

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}

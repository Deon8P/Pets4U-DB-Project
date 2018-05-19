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
    public partial class SupplyUpdateForm : Form
    {
        public SupplyUpdateForm(string tableName)
        {
            InitializeComponent();
            table = tableName;
        }

        Database_Class database = new Database_Class();

        public MySqlConnection connection;
        public MySqlDataAdapter adapter;
        public DataSet ds;

        public string table, columnQ, columnN;

        public int amount, getamount;

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals("") || cmbItemName.SelectedValue != null)
            {
                columnQ = "Quantity_Of_Stock";

                if (table.Equals("pharma_supplies"))
                    columnQ = "Quantity_In_Stock";

                amount = Convert.ToInt32(textBox1.Text);

                getamount = database.getAmount(table, cmbItemName.SelectedValue.ToString(), columnQ, columnN);

                if (getamount == 0)
                {
                    MessageBox.Show("There are no supplies left");
                    clear();
                }
                else if (amount > getamount)
                {
                    MessageBox.Show("There are only " + getamount + " item(s) left");
                    clear();
                }
                else
                {
                    database.UpdateSupplies(table, (getamount - amount), cmbItemName.SelectedValue.ToString(), columnQ, columnN);
                    this.Close();
                }
            }
            else
                MessageBox.Show("please fill in values");
        }

        private void SupplyUpdateForm_Load(object sender, EventArgs e)
        {
             columnN = "Supply_Name";

            if (table.Equals("pharma_supplies"))
                columnN = "Drug_Name";

            try
            {
                connection = database.connection;
                connection.Open();

                adapter = new MySqlDataAdapter("SELECT "+ columnN +" FROM " + table, connection);

                ds = new DataSet();

                adapter.Fill(ds, table);

                cmbItemName.DisplayMember = columnN;
                cmbItemName.ValueMember = columnN;
                cmbItemName.DataSource = ds.Tables[table];
                cmbItemName.SelectedIndex = -1;
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

        public void clear()
        {
            textBox1.Clear();
            cmbItemName.SelectedIndex = -1;
        }
    }
}

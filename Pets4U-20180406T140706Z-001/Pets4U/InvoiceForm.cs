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
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InvoiceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            InvoiceSlipForm invoice = new InvoiceSlipForm();
            invoice.Show();
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {

        }
    }
}

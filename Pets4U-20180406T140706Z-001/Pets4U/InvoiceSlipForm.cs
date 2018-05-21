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
    public partial class InvoiceSlipForm : Form
    {
        public InvoiceSlipForm()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InvoiceSlipForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SecretariesForm form = new SecretariesForm();
            form.Show();
        }
    }
}

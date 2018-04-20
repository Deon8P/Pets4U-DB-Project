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
    public partial class SecretariesForm : Form
    {
        public SecretariesForm()
        {
            InitializeComponent();
        }

        public bool flag = false;

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag = true;
            RegisterPetFrom RegPetForm = new RegisterPetFrom();
            RegPetForm.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flag = true;
            BookPenForm BookForm = new BookPenForm();
            BookForm.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            flag = true;
            AddSurgicalSuppForm AddSurSupp = new AddSurgicalSuppForm();
            AddSurSupp.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            flag = true;
            AddNonSurgicalSuppForm NonSurSuppForm = new AddNonSurgicalSuppForm();
            NonSurSuppForm.ShowDialog();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            flag = true;
            AddPharmacticalSuppForm PharmSuppForm = new AddPharmacticalSuppForm();
            PharmSuppForm.ShowDialog();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            flag = true;
            AppointmentForm AppForm = new AppointmentForm();
            AppForm.ShowDialog();
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            flag = true;
            InvoiceForm InvoiceFForm = new InvoiceForm();
            InvoiceFForm.ShowDialog();
            this.Close();
        }

        private void SecretariesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag == false)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
            }
        }
    }
}

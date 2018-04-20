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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void SecretariesForm_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            RegisterClinicForm mainForm = new RegisterClinicForm();
            mainForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterPetFrom RegPetForm = new RegisterPetFrom();
            RegPetForm.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BookPenForm BookForm = new BookPenForm();
            BookForm.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddSurgicalSuppForm AddSurSupp = new AddSurgicalSuppForm();
            AddSurSupp.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddNonSurgicalSuppForm NonSurSuppForm = new AddNonSurgicalSuppForm();
            NonSurSuppForm.ShowDialog();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AddPharmacticalSuppForm PharmSuppForm = new AddPharmacticalSuppForm();
            PharmSuppForm.ShowDialog();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AppointmentForm AppForm = new AppointmentForm();
            AppForm.ShowDialog();
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            InvoiceForm InvoiceFForm = new InvoiceForm();
            InvoiceFForm.ShowDialog();
            this.Close();

        }
    }
}

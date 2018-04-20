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
    public partial class RegisterClinicForm : Form
    {
        public RegisterClinicForm()
        {
            InitializeComponent();
        }

        private void RegisterClinicForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm LoginForm = new LoginForm();
            LoginForm.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

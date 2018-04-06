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
    public partial class ExaminationFom : Form
    {
        public ExaminationFom()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TreatmentReportForm treatmentForm = new TreatmentReportForm();
            treatmentForm.ShowDialog();
            this.Close();
                

        }
    }
}

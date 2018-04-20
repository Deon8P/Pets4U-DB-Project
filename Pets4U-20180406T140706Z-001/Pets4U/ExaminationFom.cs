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
            string vetFname, vetLname, petName, petType, desctiption;
            int examNum, petNum;
            DateTime examDate, examTime;

            vetFname = txtVetFName.Text;
            vetLname = txtLName.Text;
            petName = txtPet_name.Text;
            petType = txtTypePet.Text;
            desctiption = richTextBox1.Text;

            examNum = Convert.ToInt32(txtExam_number.Text);
            petNum = Convert.ToInt32(txtPet_num.Text);

            examDate = Convert.ToDateTime(txtDate.Text);
            examTime = Convert.ToDateTime(txtTime.Text);

            //call method
            ////////////////////////////////////////////////////////////
            
            /////////////////////////////////////////////////////////////



            TreatmentReportForm treatmentForm = new TreatmentReportForm();
            treatmentForm.ShowDialog();
            this.Close();
                

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

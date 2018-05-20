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
    public partial class DeletePetsForm : Form
    {
        public DeletePetsForm()
        {
            InitializeComponent();
        }

        Database_Class database = new Database_Class();

        public string OFnem, PName;
        public int OwnNum, PetNum;

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OFnem = txtFName.Text;
            PName = txtPName.Text;

            OwnNum = Convert.ToInt32(txtONum.Text);
            PetNum = Convert.ToInt32(txtPNum.Text);

            database.delPens(PetNum);
            database.delAppoint(OwnNum, OFnem);
            database.delPet(PetNum, PName);
            database.delOwner(OwnNum, OFnem);

            this.Close();
        }
    }
}

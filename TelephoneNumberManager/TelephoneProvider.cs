using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelephoneNumberManager
{
    public partial class TelephoneProvider : Form
    {
        public TelephoneProvider()
        {
            InitializeComponent();
        }

        private void TelephoneProvider_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'telephoneNumbersDataSet1.Telco' table. You can move, or remove it, as needed.
            this.telcoTableAdapter.Fill(this.telephoneNumbersDataSet1.Telco);
            // TODO: This line of code loads data into the 'telephoneNumbersDataSet.Sites' table. You can move, or remove it, as needed.
            this.sitesTableAdapter.Fill(this.telephoneNumbersDataSet.Sites);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActive.Checked == true)
            {

            }
            else
            {

            }
        }

        private void sitesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sitesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.telephoneNumbersDataSet);

        }
    }
}

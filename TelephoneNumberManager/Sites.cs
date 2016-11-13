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
    public partial class Sites : Form
    {
        public Sites()
        {
            InitializeComponent();
        }

        private void Sites_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'telephoneNumbersDataSet.Sites' table. You can move, or remove it, as needed.
            this.sitesTableAdapter.Fill(this.telephoneNumbersDataSet.Sites);

        }
    }
}

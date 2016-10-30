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
    public partial class Main : Form
    {
        

        public Main()
        {
            InitializeComponent();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sitesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About myAbout = new About();
            myAbout.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddUser myAddUser = new AddUser();
            myAddUser.ShowDialog();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTelephoneNumbers myAddTelephoneNumbers = new AddTelephoneNumbers();
            myAddTelephoneNumbers.ShowDialog();
        }

        private void editNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTelephoneNumbers myEditTelephoneNumbers = new EditTelephoneNumbers();
            myEditTelephoneNumbers.ShowDialog();
        }

        private void addSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sites mySites = new Sites();
            mySites.ShowDialog();
        }

        private void providerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelephoneProvider myTelephoneProvider = new TelephoneProvider();
            myTelephoneProvider.ShowDialog();
        }
    }
}

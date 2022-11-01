using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukupholisa3
{
    public partial class UserForm : Form
    {
        DataHandler userHandle = new DataHandler();
        DataHandler test = new DataHandler();
        public UserForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string holderID = txtHID.Text;
            int holderKey = int.Parse(txtHKey.Text);
            string holderPhone = txtHPone.Text;
            try
            {
                if (userHandle.checkAccount(holderID) && userHandle.checkHolderKey(holderKey,holderID) && userHandle.checkHolderPhone(holderPhone,holderID))
                {
                    MessageBox.Show("Account Exists");
                    userTabCtrl.SelectTab(tabShowAccounts);
                    dgvViewAccounts.DataSource = userHandle.ViewAccountCall(holderID);
                    
                }
                else
                {
                    MessageBox.Show("Something wrongly failed validation");
                }

            }
            catch (Exception)
            {
                //e.GetBaseException();
                MessageBox.Show("Something went wrong trying to check account.");
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void tabShowAccounts_Click(object sender, EventArgs e)
        {

        }
    }
}

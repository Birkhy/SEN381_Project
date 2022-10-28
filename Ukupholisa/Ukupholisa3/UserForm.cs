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
            Int16 holderKey = Convert.ToInt16(txtHKey.Text);
            string holderPhone = txtHPone.Text;
            try
            {
                
                //MessageBox.Show(userHandle.checkAccount((txtHID.Text).ToString()).ToString());
                if (userHandle.checkAccount(holderID) && userHandle.checkHolderKey(holderKey,holderID) && userHandle.checkHolderPhone(holderPhone,holderID))
                {
                    MessageBox.Show("Account Exists");
                    userTabCtrl.SelectTab(tabShowAccounts);
                    
                }
                else
                {
                    //MessageBox.Show("Account does not exist");
                }

            }
            catch (Exception)
            {
                //e.GetBaseException();
                MessageBox.Show("Something went wrong trying to check account.");
            }
        }
    }
}

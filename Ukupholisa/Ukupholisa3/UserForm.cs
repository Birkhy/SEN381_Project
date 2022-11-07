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
        int PackageID;
        string PackageName;
        Int32 AccountID;
        int HolderKey;
        string HolderCell;
        string HolderID;

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
                    userTabCtrl.SelectTab(tabShowDependants);
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
            cmbPackage.DataSource = userHandle.getPackages();
        }

        

        private void cmbPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            PackageName = cmbPackage.Text;
            dgvAccount.DataSource = userHandle.ViewPackageTreatments(PackageName);
        }

        private void btnSrchTrt_Click(object sender, EventArgs e)
        {
            try
            {

                dgvTreatments.DataSource = userHandle.SearchTreatment(txtSrchTrt.Text);
                dgvTreatments.AutoResizeColumns();
                //MessageBox.Show("Handler supposed to work");
                //Source.DataSource = //Handle.GetClient();

            }
            catch (Exception)
            {
                //e.GetBaseException();
                MessageBox.Show("Something went wrong trying to view Treatments.");
            }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            AccountID = userHandle.getLastID() + 1;
            PackageID = userHandle.setPackageID(PackageName);
            HolderKey = int.Parse(txtHKey.Text);
            HolderID = txtHID.Text;
            HolderCell = txtHolderCell.Text;
            //MessageBox.Show(PackageID.ToString());
            Accounts newAccount = new Accounts(AccountID, HolderKey, HolderID, HolderCell, PackageID);
           // userHandle.AddAccount(newAccount);
            
            //MessageBox.Show(AccountID.ToString());
        }

        private void tabCall_Click(object sender, EventArgs e)
        {

        }
    }
}
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
    static class glbvar
    {
        public static int PackageID;
        public static string PackageName;
        public static Int32 AccountID;
        public static string HolderKey;
        public static string HolderCell;
        public static string HolderID;

    }

    public partial class UserForm : Form
    {
        int PackageID;
        string PackageName;
        Int32 AccountID;
        string HolderKey;
        string HolderCell;
        string HolderID;

        DataHandler userHandle = new DataHandler();
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
                if (userHandle.checkAccount(holderID) && userHandle.checkHolderKey(holderKey, holderID) && userHandle.checkHolderPhone(holderPhone, holderID))
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

        private void tabShowAccounts_Click(object sender, EventArgs e)
        {

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
            //int PackageID;
            //string PackageName;
            //Int32 AccountID;
            //string HolderKey;
            //string HolderCell;
            //string HolderID;

            AccountID = userHandle.getLastID() + 1;
            PackageID = userHandle.setPackageID(PackageName);
            HolderKey = txtHolderKey.Text;
            HolderID = txtHolderID.Text;
            HolderCell = txtHolderCell.Text;
            try
            {
                userHandle.AddAccount(AccountID, HolderKey, HolderID, HolderCell, PackageID);
            }
            catch (Exception)
            {
                MessageBox.Show("something went wrong");


            }
            //userHandle.AddAccount(AccountID,HolderKey,HolderID,HolderCell,PackageID);

            //MessageBox.Show(AccountID.ToString());
        }
    }
}

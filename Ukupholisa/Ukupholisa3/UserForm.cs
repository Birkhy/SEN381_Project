using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ukupholisa3;

namespace Ukupholisa3
{
    public partial class UserForm : Form
    {
        int PackageID;
        string PackageName;
        Int32 AccountID;
        string HolderKey;
        string HolderCell;
        string HolderID;
        string DependantID;
        string DependantName;
        string DependantSurname;
        DateTime DOB;
        string DependantSex;
        int ConditionID;
        string VCondition;
        int packageIDclaim;

        DataHandler userHandle = new DataHandler();
        public UserForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            HolderID = txtHID.Text;
            HolderKey = txtHKey.Text;
            HolderCell = txtHPone.Text;
            try
            {
                if (userHandle.checkAccount(HolderID) && userHandle.checkHolderKey(HolderKey, HolderID) && userHandle.checkHolderPhone(HolderCell, HolderID))
                {
                    MessageBox.Show("Account Exists");
                    userTabCtrl.SelectTab(tabClaims);
                    //dgvClaims.DataSource = userHandle.ViewAccountCall(holderID);
                    dgvClaims.DataSource = userHandle.ViewPackageTreatments(PackageName);
                    dgvClaims.AutoResizeColumns();
                    cmbClaimCondition.DataSource = userHandle.getPackageTreatments(int.Parse(userHandle.setPackageIDClaim(HolderID)));


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
            cmbDepCondition.DataSource = userHandle.getConditions();

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
            HolderKey = txtHolderKey.Text;
            HolderID = txtHolderID.Text;
            HolderCell = txtHolderCell.Text;
            try
            {
                if (userHandle.AddAccount(AccountID, HolderKey, HolderID, HolderCell, PackageID))
                {
                    dgvAccount.DataSource = userHandle.ViewAccount(HolderID);
                    dgvAccount.AutoResizeColumns();
                    pnlAccountAdd.Visible = false;
                    pnlDependantAdd.Visible = true;
                    txtAccountID.Text = AccountID.ToString();
                    txtDependantID.Text = HolderID;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("something went wrong");
            }
        }

        private void tabAddAccount_Click(object sender, EventArgs e)
        {
            // pnlDependantAdd.Visible = false;
            // pnlAddConditionDep.Visible = false;
        }

        private void btnAddDependant_Click(object sender, EventArgs e)
        {
            AccountID = int.Parse(txtAccountID.Text);
            DependantID = txtDependantID.Text;
            DependantName = txtDependantName.Text;
            DependantSurname = txtDepSur.Text;
            DOB = dtpDOB.Value;
            DependantSex = cmbSex.Text;

            try
            {
                if (userHandle.AddDependant(DependantID, AccountID, DependantName, DependantSurname, DOB, DependantSex))
                {
                    dgvAccount.DataSource = userHandle.ViewDependentsByAccount(AccountID);
                    dgvAccount.AutoResizeColumns();
                    txtDependantID.Clear();
                    txtDependantName.Clear();
                    txtDepSur.Clear();
                    dtpDOB.ResetText();
                    cmbSex.ResetText();

                    pnlAddConditionDep.Visible = true;
                    pnlDependantAdd.Visible = false;

                    txtDependantID2.Text = DependantID.ToString();
                }
                ;

            }
            catch (Exception)
            {
                MessageBox.Show("something went wrong");
            }
        }

        private void btnDone2_Click(object sender, EventArgs e)
        {
            pnlAddConditionDep.Visible = false;
            pnlDependantAdd.Visible = true;
        }

        private void btnDone1_Click(object sender, EventArgs e)
        {
            pnlAccountAdd.Visible = true;
            pnlDependantAdd.Visible = false;
        }

        private void btnAddDepCondition_Click(object sender, EventArgs e)
        {
            VCondition = cmbDepCondition.Text;
            ConditionID = int.Parse(userHandle.setConditionID(VCondition));
            MessageBox.Show(ConditionID.ToString());
            DependantID = txtDependantID2.Text;
            MessageBox.Show(DependantID);

            if(userHandle.AddDependantCondition(DependantID, ConditionID))
            {
                MessageBox.Show("Successfully added condition");
            }
            
        }

        private void btnSubmitClaim_Click(object sender, EventArgs e)
        {

            MessageBox.Show(HolderID);
            AccountID = Int32.Parse(userHandle.getAccountID(HolderID));
            MessageBox.Show(AccountID.ToString());
            try
            {
                if (userHandle.AddClaim(AccountID, cmbClaimCondition.Text))
                {
                    MessageBox.Show("Claim has been approved and is being processed");


                }
            }
            catch (Exception)
            {
                MessageBox.Show("something went wrong");
            }
        }
    }
}

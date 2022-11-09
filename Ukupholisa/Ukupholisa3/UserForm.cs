using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        DateTime CallStartTime;
        DateTime CallEndTime;
        DateTime CallDate;
        string DependantSex;
        int ConditionID;
        string VCondition;
        int packageIDclaim;
        TimeSpan CallDuration;
        Int32 CallID;
        bool accountVerified = false;

        bool checkInsert = false;
        bool checkUpdate = false;
        bool checkDelete = false;

        bool checkAccount = false;
        bool checkDependant = false;
        bool checkDepCond = false;

        DataHandler userHandle = new DataHandler();
        private readonly Timer timer = new Timer();
        private readonly Stopwatch sw = new Stopwatch();
        private const string TimeFormat = "hh\\ \\:\\ mm\\ \\:\\ ss";


        public UserForm()
        {
            InitializeComponent();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
        }

        private void UpdateDisplay()
        {
            lblTimer.Text = sw.Elapsed.ToString(TimeFormat);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateDisplay();
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
                    accountVerified = true;


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
            pnlAccountAdd.Visible = false;
            pnlAddConditionDep.Visible = false;
            pnlDependantAdd.Visible = false;

            cmbPackage.DataSource = userHandle.getPackages();
            cmbDepCondition.DataSource = userHandle.getConditions();
            pnlSelectButtons.Visible = false;
            pnlButtons.Visible = true;


        }

        private void cmbPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            PackageName = cmbPackage.Text;
            dgvViewPackage.DataSource = userHandle.ViewPackageTreatments(PackageName);
        }

        private void btnSrchTrt_Click(object sender, EventArgs e)
        {
            try
            {

                //dgvTreatments.DataSource = userHandle.SearchTreatment(txtSrchTrt.Text);
                //dgvTreatments.AutoResizeColumns();
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

            PackageID = userHandle.setPackageID(PackageName);
            HolderKey = txtHolderKey.Text;
            HolderID = txtHolderID.Text;
            HolderCell = txtHolderCell.Text;

            if (checkInsert)
            {
                AccountID = userHandle.getLastID() + 1;

                try
                {
                    if (userHandle.AddAccount(AccountID, HolderKey, HolderID, HolderCell, PackageID))
                    {
                        dgvAccount.DataSource = userHandle.getAccount();
                        //dgvAccount.DataSource = userHandle.ViewAccount(HolderID);
                        dgvAccount.AutoResizeColumns();
                        pnlAccountAdd.Visible = false;
                        pnlDependantAdd.Visible = true;
                        txtAccountID.Text = AccountID.ToString();
                        txtDependantID.Text = HolderID;
                    }
                    //MessageBox.Show("Add Account");
                }
                catch (Exception)
                {
                    MessageBox.Show("something went wrong");
                }
            }
            if (checkUpdate)
            {
                try
                {
                    MessageBox.Show(userHandle.UpdateAccount(HolderKey, HolderID, HolderCell, PackageID));

                    dgvAccount.DataSource = userHandle.ViewAccount(HolderID);
                    dgvAccount.AutoResizeColumns();
                    //MessageBox.Show("Update Account");
                }
                catch (Exception)
                {
                    MessageBox.Show("something went wrong");
                }
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

            if (checkInsert)
            {
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
                }
                catch (Exception)
                {
                    MessageBox.Show("something went wrong");
                }
            }

            if (checkUpdate)
            {
                try
                {
                    MessageBox.Show(userHandle.updateDependant(DependantID, DependantName, DependantSurname, DOB, DependantSex));

                    dgvAccount.DataSource = userHandle.getDependants();
                    //dgvAccount.DataSource = userHandle.ViewAccount(HolderID);
                    dgvAccount.AutoResizeColumns();
                    //MessageBox.Show("Update Account");
                }
                catch (Exception)
                {
                    MessageBox.Show("something went wrong");
                }
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
            //MessageBox.Show(ConditionID.ToString());
            DependantID = txtDependantID2.Text;
            //MessageBox.Show(DependantID);

            if (checkInsert)
            {
                if (userHandle.AddDependantCondition(DependantID, ConditionID))
                {
                    MessageBox.Show("Successfully added condition");
                    dgvAccount.DataSource = userHandle.getDependantCondition();
                }
            }

            if (checkUpdate)
            {
                try
                {
                    MessageBox.Show(userHandle.updateDependantCondition(DependantID, ConditionID));

                    dgvAccount.DataSource = userHandle.getDependantCondition();
                    //dgvAccount.DataSource = userHandle.ViewAccount(HolderID);
                    dgvAccount.AutoResizeColumns();
                    //MessageBox.Show("Update Account");
                }
                catch (Exception)
                {
                    MessageBox.Show("something went wrong");
                }
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            sw.Start();
            UpdateDisplay();
            timer.Start();


            CallStartTime = DateTime.Now;
            CallDate = DateTime.Now;
            CallID = userHandle.getLastCallID();
            if (userHandle.AddCallStart(CallID + 1, CallDate, CallStartTime))
            {
                MessageBox.Show("Successfully added call");
            }
            MessageBox.Show(CallStartTime.ToString());


        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            sw.Stop();
            UpdateDisplay();
            timer.Stop();

            CallID = userHandle.getLastCallID();
            CallEndTime = DateTime.Now;
            MessageBox.Show(CallEndTime.ToString());
            CallDuration = CallEndTime.Subtract(CallStartTime);
            if (userHandle.AddCallEnd(CallID, HolderID, CallEndTime, CallDuration))
            {
                if (HolderID == null)
                {
                    MessageBox.Show("Call successfully updated");
                }
                else
                {
                    if (userHandle.AddAccountCall(HolderID, CallID))
                    {
                        MessageBox.Show("Call ended");
                    }
                }
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }


        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            checkInsert = true;
            pnlButtons.Visible = false;
            pnlSelectButtons.Visible = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            checkUpdate = true;
            pnlButtons.Visible = false;
            pnlSelectButtons.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            checkDelete = true;
            pnlButtons.Visible = false;
            pnlSelectButtons.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            checkDelete = false;
            checkInsert = false;
            checkUpdate = false;

            pnlAccountAdd.Visible = false;
            pnlAddConditionDep.Visible = false;
            pnlDependantAdd.Visible = false;

            pnlSelectButtons.Visible = false;
            pnlButtons.Visible = true;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            dgvAccount.DataSource = userHandle.getAccount();

            checkAccount = true;
            checkDependant = false;
            checkDepCond = false;

            pnlAddConditionDep.Visible = false;
            pnlDependantAdd.Visible = false;
            pnlAccountAdd.Visible = true;
            if (checkInsert)
            {
                btnAddAccount.Text = "Add";
            }
            if (checkUpdate)
            {
                btnAddAccount.Text = "Update";
            }
            if (checkDelete)
            {
                btnAddAccount.Text = "Delete";
            }

        }

        private void btnDependant_Click(object sender, EventArgs e)
        {
            dgvAccount.DataSource = userHandle.getDependants();

            checkDependant = true;
            checkAccount = false;
            checkDepCond = false;

            pnlAccountAdd.Visible = false;
            pnlAddConditionDep.Visible = false;
            pnlDependantAdd.Visible = true;
            if (checkInsert)
            {
                btnAddDependant.Text = "Add";
            }
            if (checkUpdate)
            {
                btnAddDependant.Text = "Update";
            }
            if (checkDelete)
            {
                btnAddDependant.Text = "Delete";
            }
        }

        private void btnCondition_Click(object sender, EventArgs e)
        {
            dgvAccount.DataSource = userHandle.getDependantCondition();

            checkDepCond = true;
            checkAccount = false;
            checkDependant = false;

            pnlAccountAdd.Visible = false;
            pnlDependantAdd.Visible = false;
            pnlAddConditionDep.Visible = true;
            if (checkInsert)
            {
                btnAddDepCondition.Text = "Add";
            }
            if (checkUpdate)
            {
                btnAddDepCondition.Text = "Update";
            }
            if (checkDelete)
            {
                btnAddDepCondition.Text = "Delete";
            }
        }

        private void dgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (checkAccount)
            {
                try
                {
                    if (e.RowIndex >= 0)
                {
                    DataGridViewRow Rows = this.dgvAccount.Rows[e.RowIndex];
                    txtHolderKey.Text = Rows.Cells["Holder_Key"].Value.ToString();
                    txtHolderID.Text = Rows.Cells["Holder_ID"].Value.ToString();
                    txtHolderCell.Text = Rows.Cells["Holder_Cell"].Value.ToString();
                    int PackageID = (int)Rows.Cells["Package_ID"].Value;
                    cmbPackage.Text = userHandle.setPackageName(PackageID.ToString());


                }
            }
                catch (Exception)
            {
                MessageBox.Show("Somthing went wrong.");
            }
        }

            if (checkDependant)
            {
                try
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow Rows = this.dgvAccount.Rows[e.RowIndex];
                        txtAccountID.Text = Rows.Cells["Account_ID"].Value.ToString();
                        txtDependantID.Text = Rows.Cells["Dependant_ID"].Value.ToString();
                        cmbSex.Text = Rows.Cells["Sex"].Value.ToString();
                        txtDependantName.Text = Rows.Cells["Dep_Name"].Value.ToString();
                        txtDepSur.Text = Rows.Cells["Dep_Surname"].Value.ToString();
                        dtpDOB.Value = (DateTime)Rows.Cells["DOB"].Value;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Somthing went wrong.");
                }
            }

            if (checkDepCond)
            {
                try
                {
                    if (e.RowIndex >= 0)
                    {

                        DataGridViewRow Rows = this.dgvAccount.Rows[e.RowIndex];
                        int ConditionID = (int)Rows.Cells["Condition_ID"].Value;
                        txtDependantID2.Text = Rows.Cells["Dependant_ID"].Value.ToString();
                        cmbDepCondition.Text = userHandle.setConditionName(ConditionID.ToString());
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Somthing went wrong.");
                }
            }

        }

        private void cmbPackage_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}

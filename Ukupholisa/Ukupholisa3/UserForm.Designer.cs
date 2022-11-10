using System;

namespace Ukupholisa3
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.userTabCtrl = new System.Windows.Forms.TabControl();
            this.tabCall = new System.Windows.Forms.TabPage();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHPone = new System.Windows.Forms.TextBox();
            this.txtHID = new System.Windows.Forms.TextBox();
            this.txtHKey = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tabClaims = new System.Windows.Forms.TabPage();
            this.btnSubmitClaim = new System.Windows.Forms.Button();
            this.cmbClaimCondition = new System.Windows.Forms.ComboBox();
            this.dgvClaims = new System.Windows.Forms.DataGridView();
            this.tabAddAccount = new System.Windows.Forms.TabPage();
            this.dgvViewPackage = new System.Windows.Forms.DataGridView();
            this.pnlSelectButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCondition = new System.Windows.Forms.Button();
            this.btnDependant = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.pnlAddConditionDep = new System.Windows.Forms.Panel();
            this.btnDone2 = new System.Windows.Forms.Button();
            this.cmbDepCondition = new System.Windows.Forms.ComboBox();
            this.lblConditionDep = new System.Windows.Forms.Label();
            this.txtDependantID2 = new System.Windows.Forms.TextBox();
            this.lblDependantID2 = new System.Windows.Forms.Label();
            this.btnAddDepCondition = new System.Windows.Forms.Button();
            this.pnlDependantAdd = new System.Windows.Forms.Panel();
            this.btnDone1 = new System.Windows.Forms.Button();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtDependantID = new System.Windows.Forms.TextBox();
            this.lblDependantSurname = new System.Windows.Forms.Label();
            this.lblDependantID = new System.Windows.Forms.Label();
            this.lblDependantName = new System.Windows.Forms.Label();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.btnAddDependant = new System.Windows.Forms.Button();
            this.txtDepSur = new System.Windows.Forms.TextBox();
            this.txtDependantName = new System.Windows.Forms.TextBox();
            this.txtAccountID = new System.Windows.Forms.TextBox();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.pnlAccountAdd = new System.Windows.Forms.Panel();
            this.lblHolderCell = new System.Windows.Forms.Label();
            this.lblPackage = new System.Windows.Forms.Label();
            this.lblHolderKey = new System.Windows.Forms.Label();
            this.lblHolderID = new System.Windows.Forms.Label();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.txtHolderCell = new System.Windows.Forms.TextBox();
            this.txtHolderKey = new System.Windows.Forms.TextBox();
            this.cmbPackage = new System.Windows.Forms.ComboBox();
            this.txtHolderID = new System.Windows.Forms.TextBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.userTabCtrl.SuspendLayout();
            this.tabCall.SuspendLayout();
            this.tabClaims.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClaims)).BeginInit();
            this.tabAddAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewPackage)).BeginInit();
            this.pnlSelectButtons.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlAddConditionDep.SuspendLayout();
            this.pnlDependantAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.pnlAccountAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // userTabCtrl
            // 
            this.userTabCtrl.Controls.Add(this.tabCall);
            this.userTabCtrl.Controls.Add(this.tabClaims);
            this.userTabCtrl.Controls.Add(this.tabAddAccount);
            this.userTabCtrl.Location = new System.Drawing.Point(0, 1);
            this.userTabCtrl.Margin = new System.Windows.Forms.Padding(2);
            this.userTabCtrl.Name = "userTabCtrl";
            this.userTabCtrl.SelectedIndex = 0;
            this.userTabCtrl.Size = new System.Drawing.Size(788, 517);
            this.userTabCtrl.TabIndex = 2;
            this.userTabCtrl.Click += new System.EventHandler(this.tabAddAccount_Click);
            // 
            // tabCall
            // 
            this.tabCall.Controls.Add(this.lblTimer);
            this.tabCall.Controls.Add(this.btnStart);
            this.tabCall.Controls.Add(this.label5);
            this.tabCall.Controls.Add(this.label4);
            this.tabCall.Controls.Add(this.label3);
            this.tabCall.Controls.Add(this.label1);
            this.tabCall.Controls.Add(this.txtHPone);
            this.tabCall.Controls.Add(this.txtHID);
            this.tabCall.Controls.Add(this.txtHKey);
            this.tabCall.Controls.Add(this.btnSubmit);
            this.tabCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCall.Location = new System.Drawing.Point(4, 22);
            this.tabCall.Margin = new System.Windows.Forms.Padding(2);
            this.tabCall.Name = "tabCall";
            this.tabCall.Padding = new System.Windows.Forms.Padding(2);
            this.tabCall.Size = new System.Drawing.Size(780, 491);
            this.tabCall.TabIndex = 0;
            this.tabCall.Text = "Call";
            this.tabCall.UseVisualStyleBackColor = true;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(492, 19);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(46, 18);
            this.lblTimer.TabIndex = 22;
            this.lblTimer.Text = "Timer";
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.Location = new System.Drawing.Point(651, 19);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(110, 110);
            this.btnStart.TabIndex = 20;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(271, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Holder Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Call Manage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Holder Key:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Holder ID:";
            // 
            // txtHPone
            // 
            this.txtHPone.Location = new System.Drawing.Point(374, 211);
            this.txtHPone.Margin = new System.Windows.Forms.Padding(2);
            this.txtHPone.Name = "txtHPone";
            this.txtHPone.Size = new System.Drawing.Size(76, 24);
            this.txtHPone.TabIndex = 15;
            // 
            // txtHID
            // 
            this.txtHID.Location = new System.Drawing.Point(374, 130);
            this.txtHID.Margin = new System.Windows.Forms.Padding(2);
            this.txtHID.Name = "txtHID";
            this.txtHID.Size = new System.Drawing.Size(76, 24);
            this.txtHID.TabIndex = 14;
            // 
            // txtHKey
            // 
            this.txtHKey.Location = new System.Drawing.Point(374, 169);
            this.txtHKey.Margin = new System.Windows.Forms.Padding(2);
            this.txtHKey.Name = "txtHKey";
            this.txtHKey.Size = new System.Drawing.Size(76, 24);
            this.txtHKey.TabIndex = 13;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(320, 242);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(76, 24);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tabClaims
            // 
            this.tabClaims.Controls.Add(this.btnSubmitClaim);
            this.tabClaims.Controls.Add(this.cmbClaimCondition);
            this.tabClaims.Controls.Add(this.dgvClaims);
            this.tabClaims.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabClaims.Location = new System.Drawing.Point(4, 22);
            this.tabClaims.Margin = new System.Windows.Forms.Padding(2);
            this.tabClaims.Name = "tabClaims";
            this.tabClaims.Padding = new System.Windows.Forms.Padding(2);
            this.tabClaims.Size = new System.Drawing.Size(653, 491);
            this.tabClaims.TabIndex = 1;
            this.tabClaims.Text = "Claims";
            this.tabClaims.UseVisualStyleBackColor = true;
            // 
            // btnSubmitClaim
            // 
            this.btnSubmitClaim.Location = new System.Drawing.Point(8, 48);
            this.btnSubmitClaim.Name = "btnSubmitClaim";
            this.btnSubmitClaim.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitClaim.TabIndex = 23;
            this.btnSubmitClaim.Text = "Submit";
            this.btnSubmitClaim.UseVisualStyleBackColor = true;
            this.btnSubmitClaim.Click += new System.EventHandler(this.btnSubmitClaim_Click);
            // 
            // cmbClaimCondition
            // 
            this.cmbClaimCondition.FormattingEnabled = true;
            this.cmbClaimCondition.Location = new System.Drawing.Point(8, 16);
            this.cmbClaimCondition.Name = "cmbClaimCondition";
            this.cmbClaimCondition.Size = new System.Drawing.Size(179, 26);
            this.cmbClaimCondition.TabIndex = 22;
            // 
            // dgvClaims
            // 
            this.dgvClaims.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClaims.Location = new System.Drawing.Point(211, 0);
            this.dgvClaims.Name = "dgvClaims";
            this.dgvClaims.Size = new System.Drawing.Size(584, 491);
            this.dgvClaims.TabIndex = 21;
            // 
            // tabAddAccount
            // 
            this.tabAddAccount.Controls.Add(this.dgvViewPackage);
            this.tabAddAccount.Controls.Add(this.pnlSelectButtons);
            this.tabAddAccount.Controls.Add(this.pnlButtons);
            this.tabAddAccount.Controls.Add(this.pnlAddConditionDep);
            this.tabAddAccount.Controls.Add(this.pnlDependantAdd);
            this.tabAddAccount.Controls.Add(this.dgvAccount);
            this.tabAddAccount.Controls.Add(this.pnlAccountAdd);
            this.tabAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAddAccount.Location = new System.Drawing.Point(4, 22);
            this.tabAddAccount.Margin = new System.Windows.Forms.Padding(2);
            this.tabAddAccount.Name = "tabAddAccount";
            this.tabAddAccount.Size = new System.Drawing.Size(653, 491);
            this.tabAddAccount.TabIndex = 2;
            this.tabAddAccount.Text = "Accounts";
            this.tabAddAccount.UseVisualStyleBackColor = true;
            // 
            // dgvViewPackage
            // 
            this.dgvViewPackage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewPackage.Location = new System.Drawing.Point(18, 263);
            this.dgvViewPackage.Name = "dgvViewPackage";
            this.dgvViewPackage.Size = new System.Drawing.Size(240, 220);
            this.dgvViewPackage.TabIndex = 28;
            // 
            // pnlSelectButtons
            // 
            this.pnlSelectButtons.Controls.Add(this.btnCancel);
            this.pnlSelectButtons.Controls.Add(this.btnCondition);
            this.pnlSelectButtons.Controls.Add(this.btnDependant);
            this.pnlSelectButtons.Controls.Add(this.btnAccount);
            this.pnlSelectButtons.Location = new System.Drawing.Point(18, 5);
            this.pnlSelectButtons.Name = "pnlSelectButtons";
            this.pnlSelectButtons.Size = new System.Drawing.Size(247, 58);
            this.pnlSelectButtons.TabIndex = 27;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(183, 35);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCondition
            // 
            this.btnCondition.Location = new System.Drawing.Point(158, 8);
            this.btnCondition.Name = "btnCondition";
            this.btnCondition.Size = new System.Drawing.Size(75, 23);
            this.btnCondition.TabIndex = 16;
            this.btnCondition.Text = "Condition";
            this.btnCondition.UseVisualStyleBackColor = true;
            this.btnCondition.Click += new System.EventHandler(this.btnCondition_Click);
            // 
            // btnDependant
            // 
            this.btnDependant.Location = new System.Drawing.Point(72, 8);
            this.btnDependant.Name = "btnDependant";
            this.btnDependant.Size = new System.Drawing.Size(80, 23);
            this.btnDependant.TabIndex = 15;
            this.btnDependant.Text = "Dependant";
            this.btnDependant.UseVisualStyleBackColor = true;
            this.btnDependant.Click += new System.EventHandler(this.btnDependant_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Location = new System.Drawing.Point(3, 8);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(63, 23);
            this.btnAccount.TabIndex = 5;
            this.btnAccount.Text = "Account";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnUpdate);
            this.pnlButtons.Controls.Add(this.btnInsert);
            this.pnlButtons.Location = new System.Drawing.Point(18, 5);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(247, 58);
            this.pnlButtons.TabIndex = 25;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(158, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(72, 8);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(3, 8);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(63, 23);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // pnlAddConditionDep
            // 
            this.pnlAddConditionDep.Controls.Add(this.btnDone2);
            this.pnlAddConditionDep.Controls.Add(this.cmbDepCondition);
            this.pnlAddConditionDep.Controls.Add(this.lblConditionDep);
            this.pnlAddConditionDep.Controls.Add(this.txtDependantID2);
            this.pnlAddConditionDep.Controls.Add(this.lblDependantID2);
            this.pnlAddConditionDep.Controls.Add(this.btnAddDepCondition);
            this.pnlAddConditionDep.Location = new System.Drawing.Point(3, 72);
            this.pnlAddConditionDep.Name = "pnlAddConditionDep";
            this.pnlAddConditionDep.Size = new System.Drawing.Size(261, 188);
            this.pnlAddConditionDep.TabIndex = 24;
            // 
            // btnDone2
            // 
            this.btnDone2.Location = new System.Drawing.Point(140, 165);
            this.btnDone2.Name = "btnDone2";
            this.btnDone2.Size = new System.Drawing.Size(100, 23);
            this.btnDone2.TabIndex = 15;
            this.btnDone2.Text = "Done";
            this.btnDone2.UseVisualStyleBackColor = true;
            this.btnDone2.Click += new System.EventHandler(this.btnDone2_Click);
            // 
            // cmbDepCondition
            // 
            this.cmbDepCondition.FormattingEnabled = true;
            this.cmbDepCondition.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbDepCondition.Location = new System.Drawing.Point(140, 132);
            this.cmbDepCondition.Name = "cmbDepCondition";
            this.cmbDepCondition.Size = new System.Drawing.Size(100, 23);
            this.cmbDepCondition.TabIndex = 14;
            // 
            // lblConditionDep
            // 
            this.lblConditionDep.AutoSize = true;
            this.lblConditionDep.Location = new System.Drawing.Point(19, 135);
            this.lblConditionDep.Name = "lblConditionDep";
            this.lblConditionDep.Size = new System.Drawing.Size(59, 15);
            this.lblConditionDep.TabIndex = 11;
            this.lblConditionDep.Text = "Condition";
            // 
            // txtDependantID2
            // 
            this.txtDependantID2.Location = new System.Drawing.Point(140, 105);
            this.txtDependantID2.Name = "txtDependantID2";
            this.txtDependantID2.Size = new System.Drawing.Size(100, 21);
            this.txtDependantID2.TabIndex = 10;
            // 
            // lblDependantID2
            // 
            this.lblDependantID2.AutoSize = true;
            this.lblDependantID2.Location = new System.Drawing.Point(13, 108);
            this.lblDependantID2.Name = "lblDependantID2";
            this.lblDependantID2.Size = new System.Drawing.Size(83, 15);
            this.lblDependantID2.TabIndex = 8;
            this.lblDependantID2.Text = "Dependant ID";
            // 
            // btnAddDepCondition
            // 
            this.btnAddDepCondition.Location = new System.Drawing.Point(10, 165);
            this.btnAddDepCondition.Name = "btnAddDepCondition";
            this.btnAddDepCondition.Size = new System.Drawing.Size(100, 23);
            this.btnAddDepCondition.TabIndex = 5;
            this.btnAddDepCondition.Text = "Add";
            this.btnAddDepCondition.UseVisualStyleBackColor = true;
            this.btnAddDepCondition.Click += new System.EventHandler(this.btnAddDepCondition_Click);
            // 
            // pnlDependantAdd
            // 
            this.pnlDependantAdd.Controls.Add(this.btnDone1);
            this.pnlDependantAdd.Controls.Add(this.cmbSex);
            this.pnlDependantAdd.Controls.Add(this.lblSex);
            this.pnlDependantAdd.Controls.Add(this.dtpDOB);
            this.pnlDependantAdd.Controls.Add(this.lblDOB);
            this.pnlDependantAdd.Controls.Add(this.txtDependantID);
            this.pnlDependantAdd.Controls.Add(this.lblDependantSurname);
            this.pnlDependantAdd.Controls.Add(this.lblDependantID);
            this.pnlDependantAdd.Controls.Add(this.lblDependantName);
            this.pnlDependantAdd.Controls.Add(this.lblAccountID);
            this.pnlDependantAdd.Controls.Add(this.btnAddDependant);
            this.pnlDependantAdd.Controls.Add(this.txtDepSur);
            this.pnlDependantAdd.Controls.Add(this.txtDependantName);
            this.pnlDependantAdd.Controls.Add(this.txtAccountID);
            this.pnlDependantAdd.Location = new System.Drawing.Point(8, 66);
            this.pnlDependantAdd.Name = "pnlDependantAdd";
            this.pnlDependantAdd.Size = new System.Drawing.Size(261, 188);
            this.pnlDependantAdd.TabIndex = 23;
            // 
            // btnDone1
            // 
            this.btnDone1.Location = new System.Drawing.Point(136, 165);
            this.btnDone1.Name = "btnDone1";
            this.btnDone1.Size = new System.Drawing.Size(100, 23);
            this.btnDone1.TabIndex = 16;
            this.btnDone1.Text = "Done";
            this.btnDone1.UseVisualStyleBackColor = true;
            this.btnDone1.Click += new System.EventHandler(this.btnDone1_Click);
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbSex.Location = new System.Drawing.Point(136, 135);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(100, 23);
            this.cmbSex.TabIndex = 14;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(13, 138);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(92, 15);
            this.lblSex.TabIndex = 13;
            this.lblSex.Text = "Dependant Sex";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(136, 109);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(115, 21);
            this.dtpDOB.TabIndex = 12;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(13, 110);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(97, 15);
            this.lblDOB.TabIndex = 11;
            this.lblDOB.Text = "Dependant DOB";
            // 
            // txtDependantID
            // 
            this.txtDependantID.Location = new System.Drawing.Point(136, 28);
            this.txtDependantID.Name = "txtDependantID";
            this.txtDependantID.Size = new System.Drawing.Size(100, 21);
            this.txtDependantID.TabIndex = 10;
            // 
            // lblDependantSurname
            // 
            this.lblDependantSurname.AutoSize = true;
            this.lblDependantSurname.Location = new System.Drawing.Point(13, 85);
            this.lblDependantSurname.Name = "lblDependantSurname";
            this.lblDependantSurname.Size = new System.Drawing.Size(122, 15);
            this.lblDependantSurname.TabIndex = 9;
            this.lblDependantSurname.Text = "Dependant Surname";
            // 
            // lblDependantID
            // 
            this.lblDependantID.AutoSize = true;
            this.lblDependantID.Location = new System.Drawing.Point(13, 31);
            this.lblDependantID.Name = "lblDependantID";
            this.lblDependantID.Size = new System.Drawing.Size(83, 15);
            this.lblDependantID.TabIndex = 8;
            this.lblDependantID.Text = "Dependant ID";
            // 
            // lblDependantName
            // 
            this.lblDependantName.AutoSize = true;
            this.lblDependantName.Location = new System.Drawing.Point(13, 58);
            this.lblDependantName.Name = "lblDependantName";
            this.lblDependantName.Size = new System.Drawing.Size(105, 15);
            this.lblDependantName.TabIndex = 7;
            this.lblDependantName.Text = "Dependant Name";
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.Location = new System.Drawing.Point(13, 4);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(65, 15);
            this.lblAccountID.TabIndex = 6;
            this.lblAccountID.Text = "Account ID";
            // 
            // btnAddDependant
            // 
            this.btnAddDependant.Location = new System.Drawing.Point(11, 165);
            this.btnAddDependant.Name = "btnAddDependant";
            this.btnAddDependant.Size = new System.Drawing.Size(100, 23);
            this.btnAddDependant.TabIndex = 5;
            this.btnAddDependant.Text = "Add";
            this.btnAddDependant.UseVisualStyleBackColor = true;
            this.btnAddDependant.Click += new System.EventHandler(this.btnAddDependant_Click);
            // 
            // txtDepSur
            // 
            this.txtDepSur.Location = new System.Drawing.Point(136, 82);
            this.txtDepSur.Name = "txtDepSur";
            this.txtDepSur.Size = new System.Drawing.Size(100, 21);
            this.txtDepSur.TabIndex = 4;
            // 
            // txtDependantName
            // 
            this.txtDependantName.Location = new System.Drawing.Point(136, 55);
            this.txtDependantName.Name = "txtDependantName";
            this.txtDependantName.Size = new System.Drawing.Size(100, 21);
            this.txtDependantName.TabIndex = 3;
            // 
            // txtAccountID
            // 
            this.txtAccountID.Location = new System.Drawing.Point(136, 1);
            this.txtAccountID.Name = "txtAccountID";
            this.txtAccountID.Size = new System.Drawing.Size(100, 21);
            this.txtAccountID.TabIndex = 1;
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(293, 13);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.Size = new System.Drawing.Size(479, 470);
            this.dgvAccount.TabIndex = 22;
            this.dgvAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellContentClick);
            // 
            // pnlAccountAdd
            // 
            this.pnlAccountAdd.Controls.Add(this.lblHolderCell);
            this.pnlAccountAdd.Controls.Add(this.lblPackage);
            this.pnlAccountAdd.Controls.Add(this.lblHolderKey);
            this.pnlAccountAdd.Controls.Add(this.lblHolderID);
            this.pnlAccountAdd.Controls.Add(this.btnAddAccount);
            this.pnlAccountAdd.Controls.Add(this.txtHolderCell);
            this.pnlAccountAdd.Controls.Add(this.txtHolderKey);
            this.pnlAccountAdd.Controls.Add(this.cmbPackage);
            this.pnlAccountAdd.Controls.Add(this.txtHolderID);
            this.pnlAccountAdd.Location = new System.Drawing.Point(8, 69);
            this.pnlAccountAdd.Name = "pnlAccountAdd";
            this.pnlAccountAdd.Size = new System.Drawing.Size(261, 188);
            this.pnlAccountAdd.TabIndex = 0;
            // 
            // lblHolderCell
            // 
            this.lblHolderCell.AutoSize = true;
            this.lblHolderCell.Location = new System.Drawing.Point(13, 136);
            this.lblHolderCell.Name = "lblHolderCell";
            this.lblHolderCell.Size = new System.Drawing.Size(68, 15);
            this.lblHolderCell.TabIndex = 9;
            this.lblHolderCell.Text = "Holder Cell";
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.Location = new System.Drawing.Point(13, 82);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(55, 15);
            this.lblPackage.TabIndex = 8;
            this.lblPackage.Text = "Package";
            // 
            // lblHolderKey
            // 
            this.lblHolderKey.AutoSize = true;
            this.lblHolderKey.Location = new System.Drawing.Point(13, 109);
            this.lblHolderKey.Name = "lblHolderKey";
            this.lblHolderKey.Size = new System.Drawing.Size(67, 15);
            this.lblHolderKey.TabIndex = 7;
            this.lblHolderKey.Text = "Holder Key";
            // 
            // lblHolderID
            // 
            this.lblHolderID.AutoSize = true;
            this.lblHolderID.Location = new System.Drawing.Point(13, 53);
            this.lblHolderID.Name = "lblHolderID";
            this.lblHolderID.Size = new System.Drawing.Size(59, 15);
            this.lblHolderID.TabIndex = 6;
            this.lblHolderID.Text = "Holder ID";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(11, 165);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(100, 23);
            this.btnAddAccount.TabIndex = 5;
            this.btnAddAccount.Text = "Add";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // txtHolderCell
            // 
            this.txtHolderCell.Location = new System.Drawing.Point(136, 133);
            this.txtHolderCell.Name = "txtHolderCell";
            this.txtHolderCell.Size = new System.Drawing.Size(100, 21);
            this.txtHolderCell.TabIndex = 4;
            // 
            // txtHolderKey
            // 
            this.txtHolderKey.Location = new System.Drawing.Point(136, 106);
            this.txtHolderKey.Name = "txtHolderKey";
            this.txtHolderKey.Size = new System.Drawing.Size(100, 21);
            this.txtHolderKey.TabIndex = 3;
            // 
            // cmbPackage
            // 
            this.cmbPackage.FormattingEnabled = true;
            this.cmbPackage.Location = new System.Drawing.Point(136, 77);
            this.cmbPackage.Name = "cmbPackage";
            this.cmbPackage.Size = new System.Drawing.Size(100, 23);
            this.cmbPackage.TabIndex = 2;
            this.cmbPackage.SelectedIndexChanged += new System.EventHandler(this.cmbPackage_SelectedIndexChanged);
            this.cmbPackage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbPackage_MouseClick);
            // 
            // txtHolderID
            // 
            this.txtHolderID.Location = new System.Drawing.Point(136, 50);
            this.txtHolderID.Name = "txtHolderID";
            this.txtHolderID.Size = new System.Drawing.Size(100, 21);
            this.txtHolderID.TabIndex = 1;
            // 
            // btnEnd
            // 
            this.btnEnd.Image = ((System.Drawing.Image)(resources.GetObject("btnEnd.Image")));
            this.btnEnd.Location = new System.Drawing.Point(665, 23);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(110, 110);
            this.btnEnd.TabIndex = 21;
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 517);
            this.Controls.Add(this.userTabCtrl);
            this.Controls.Add(this.btnEnd);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.userTabCtrl.ResumeLayout(false);
            this.tabCall.ResumeLayout(false);
            this.tabCall.PerformLayout();
            this.tabClaims.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClaims)).EndInit();
            this.tabAddAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewPackage)).EndInit();
            this.pnlSelectButtons.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlAddConditionDep.ResumeLayout(false);
            this.pnlAddConditionDep.PerformLayout();
            this.pnlDependantAdd.ResumeLayout(false);
            this.pnlDependantAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.pnlAccountAdd.ResumeLayout(false);
            this.pnlAccountAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        //private void tabShowAccounts_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion

        private System.Windows.Forms.TabControl userTabCtrl;
        private System.Windows.Forms.TabPage tabCall;
        private System.Windows.Forms.TabPage tabClaims;
        private System.Windows.Forms.TabPage tabAddAccount;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHPone;
        private System.Windows.Forms.TextBox txtHID;
        private System.Windows.Forms.TextBox txtHKey;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dgvClaims;
        private System.Windows.Forms.Panel pnlAccountAdd;
        private System.Windows.Forms.TextBox txtHolderID;
        private System.Windows.Forms.ComboBox cmbPackage;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.TextBox txtHolderCell;
        private System.Windows.Forms.TextBox txtHolderKey;
        private System.Windows.Forms.Label lblHolderID;
        private System.Windows.Forms.Label lblHolderCell;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.Label lblHolderKey;
        private System.Windows.Forms.Panel pnlDependantAdd;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtDependantID;
        private System.Windows.Forms.Label lblDependantSurname;
        private System.Windows.Forms.Label lblDependantID;
        private System.Windows.Forms.Label lblDependantName;
        private System.Windows.Forms.Label lblAccountID;
        private System.Windows.Forms.Button btnAddDependant;
        private System.Windows.Forms.TextBox txtDepSur;
        private System.Windows.Forms.TextBox txtDependantName;
        private System.Windows.Forms.TextBox txtAccountID;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Panel pnlAddConditionDep;
        private System.Windows.Forms.Button btnDone2;
        private System.Windows.Forms.ComboBox cmbDepCondition;
        private System.Windows.Forms.Label lblConditionDep;
        private System.Windows.Forms.TextBox txtDependantID2;
        private System.Windows.Forms.Label lblDependantID2;
        private System.Windows.Forms.Button btnAddDepCondition;
        private System.Windows.Forms.Button btnDone1;
        private System.Windows.Forms.ComboBox cmbClaimCondition;
        private System.Windows.Forms.Button btnSubmitClaim;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Panel pnlSelectButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCondition;
        private System.Windows.Forms.Button btnDependant;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dgvViewPackage;
        private System.Windows.Forms.Button btnEnd;
    }
}
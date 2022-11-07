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
            this.userTabCtrl = new System.Windows.Forms.TabControl();
            this.tabCall = new System.Windows.Forms.TabPage();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHPone = new System.Windows.Forms.TextBox();
            this.txtHID = new System.Windows.Forms.TextBox();
            this.txtHKey = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tabShowDependants = new System.Windows.Forms.TabPage();
            this.dgvViewAccounts = new System.Windows.Forms.DataGridView();
            this.tabAddAccount = new System.Windows.Forms.TabPage();
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
            this.Treatments = new System.Windows.Forms.TabPage();
            this.txtSrchTrt = new System.Windows.Forms.TextBox();
            this.btnSrchTrt = new System.Windows.Forms.Button();
            this.dgvTreatments = new System.Windows.Forms.DataGridView();
            this.Conditions = new System.Windows.Forms.TabPage();
            this.rbnOther = new System.Windows.Forms.RadioButton();
            this.rbnFemale = new System.Windows.Forms.RadioButton();
            this.rbnMale = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dtkDOB = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.userTabCtrl.SuspendLayout();
            this.tabCall.SuspendLayout();
            this.tabShowDependants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAccounts)).BeginInit();
            this.tabAddAccount.SuspendLayout();
            this.pnlAddConditionDep.SuspendLayout();
            this.pnlDependantAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.pnlAccountAdd.SuspendLayout();
            this.Treatments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).BeginInit();
            this.Conditions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // userTabCtrl
            // 
            this.userTabCtrl.Controls.Add(this.tabCall);
            this.userTabCtrl.Controls.Add(this.tabShowDependants);
            this.userTabCtrl.Controls.Add(this.tabAddAccount);
            this.userTabCtrl.Controls.Add(this.Treatments);
            this.userTabCtrl.Controls.Add(this.Conditions);
            this.userTabCtrl.Location = new System.Drawing.Point(0, 1);
            this.userTabCtrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userTabCtrl.Name = "userTabCtrl";
            this.userTabCtrl.SelectedIndex = 0;
            this.userTabCtrl.Size = new System.Drawing.Size(1071, 636);
            this.userTabCtrl.TabIndex = 2;
            // 
            // tabCall
            // 
            this.tabCall.Controls.Add(this.btnEnd);
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
            this.tabCall.Location = new System.Drawing.Point(4, 25);
            this.tabCall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCall.Name = "tabCall";
            this.tabCall.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCall.Size = new System.Drawing.Size(1063, 607);
            this.tabCall.TabIndex = 0;
            this.tabCall.Text = "Call";
            this.tabCall.UseVisualStyleBackColor = true;
            this.tabCall.Click += new System.EventHandler(this.tabCall_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(560, 298);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(101, 30);
            this.btnEnd.TabIndex = 21;
            this.btnEnd.Text = "Call End";
            this.btnEnd.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(288, 298);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(101, 30);
            this.btnStart.TabIndex = 20;
            this.btnStart.Text = "Call Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(361, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Holder Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(384, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 36);
            this.label4.TabIndex = 18;
            this.label4.Text = "Call Manage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(361, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Holder Key:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Holder ID:";
            // 
            // txtHPone
            // 
            this.txtHPone.Location = new System.Drawing.Point(499, 260);
            this.txtHPone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHPone.Name = "txtHPone";
            this.txtHPone.Size = new System.Drawing.Size(100, 29);
            this.txtHPone.TabIndex = 15;
            // 
            // txtHID
            // 
            this.txtHID.Location = new System.Drawing.Point(499, 160);
            this.txtHID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHID.Name = "txtHID";
            this.txtHID.Size = new System.Drawing.Size(100, 29);
            this.txtHID.TabIndex = 14;
            // 
            // txtHKey
            // 
            this.txtHKey.Location = new System.Drawing.Point(499, 208);
            this.txtHKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHKey.Name = "txtHKey";
            this.txtHKey.Size = new System.Drawing.Size(100, 29);
            this.txtHKey.TabIndex = 13;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(427, 298);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(101, 30);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tabShowDependants
            // 
            this.tabShowDependants.Controls.Add(this.dgvViewAccounts);
            this.tabShowDependants.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabShowDependants.Location = new System.Drawing.Point(4, 25);
            this.tabShowDependants.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabShowDependants.Name = "tabShowDependants";
            this.tabShowDependants.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabShowDependants.Size = new System.Drawing.Size(1063, 607);
            this.tabShowDependants.TabIndex = 1;
            this.tabShowDependants.Text = "Dependants";
            this.tabShowDependants.UseVisualStyleBackColor = true;
            // 
            // dgvViewAccounts
            // 
            this.dgvViewAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewAccounts.Location = new System.Drawing.Point(11, 6);
            this.dgvViewAccounts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvViewAccounts.Name = "dgvViewAccounts";
            this.dgvViewAccounts.RowHeadersWidth = 51;
            this.dgvViewAccounts.Size = new System.Drawing.Size(853, 455);
            this.dgvViewAccounts.TabIndex = 21;
            // 
            // tabAddAccount
            // 
            this.tabAddAccount.Controls.Add(this.pnlAddConditionDep);
            this.tabAddAccount.Controls.Add(this.pnlDependantAdd);
            this.tabAddAccount.Controls.Add(this.dgvAccount);
            this.tabAddAccount.Controls.Add(this.pnlAccountAdd);
            this.tabAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAddAccount.Location = new System.Drawing.Point(4, 25);
            this.tabAddAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAddAccount.Name = "tabAddAccount";
            this.tabAddAccount.Size = new System.Drawing.Size(1063, 607);
            this.tabAddAccount.TabIndex = 2;
            this.tabAddAccount.Text = "Accounts";
            this.tabAddAccount.UseVisualStyleBackColor = true;
            // 
            // pnlAddConditionDep
            // 
            this.pnlAddConditionDep.Controls.Add(this.btnDone2);
            this.pnlAddConditionDep.Controls.Add(this.cmbDepCondition);
            this.pnlAddConditionDep.Controls.Add(this.lblConditionDep);
            this.pnlAddConditionDep.Controls.Add(this.txtDependantID2);
            this.pnlAddConditionDep.Controls.Add(this.lblDependantID2);
            this.pnlAddConditionDep.Controls.Add(this.btnAddDepCondition);
            this.pnlAddConditionDep.Location = new System.Drawing.Point(367, 4);
            this.pnlAddConditionDep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAddConditionDep.Name = "pnlAddConditionDep";
            this.pnlAddConditionDep.Size = new System.Drawing.Size(348, 302);
            this.pnlAddConditionDep.TabIndex = 24;
            // 
            // btnDone2
            // 
            this.btnDone2.Location = new System.Drawing.Point(100, 235);
            this.btnDone2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDone2.Name = "btnDone2";
            this.btnDone2.Size = new System.Drawing.Size(133, 28);
            this.btnDone2.TabIndex = 15;
            this.btnDone2.Text = "Done";
            this.btnDone2.UseVisualStyleBackColor = true;
            // 
            // cmbDepCondition
            // 
            this.cmbDepCondition.FormattingEnabled = true;
            this.cmbDepCondition.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbDepCondition.Location = new System.Drawing.Point(191, 65);
            this.cmbDepCondition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDepCondition.Name = "cmbDepCondition";
            this.cmbDepCondition.Size = new System.Drawing.Size(132, 26);
            this.cmbDepCondition.TabIndex = 14;
            // 
            // lblConditionDep
            // 
            this.lblConditionDep.AutoSize = true;
            this.lblConditionDep.Location = new System.Drawing.Point(20, 69);
            this.lblConditionDep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConditionDep.Name = "lblConditionDep";
            this.lblConditionDep.Size = new System.Drawing.Size(71, 18);
            this.lblConditionDep.TabIndex = 11;
            this.lblConditionDep.Text = "Condition";
            // 
            // txtDependantID2
            // 
            this.txtDependantID2.Location = new System.Drawing.Point(191, 28);
            this.txtDependantID2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDependantID2.Name = "txtDependantID2";
            this.txtDependantID2.Size = new System.Drawing.Size(132, 24);
            this.txtDependantID2.TabIndex = 10;
            // 
            // lblDependantID2
            // 
            this.lblDependantID2.AutoSize = true;
            this.lblDependantID2.Location = new System.Drawing.Point(20, 32);
            this.lblDependantID2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDependantID2.Name = "lblDependantID2";
            this.lblDependantID2.Size = new System.Drawing.Size(97, 18);
            this.lblDependantID2.TabIndex = 8;
            this.lblDependantID2.Text = "Dependant ID";
            // 
            // btnAddDepCondition
            // 
            this.btnAddDepCondition.Location = new System.Drawing.Point(100, 186);
            this.btnAddDepCondition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddDepCondition.Name = "btnAddDepCondition";
            this.btnAddDepCondition.Size = new System.Drawing.Size(133, 28);
            this.btnAddDepCondition.TabIndex = 5;
            this.btnAddDepCondition.Text = "Add Condition";
            this.btnAddDepCondition.UseVisualStyleBackColor = true;
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
            this.pnlDependantAdd.Location = new System.Drawing.Point(11, 293);
            this.pnlDependantAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDependantAdd.Name = "pnlDependantAdd";
            this.pnlDependantAdd.Size = new System.Drawing.Size(348, 302);
            this.pnlDependantAdd.TabIndex = 23;
            // 
            // btnDone1
            // 
            this.btnDone1.Location = new System.Drawing.Point(191, 247);
            this.btnDone1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDone1.Name = "btnDone1";
            this.btnDone1.Size = new System.Drawing.Size(133, 28);
            this.btnDone1.TabIndex = 16;
            this.btnDone1.Text = "Done";
            this.btnDone1.UseVisualStyleBackColor = true;
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbSex.Location = new System.Drawing.Point(191, 203);
            this.cmbSex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(132, 26);
            this.cmbSex.TabIndex = 14;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(20, 207);
            this.lblSex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(108, 18);
            this.lblSex.TabIndex = 13;
            this.lblSex.Text = "Dependant Sex";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(191, 167);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(152, 24);
            this.dtpDOB.TabIndex = 12;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(20, 167);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(116, 18);
            this.lblDOB.TabIndex = 11;
            this.lblDOB.Text = "Dependant DOB";
            // 
            // txtDependantID
            // 
            this.txtDependantID.Location = new System.Drawing.Point(191, 64);
            this.txtDependantID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDependantID.Name = "txtDependantID";
            this.txtDependantID.Size = new System.Drawing.Size(132, 24);
            this.txtDependantID.TabIndex = 10;
            // 
            // lblDependantSurname
            // 
            this.lblDependantSurname.AutoSize = true;
            this.lblDependantSurname.Location = new System.Drawing.Point(20, 137);
            this.lblDependantSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDependantSurname.Name = "lblDependantSurname";
            this.lblDependantSurname.Size = new System.Drawing.Size(143, 18);
            this.lblDependantSurname.TabIndex = 9;
            this.lblDependantSurname.Text = "Dependant Surname";
            // 
            // lblDependantID
            // 
            this.lblDependantID.AutoSize = true;
            this.lblDependantID.Location = new System.Drawing.Point(20, 68);
            this.lblDependantID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDependantID.Name = "lblDependantID";
            this.lblDependantID.Size = new System.Drawing.Size(97, 18);
            this.lblDependantID.TabIndex = 8;
            this.lblDependantID.Text = "Dependant ID";
            // 
            // lblDependantName
            // 
            this.lblDependantName.AutoSize = true;
            this.lblDependantName.Location = new System.Drawing.Point(20, 103);
            this.lblDependantName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDependantName.Name = "lblDependantName";
            this.lblDependantName.Size = new System.Drawing.Size(123, 18);
            this.lblDependantName.TabIndex = 7;
            this.lblDependantName.Text = "Dependant Name";
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.Location = new System.Drawing.Point(20, 34);
            this.lblAccountID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(80, 18);
            this.lblAccountID.TabIndex = 6;
            this.lblAccountID.Text = "Account ID";
            // 
            // btnAddDependant
            // 
            this.btnAddDependant.Location = new System.Drawing.Point(16, 247);
            this.btnAddDependant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddDependant.Name = "btnAddDependant";
            this.btnAddDependant.Size = new System.Drawing.Size(133, 28);
            this.btnAddDependant.TabIndex = 5;
            this.btnAddDependant.Text = "Add Dependant";
            this.btnAddDependant.UseVisualStyleBackColor = true;
            // 
            // txtDepSur
            // 
            this.txtDepSur.Location = new System.Drawing.Point(191, 129);
            this.txtDepSur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDepSur.Name = "txtDepSur";
            this.txtDepSur.Size = new System.Drawing.Size(132, 24);
            this.txtDepSur.TabIndex = 4;
            // 
            // txtDependantName
            // 
            this.txtDependantName.Location = new System.Drawing.Point(191, 100);
            this.txtDependantName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDependantName.Name = "txtDependantName";
            this.txtDependantName.Size = new System.Drawing.Size(132, 24);
            this.txtDependantName.TabIndex = 3;
            // 
            // txtAccountID
            // 
            this.txtAccountID.Location = new System.Drawing.Point(191, 31);
            this.txtAccountID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAccountID.Name = "txtAccountID";
            this.txtAccountID.Size = new System.Drawing.Size(132, 24);
            this.txtAccountID.TabIndex = 1;
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(391, 324);
            this.dgvAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.Size = new System.Drawing.Size(639, 271);
            this.dgvAccount.TabIndex = 22;
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
            this.pnlAccountAdd.Location = new System.Drawing.Point(11, 23);
            this.pnlAccountAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAccountAdd.Name = "pnlAccountAdd";
            this.pnlAccountAdd.Size = new System.Drawing.Size(303, 244);
            this.pnlAccountAdd.TabIndex = 0;
            // 
            // lblHolderCell
            // 
            this.lblHolderCell.AutoSize = true;
            this.lblHolderCell.Location = new System.Drawing.Point(20, 137);
            this.lblHolderCell.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHolderCell.Name = "lblHolderCell";
            this.lblHolderCell.Size = new System.Drawing.Size(81, 18);
            this.lblHolderCell.TabIndex = 9;
            this.lblHolderCell.Text = "Holder Cell";
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.Location = new System.Drawing.Point(20, 68);
            this.lblPackage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(66, 18);
            this.lblPackage.TabIndex = 8;
            this.lblPackage.Text = "Package";
            // 
            // lblHolderKey
            // 
            this.lblHolderKey.AutoSize = true;
            this.lblHolderKey.Location = new System.Drawing.Point(20, 103);
            this.lblHolderKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHolderKey.Name = "lblHolderKey";
            this.lblHolderKey.Size = new System.Drawing.Size(81, 18);
            this.lblHolderKey.TabIndex = 7;
            this.lblHolderKey.Text = "Holder Key";
            // 
            // lblHolderID
            // 
            this.lblHolderID.AutoSize = true;
            this.lblHolderID.Location = new System.Drawing.Point(20, 34);
            this.lblHolderID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHolderID.Name = "lblHolderID";
            this.lblHolderID.Size = new System.Drawing.Size(70, 18);
            this.lblHolderID.TabIndex = 6;
            this.lblHolderID.Text = "Holder ID";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(132, 166);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(133, 28);
            this.btnAddAccount.TabIndex = 5;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // txtHolderCell
            // 
            this.txtHolderCell.Location = new System.Drawing.Point(132, 133);
            this.txtHolderCell.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHolderCell.Name = "txtHolderCell";
            this.txtHolderCell.Size = new System.Drawing.Size(132, 24);
            this.txtHolderCell.TabIndex = 4;
            // 
            // txtHolderKey
            // 
            this.txtHolderKey.Location = new System.Drawing.Point(132, 100);
            this.txtHolderKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHolderKey.Name = "txtHolderKey";
            this.txtHolderKey.Size = new System.Drawing.Size(132, 24);
            this.txtHolderKey.TabIndex = 3;
            // 
            // cmbPackage
            // 
            this.cmbPackage.FormattingEnabled = true;
            this.cmbPackage.Location = new System.Drawing.Point(132, 64);
            this.cmbPackage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPackage.Name = "cmbPackage";
            this.cmbPackage.Size = new System.Drawing.Size(132, 26);
            this.cmbPackage.TabIndex = 2;
            this.cmbPackage.SelectedIndexChanged += new System.EventHandler(this.cmbPackage_SelectedIndexChanged);
            // 
            // txtHolderID
            // 
            this.txtHolderID.Location = new System.Drawing.Point(132, 31);
            this.txtHolderID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHolderID.Name = "txtHolderID";
            this.txtHolderID.Size = new System.Drawing.Size(132, 24);
            this.txtHolderID.TabIndex = 1;
            // 
            // Treatments
            // 
            this.Treatments.Controls.Add(this.txtSrchTrt);
            this.Treatments.Controls.Add(this.btnSrchTrt);
            this.Treatments.Controls.Add(this.dgvTreatments);
            this.Treatments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Treatments.Location = new System.Drawing.Point(4, 25);
            this.Treatments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Treatments.Name = "Treatments";
            this.Treatments.Size = new System.Drawing.Size(1063, 607);
            this.Treatments.TabIndex = 3;
            this.Treatments.Text = "Treatments";
            this.Treatments.UseVisualStyleBackColor = true;
            // 
            // txtSrchTrt
            // 
            this.txtSrchTrt.Location = new System.Drawing.Point(100, 180);
            this.txtSrchTrt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSrchTrt.Name = "txtSrchTrt";
            this.txtSrchTrt.Size = new System.Drawing.Size(132, 27);
            this.txtSrchTrt.TabIndex = 22;
            // 
            // btnSrchTrt
            // 
            this.btnSrchTrt.Location = new System.Drawing.Point(116, 118);
            this.btnSrchTrt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSrchTrt.Name = "btnSrchTrt";
            this.btnSrchTrt.Size = new System.Drawing.Size(100, 28);
            this.btnSrchTrt.TabIndex = 21;
            this.btnSrchTrt.Text = "Search";
            this.btnSrchTrt.UseVisualStyleBackColor = true;
            this.btnSrchTrt.Click += new System.EventHandler(this.btnSrchTrt_Click);
            // 
            // dgvTreatments
            // 
            this.dgvTreatments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreatments.Location = new System.Drawing.Point(328, 4);
            this.dgvTreatments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTreatments.Name = "dgvTreatments";
            this.dgvTreatments.RowHeadersWidth = 51;
            this.dgvTreatments.Size = new System.Drawing.Size(667, 400);
            this.dgvTreatments.TabIndex = 20;
            // 
            // Conditions
            // 
            this.Conditions.Controls.Add(this.rbnOther);
            this.Conditions.Controls.Add(this.rbnFemale);
            this.Conditions.Controls.Add(this.rbnMale);
            this.Conditions.Controls.Add(this.btnSearch);
            this.Conditions.Controls.Add(this.label6);
            this.Conditions.Controls.Add(this.txtID);
            this.Conditions.Controls.Add(this.dtkDOB);
            this.Conditions.Controls.Add(this.label2);
            this.Conditions.Controls.Add(this.label7);
            this.Conditions.Controls.Add(this.label8);
            this.Conditions.Controls.Add(this.label9);
            this.Conditions.Controls.Add(this.txtSName);
            this.Conditions.Controls.Add(this.txtName);
            this.Conditions.Controls.Add(this.btnUpdate);
            this.Conditions.Controls.Add(this.btnDelete);
            this.Conditions.Controls.Add(this.btnInsert);
            this.Conditions.Controls.Add(this.dgvClients);
            this.Conditions.Controls.Add(this.label10);
            this.Conditions.Controls.Add(this.label21);
            this.Conditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conditions.Location = new System.Drawing.Point(4, 25);
            this.Conditions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Conditions.Name = "Conditions";
            this.Conditions.Size = new System.Drawing.Size(1063, 607);
            this.Conditions.TabIndex = 4;
            this.Conditions.Text = "Conditions";
            this.Conditions.UseVisualStyleBackColor = true;
            // 
            // rbnOther
            // 
            this.rbnOther.AutoSize = true;
            this.rbnOther.Location = new System.Drawing.Point(251, 262);
            this.rbnOther.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnOther.Name = "rbnOther";
            this.rbnOther.Size = new System.Drawing.Size(77, 24);
            this.rbnOther.TabIndex = 38;
            this.rbnOther.TabStop = true;
            this.rbnOther.Text = "Other";
            this.rbnOther.UseVisualStyleBackColor = true;
            // 
            // rbnFemale
            // 
            this.rbnFemale.AutoSize = true;
            this.rbnFemale.Location = new System.Drawing.Point(151, 262);
            this.rbnFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnFemale.Name = "rbnFemale";
            this.rbnFemale.Size = new System.Drawing.Size(91, 24);
            this.rbnFemale.TabIndex = 37;
            this.rbnFemale.TabStop = true;
            this.rbnFemale.Text = "Female";
            this.rbnFemale.UseVisualStyleBackColor = true;
            // 
            // rbnMale
            // 
            this.rbnMale.AutoSize = true;
            this.rbnMale.Location = new System.Drawing.Point(71, 262);
            this.rbnMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnMale.Name = "rbnMale";
            this.rbnMale.Size = new System.Drawing.Size(70, 24);
            this.rbnMale.TabIndex = 36;
            this.rbnMale.TabStop = true;
            this.rbnMale.Text = "Male";
            this.rbnMale.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(821, 492);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(164, 75);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(132, 27);
            this.txtID.TabIndex = 33;
            // 
            // dtkDOB
            // 
            this.dtkDOB.Location = new System.Drawing.Point(164, 212);
            this.dtkDOB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtkDOB.Name = "dtkDOB";
            this.dtkDOB.Size = new System.Drawing.Size(193, 27);
            this.dtkDOB.TabIndex = 32;
            this.dtkDOB.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Surname:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 218);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Date Of Birth:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 262);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Sex:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 128);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Name:";
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(164, 167);
            this.txtSName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(132, 27);
            this.txtSName.TabIndex = 27;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(164, 124);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 27);
            this.txtName.TabIndex = 26;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(356, 492);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(603, 492);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(115, 492);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 28);
            this.btnInsert.TabIndex = 23;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // dgvClients
            // 
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(369, 75);
            this.dgvClients.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.RowHeadersWidth = 51;
            this.dgvClients.Size = new System.Drawing.Size(667, 400);
            this.dgvClients.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(385, 36);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(219, 36);
            this.label10.TabIndex = 21;
            this.label10.Text = "Client Manage";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(215, 134);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 20);
            this.label21.TabIndex = 1;
            this.label21.Text = "label21";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 638);
            this.Controls.Add(this.userTabCtrl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.userTabCtrl.ResumeLayout(false);
            this.tabCall.ResumeLayout(false);
            this.tabCall.PerformLayout();
            this.tabShowDependants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAccounts)).EndInit();
            this.tabAddAccount.ResumeLayout(false);
            this.pnlAddConditionDep.ResumeLayout(false);
            this.pnlAddConditionDep.PerformLayout();
            this.pnlDependantAdd.ResumeLayout(false);
            this.pnlDependantAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.pnlAccountAdd.ResumeLayout(false);
            this.pnlAccountAdd.PerformLayout();
            this.Treatments.ResumeLayout(false);
            this.Treatments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).EndInit();
            this.Conditions.ResumeLayout(false);
            this.Conditions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);

        }

        private void tabShowAccounts_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TabControl userTabCtrl;
        private System.Windows.Forms.TabPage tabCall;
        private System.Windows.Forms.TabPage tabShowDependants;
        private System.Windows.Forms.TabPage tabAddAccount;
        private System.Windows.Forms.TabPage Treatments;
        private System.Windows.Forms.TextBox txtSrchTrt;
        private System.Windows.Forms.Button btnSrchTrt;
        private System.Windows.Forms.DataGridView dgvTreatments;
        private System.Windows.Forms.TabPage Conditions;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHPone;
        private System.Windows.Forms.TextBox txtHID;
        private System.Windows.Forms.TextBox txtHKey;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dgvViewAccounts;
        private System.Windows.Forms.RadioButton rbnOther;
        private System.Windows.Forms.RadioButton rbnFemale;
        private System.Windows.Forms.RadioButton rbnMale;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DateTimePicker dtkDOB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Label label10;
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
    }
}
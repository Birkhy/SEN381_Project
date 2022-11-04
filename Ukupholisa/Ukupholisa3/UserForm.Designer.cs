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
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.lblHolderKey = new System.Windows.Forms.Label();
            this.lblPackage = new System.Windows.Forms.Label();
            this.lblHolderCell = new System.Windows.Forms.Label();
            this.userTabCtrl.SuspendLayout();
            this.tabCall.SuspendLayout();
            this.tabShowDependants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAccounts)).BeginInit();
            this.tabAddAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.userTabCtrl.Margin = new System.Windows.Forms.Padding(2);
            this.userTabCtrl.Name = "userTabCtrl";
            this.userTabCtrl.SelectedIndex = 0;
            this.userTabCtrl.Size = new System.Drawing.Size(803, 517);
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
            this.tabCall.Location = new System.Drawing.Point(4, 22);
            this.tabCall.Margin = new System.Windows.Forms.Padding(2);
            this.tabCall.Name = "tabCall";
            this.tabCall.Padding = new System.Windows.Forms.Padding(2);
            this.tabCall.Size = new System.Drawing.Size(795, 491);
            this.tabCall.TabIndex = 0;
            this.tabCall.Text = "Call";
            this.tabCall.UseVisualStyleBackColor = true;
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(420, 242);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(76, 24);
            this.btnEnd.TabIndex = 21;
            this.btnEnd.Text = "Call End";
            this.btnEnd.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(216, 242);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(76, 24);
            this.btnStart.TabIndex = 20;
            this.btnStart.Text = "Call Start";
            this.btnStart.UseVisualStyleBackColor = true;
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
            // tabShowDependants
            // 
            this.tabShowDependants.Controls.Add(this.dgvViewAccounts);
            this.tabShowDependants.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabShowDependants.Location = new System.Drawing.Point(4, 22);
            this.tabShowDependants.Margin = new System.Windows.Forms.Padding(2);
            this.tabShowDependants.Name = "tabShowDependants";
            this.tabShowDependants.Padding = new System.Windows.Forms.Padding(2);
            this.tabShowDependants.Size = new System.Drawing.Size(795, 491);
            this.tabShowDependants.TabIndex = 1;
            this.tabShowDependants.Text = "Dependants";
            this.tabShowDependants.UseVisualStyleBackColor = true;
            this.tabShowDependants.Click += new System.EventHandler(this.tabShowAccounts_Click);
            // 
            // dgvViewAccounts
            // 
            this.dgvViewAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewAccounts.Location = new System.Drawing.Point(65, 121);
            this.dgvViewAccounts.Name = "dgvViewAccounts";
            this.dgvViewAccounts.Size = new System.Drawing.Size(640, 370);
            this.dgvViewAccounts.TabIndex = 21;
            // 
            // tabAddAccount
            // 
            this.tabAddAccount.Controls.Add(this.dgvAccount);
            this.tabAddAccount.Controls.Add(this.panel1);
            this.tabAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAddAccount.Location = new System.Drawing.Point(4, 22);
            this.tabAddAccount.Margin = new System.Windows.Forms.Padding(2);
            this.tabAddAccount.Name = "tabAddAccount";
            this.tabAddAccount.Size = new System.Drawing.Size(795, 491);
            this.tabAddAccount.TabIndex = 2;
            this.tabAddAccount.Text = "Accounts";
            this.tabAddAccount.UseVisualStyleBackColor = true;
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(423, 71);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.Size = new System.Drawing.Size(352, 370);
            this.dgvAccount.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHolderCell);
            this.panel1.Controls.Add(this.lblPackage);
            this.panel1.Controls.Add(this.lblHolderKey);
            this.panel1.Controls.Add(this.lblHolderID);
            this.panel1.Controls.Add(this.btnAddAccount);
            this.panel1.Controls.Add(this.txtHolderCell);
            this.panel1.Controls.Add(this.txtHolderKey);
            this.panel1.Controls.Add(this.cmbPackage);
            this.panel1.Controls.Add(this.txtHolderID);
            this.panel1.Location = new System.Drawing.Point(8, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 198);
            this.panel1.TabIndex = 0;
            // 
            // lblHolderID
            // 
            this.lblHolderID.AutoSize = true;
            this.lblHolderID.Location = new System.Drawing.Point(15, 28);
            this.lblHolderID.Name = "lblHolderID";
            this.lblHolderID.Size = new System.Drawing.Size(59, 15);
            this.lblHolderID.TabIndex = 6;
            this.lblHolderID.Text = "Holder ID";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(99, 135);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(100, 23);
            this.btnAddAccount.TabIndex = 5;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // txtHolderCell
            // 
            this.txtHolderCell.Location = new System.Drawing.Point(99, 108);
            this.txtHolderCell.Name = "txtHolderCell";
            this.txtHolderCell.Size = new System.Drawing.Size(100, 21);
            this.txtHolderCell.TabIndex = 4;
            // 
            // txtHolderKey
            // 
            this.txtHolderKey.Location = new System.Drawing.Point(99, 81);
            this.txtHolderKey.Name = "txtHolderKey";
            this.txtHolderKey.Size = new System.Drawing.Size(100, 21);
            this.txtHolderKey.TabIndex = 3;
            // 
            // cmbPackage
            // 
            this.cmbPackage.FormattingEnabled = true;
            this.cmbPackage.Location = new System.Drawing.Point(99, 52);
            this.cmbPackage.Name = "cmbPackage";
            this.cmbPackage.Size = new System.Drawing.Size(100, 23);
            this.cmbPackage.TabIndex = 2;
            this.cmbPackage.SelectedIndexChanged += new System.EventHandler(this.cmbPackage_SelectedIndexChanged);
            // 
            // txtHolderID
            // 
            this.txtHolderID.Location = new System.Drawing.Point(99, 25);
            this.txtHolderID.Name = "txtHolderID";
            this.txtHolderID.Size = new System.Drawing.Size(100, 21);
            this.txtHolderID.TabIndex = 1;
            // 
            // Treatments
            // 
            this.Treatments.Controls.Add(this.txtSrchTrt);
            this.Treatments.Controls.Add(this.btnSrchTrt);
            this.Treatments.Controls.Add(this.dgvTreatments);
            this.Treatments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Treatments.Location = new System.Drawing.Point(4, 22);
            this.Treatments.Margin = new System.Windows.Forms.Padding(2);
            this.Treatments.Name = "Treatments";
            this.Treatments.Size = new System.Drawing.Size(795, 491);
            this.Treatments.TabIndex = 3;
            this.Treatments.Text = "Treatments";
            this.Treatments.UseVisualStyleBackColor = true;
            // 
            // txtSrchTrt
            // 
            this.txtSrchTrt.Location = new System.Drawing.Point(75, 146);
            this.txtSrchTrt.Name = "txtSrchTrt";
            this.txtSrchTrt.Size = new System.Drawing.Size(100, 23);
            this.txtSrchTrt.TabIndex = 22;
            // 
            // btnSrchTrt
            // 
            this.btnSrchTrt.Location = new System.Drawing.Point(87, 96);
            this.btnSrchTrt.Name = "btnSrchTrt";
            this.btnSrchTrt.Size = new System.Drawing.Size(75, 23);
            this.btnSrchTrt.TabIndex = 21;
            this.btnSrchTrt.Text = "Search";
            this.btnSrchTrt.UseVisualStyleBackColor = true;
            this.btnSrchTrt.Click += new System.EventHandler(this.btnSrchTrt_Click);
            // 
            // dgvTreatments
            // 
            this.dgvTreatments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTreatments.Location = new System.Drawing.Point(246, 3);
            this.dgvTreatments.Name = "dgvTreatments";
            this.dgvTreatments.Size = new System.Drawing.Size(500, 325);
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
            this.Conditions.Location = new System.Drawing.Point(4, 22);
            this.Conditions.Margin = new System.Windows.Forms.Padding(2);
            this.Conditions.Name = "Conditions";
            this.Conditions.Size = new System.Drawing.Size(795, 491);
            this.Conditions.TabIndex = 4;
            this.Conditions.Text = "Conditions";
            this.Conditions.UseVisualStyleBackColor = true;
            // 
            // rbnOther
            // 
            this.rbnOther.AutoSize = true;
            this.rbnOther.Location = new System.Drawing.Point(188, 213);
            this.rbnOther.Margin = new System.Windows.Forms.Padding(2);
            this.rbnOther.Name = "rbnOther";
            this.rbnOther.Size = new System.Drawing.Size(67, 21);
            this.rbnOther.TabIndex = 38;
            this.rbnOther.TabStop = true;
            this.rbnOther.Text = "Other";
            this.rbnOther.UseVisualStyleBackColor = true;
            // 
            // rbnFemale
            // 
            this.rbnFemale.AutoSize = true;
            this.rbnFemale.Location = new System.Drawing.Point(113, 213);
            this.rbnFemale.Margin = new System.Windows.Forms.Padding(2);
            this.rbnFemale.Name = "rbnFemale";
            this.rbnFemale.Size = new System.Drawing.Size(78, 21);
            this.rbnFemale.TabIndex = 37;
            this.rbnFemale.TabStop = true;
            this.rbnFemale.Text = "Female";
            this.rbnFemale.UseVisualStyleBackColor = true;
            // 
            // rbnMale
            // 
            this.rbnMale.AutoSize = true;
            this.rbnMale.Location = new System.Drawing.Point(53, 213);
            this.rbnMale.Margin = new System.Windows.Forms.Padding(2);
            this.rbnMale.Name = "rbnMale";
            this.rbnMale.Size = new System.Drawing.Size(60, 21);
            this.rbnMale.TabIndex = 36;
            this.rbnMale.TabStop = true;
            this.rbnMale.Text = "Male";
            this.rbnMale.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(616, 400);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(123, 61);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 23);
            this.txtID.TabIndex = 33;
            // 
            // dtkDOB
            // 
            this.dtkDOB.Location = new System.Drawing.Point(123, 172);
            this.dtkDOB.Name = "dtkDOB";
            this.dtkDOB.Size = new System.Drawing.Size(146, 23);
            this.dtkDOB.TabIndex = 32;
            this.dtkDOB.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Surname:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Date Of Birth:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Sex:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Name:";
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(123, 136);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(100, 23);
            this.txtSName.TabIndex = 27;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(123, 101);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 26;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(267, 400);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(452, 400);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(86, 400);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 23;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // dgvClients
            // 
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(277, 61);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.RowHeadersWidth = 51;
            this.dgvClients.Size = new System.Drawing.Size(500, 325);
            this.dgvClients.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(289, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 29);
            this.label10.TabIndex = 21;
            this.label10.Text = "Client Manage";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(161, 109);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 17);
            this.label21.TabIndex = 1;
            this.label21.Text = "label21";
            // 
            // lblHolderKey
            // 
            this.lblHolderKey.AutoSize = true;
            this.lblHolderKey.Location = new System.Drawing.Point(15, 84);
            this.lblHolderKey.Name = "lblHolderKey";
            this.lblHolderKey.Size = new System.Drawing.Size(67, 15);
            this.lblHolderKey.TabIndex = 7;
            this.lblHolderKey.Text = "Holder Key";
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.Location = new System.Drawing.Point(15, 55);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(55, 15);
            this.lblPackage.TabIndex = 8;
            this.lblPackage.Text = "Package";
            // 
            // lblHolderCell
            // 
            this.lblHolderCell.AutoSize = true;
            this.lblHolderCell.Location = new System.Drawing.Point(15, 111);
            this.lblHolderCell.Name = "lblHolderCell";
            this.lblHolderCell.Size = new System.Drawing.Size(68, 15);
            this.lblHolderCell.TabIndex = 9;
            this.lblHolderCell.Text = "Holder Cell";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 518);
            this.Controls.Add(this.userTabCtrl);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.userTabCtrl.ResumeLayout(false);
            this.tabCall.ResumeLayout(false);
            this.tabCall.PerformLayout();
            this.tabShowDependants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAccounts)).EndInit();
            this.tabAddAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Treatments.ResumeLayout(false);
            this.Treatments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).EndInit();
            this.Conditions.ResumeLayout(false);
            this.Conditions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
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
    }
}
namespace Genisis
{
    partial class AdminForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Provider = new System.Windows.Forms.TabPage();
            this.btnProExit = new System.Windows.Forms.Button();
            this.btnProDel = new System.Windows.Forms.Button();
            this.btnProIn = new System.Windows.Forms.Button();
            this.dgvPro = new System.Windows.Forms.DataGridView();
            this.btnProUp = new System.Windows.Forms.Button();
            this.chkCheck = new System.Windows.Forms.CheckBox();
            this.txtAgree = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Users = new System.Windows.Forms.TabPage();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.txtUPass = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnUExit = new System.Windows.Forms.Button();
            this.btnUDel = new System.Windows.Forms.Button();
            this.btnUIn = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnUUp = new System.Windows.Forms.Button();
            this.txtUContact = new System.Windows.Forms.TextBox();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.txtuSur = new System.Windows.Forms.TextBox();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Product = new System.Windows.Forms.TabPage();
            this.btnProdUp = new System.Windows.Forms.Button();
            this.btnProdExit = new System.Windows.Forms.Button();
            this.btnProdDel = new System.Windows.Forms.Button();
            this.btnProdIn = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.cmbCover = new System.Windows.Forms.ComboBox();
            this.chkPro = new System.Windows.Forms.CheckBox();
            this.chkAvail = new System.Windows.Forms.CheckBox();
            this.txtPPrice = new System.Windows.Forms.TextBox();
            this.txtPerform = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Treatments = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSrchTrt = new System.Windows.Forms.TextBox();
            this.btnSrchTrt = new System.Windows.Forms.Button();
            this.dgvTreatments = new System.Windows.Forms.DataGridView();
            this.Conditions = new System.Windows.Forms.TabPage();
            this.txtCondtionName = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btnConUpdate = new System.Windows.Forms.Button();
            this.btnConExit = new System.Windows.Forms.Button();
            this.btnConDelete = new System.Windows.Forms.Button();
            this.btnConInsert = new System.Windows.Forms.Button();
            this.dgvConditions = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.txtConditionNewName = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Provider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPro)).BeginInit();
            this.Users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.Treatments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).BeginInit();
            this.Conditions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConditions)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Provider);
            this.tabControl1.Controls.Add(this.Users);
            this.tabControl1.Controls.Add(this.Product);
            this.tabControl1.Controls.Add(this.Treatments);
            this.tabControl1.Controls.Add(this.Conditions);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1012, 566);
            this.tabControl1.TabIndex = 1;
            // 
            // Provider
            // 
            this.Provider.Controls.Add(this.btnProExit);
            this.Provider.Controls.Add(this.btnProDel);
            this.Provider.Controls.Add(this.btnProIn);
            this.Provider.Controls.Add(this.dgvPro);
            this.Provider.Controls.Add(this.btnProUp);
            this.Provider.Controls.Add(this.chkCheck);
            this.Provider.Controls.Add(this.txtAgree);
            this.Provider.Controls.Add(this.txtContact);
            this.Provider.Controls.Add(this.txtName);
            this.Provider.Controls.Add(this.label5);
            this.Provider.Controls.Add(this.label4);
            this.Provider.Controls.Add(this.label3);
            this.Provider.Controls.Add(this.label2);
            this.Provider.Controls.Add(this.label1);
            this.Provider.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Provider.Location = new System.Drawing.Point(4, 25);
            this.Provider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Provider.Name = "Provider";
            this.Provider.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Provider.Size = new System.Drawing.Size(1004, 537);
            this.Provider.TabIndex = 0;
            this.Provider.Text = "Provider";
            this.Provider.UseVisualStyleBackColor = true;
            // 
            // btnProExit
            // 
            this.btnProExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProExit.Location = new System.Drawing.Point(864, 502);
            this.btnProExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProExit.Name = "btnProExit";
            this.btnProExit.Size = new System.Drawing.Size(137, 31);
            this.btnProExit.TabIndex = 16;
            this.btnProExit.Text = "Exit";
            this.btnProExit.UseVisualStyleBackColor = true;
            this.btnProExit.Click += new System.EventHandler(this.btnProExit_Click);
            // 
            // btnProDel
            // 
            this.btnProDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProDel.Location = new System.Drawing.Point(693, 367);
            this.btnProDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProDel.Name = "btnProDel";
            this.btnProDel.Size = new System.Drawing.Size(137, 31);
            this.btnProDel.TabIndex = 15;
            this.btnProDel.Text = "Delete";
            this.btnProDel.UseVisualStyleBackColor = true;
            this.btnProDel.Click += new System.EventHandler(this.btnProDel_Click);
            // 
            // btnProIn
            // 
            this.btnProIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProIn.Location = new System.Drawing.Point(436, 367);
            this.btnProIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProIn.Name = "btnProIn";
            this.btnProIn.Size = new System.Drawing.Size(137, 31);
            this.btnProIn.TabIndex = 14;
            this.btnProIn.Text = "Insert";
            this.btnProIn.UseVisualStyleBackColor = true;
            this.btnProIn.Click += new System.EventHandler(this.btnProIn_Click);
            // 
            // dgvPro
            // 
            this.dgvPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPro.Location = new System.Drawing.Point(487, 23);
            this.dgvPro.Name = "dgvPro";
            this.dgvPro.RowHeadersWidth = 51;
            this.dgvPro.RowTemplate.Height = 24;
            this.dgvPro.Size = new System.Drawing.Size(480, 300);
            this.dgvPro.TabIndex = 13;
            // 
            // btnProUp
            // 
            this.btnProUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProUp.Location = new System.Drawing.Point(159, 367);
            this.btnProUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProUp.Name = "btnProUp";
            this.btnProUp.Size = new System.Drawing.Size(137, 31);
            this.btnProUp.TabIndex = 12;
            this.btnProUp.Text = "Update";
            this.btnProUp.UseVisualStyleBackColor = true;
            this.btnProUp.Click += new System.EventHandler(this.btnProUp_Click);
            // 
            // chkCheck
            // 
            this.chkCheck.AutoSize = true;
            this.chkCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCheck.Location = new System.Drawing.Point(252, 134);
            this.chkCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkCheck.Name = "chkCheck";
            this.chkCheck.Size = new System.Drawing.Size(77, 24);
            this.chkCheck.TabIndex = 9;
            this.chkCheck.Text = "Active";
            this.chkCheck.UseVisualStyleBackColor = true;
            // 
            // txtAgree
            // 
            this.txtAgree.Location = new System.Drawing.Point(252, 210);
            this.txtAgree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAgree.Name = "txtAgree";
            this.txtAgree.Size = new System.Drawing.Size(171, 29);
            this.txtAgree.TabIndex = 8;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(252, 166);
            this.txtContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(171, 29);
            this.txtContact.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(252, 100);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(171, 29);
            this.txtName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Provider Agreement:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Provider Contact:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Provider Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Provider Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Provider";
            // 
            // Users
            // 
            this.Users.Controls.Add(this.cbAdmin);
            this.Users.Controls.Add(this.txtUPass);
            this.Users.Controls.Add(this.txtUserName);
            this.Users.Controls.Add(this.label20);
            this.Users.Controls.Add(this.label21);
            this.Users.Controls.Add(this.label22);
            this.Users.Controls.Add(this.btnUExit);
            this.Users.Controls.Add(this.btnUDel);
            this.Users.Controls.Add(this.btnUIn);
            this.Users.Controls.Add(this.dgvUsers);
            this.Users.Controls.Add(this.btnUUp);
            this.Users.Controls.Add(this.txtUContact);
            this.Users.Controls.Add(this.txtUID);
            this.Users.Controls.Add(this.txtuSur);
            this.Users.Controls.Add(this.txtUName);
            this.Users.Controls.Add(this.label12);
            this.Users.Controls.Add(this.label10);
            this.Users.Controls.Add(this.label9);
            this.Users.Controls.Add(this.label8);
            this.Users.Controls.Add(this.label7);
            this.Users.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users.Location = new System.Drawing.Point(4, 25);
            this.Users.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Users.Name = "Users";
            this.Users.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Users.Size = new System.Drawing.Size(1004, 537);
            this.Users.TabIndex = 1;
            this.Users.Text = "Users";
            this.Users.UseVisualStyleBackColor = true;
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Location = new System.Drawing.Point(268, 310);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(92, 28);
            this.cbAdmin.TabIndex = 27;
            this.cbAdmin.Text = "Admin";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // txtUPass
            // 
            this.txtUPass.Location = new System.Drawing.Point(268, 274);
            this.txtUPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtUPass.Name = "txtUPass";
            this.txtUPass.Size = new System.Drawing.Size(132, 29);
            this.txtUPass.TabIndex = 26;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(268, 232);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(132, 29);
            this.txtUserName.TabIndex = 25;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(128, 313);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 18);
            this.label20.TabIndex = 24;
            this.label20.Text = "Admin:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(128, 283);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(115, 18);
            this.label21.TabIndex = 23;
            this.label21.Text = "User Password:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(128, 237);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(88, 18);
            this.label22.TabIndex = 22;
            this.label22.Text = "User Name:";
            // 
            // btnUExit
            // 
            this.btnUExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUExit.Location = new System.Drawing.Point(866, 505);
            this.btnUExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUExit.Name = "btnUExit";
            this.btnUExit.Size = new System.Drawing.Size(137, 31);
            this.btnUExit.TabIndex = 20;
            this.btnUExit.Text = "Exit";
            this.btnUExit.UseVisualStyleBackColor = true;
            this.btnUExit.Click += new System.EventHandler(this.btnUExit_Click);
            // 
            // btnUDel
            // 
            this.btnUDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUDel.Location = new System.Drawing.Point(693, 373);
            this.btnUDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUDel.Name = "btnUDel";
            this.btnUDel.Size = new System.Drawing.Size(137, 31);
            this.btnUDel.TabIndex = 19;
            this.btnUDel.Text = "Delete";
            this.btnUDel.UseVisualStyleBackColor = true;
            this.btnUDel.Click += new System.EventHandler(this.btnUDel_Click);
            // 
            // btnUIn
            // 
            this.btnUIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUIn.Location = new System.Drawing.Point(439, 373);
            this.btnUIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUIn.Name = "btnUIn";
            this.btnUIn.Size = new System.Drawing.Size(137, 31);
            this.btnUIn.TabIndex = 18;
            this.btnUIn.Text = "Insert";
            this.btnUIn.UseVisualStyleBackColor = true;
            this.btnUIn.Click += new System.EventHandler(this.btnUIn_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(489, 26);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(480, 300);
            this.dgvUsers.TabIndex = 17;
            // 
            // btnUUp
            // 
            this.btnUUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUUp.Location = new System.Drawing.Point(200, 370);
            this.btnUUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnUUp.Name = "btnUUp";
            this.btnUUp.Size = new System.Drawing.Size(125, 34);
            this.btnUUp.TabIndex = 11;
            this.btnUUp.Text = "Update";
            this.btnUUp.UseVisualStyleBackColor = true;
            this.btnUUp.Click += new System.EventHandler(this.btnUUp_Click);
            // 
            // txtUContact
            // 
            this.txtUContact.Location = new System.Drawing.Point(268, 195);
            this.txtUContact.Margin = new System.Windows.Forms.Padding(4);
            this.txtUContact.Name = "txtUContact";
            this.txtUContact.Size = new System.Drawing.Size(132, 29);
            this.txtUContact.TabIndex = 9;
            // 
            // txtUID
            // 
            this.txtUID.Location = new System.Drawing.Point(268, 158);
            this.txtUID.Margin = new System.Windows.Forms.Padding(4);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(132, 29);
            this.txtUID.TabIndex = 8;
            // 
            // txtuSur
            // 
            this.txtuSur.Location = new System.Drawing.Point(268, 121);
            this.txtuSur.Margin = new System.Windows.Forms.Padding(4);
            this.txtuSur.Name = "txtuSur";
            this.txtuSur.Size = new System.Drawing.Size(132, 29);
            this.txtuSur.TabIndex = 7;
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(268, 84);
            this.txtUName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(132, 29);
            this.txtUName.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(125, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 18);
            this.label12.TabIndex = 5;
            this.label12.Text = "User Contact:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(128, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "User ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(128, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "User Surname";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(128, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(207, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 36);
            this.label7.TabIndex = 0;
            this.label7.Text = "Users";
            // 
            // Product
            // 
            this.Product.Controls.Add(this.btnProdUp);
            this.Product.Controls.Add(this.btnProdExit);
            this.Product.Controls.Add(this.btnProdDel);
            this.Product.Controls.Add(this.btnProdIn);
            this.Product.Controls.Add(this.dgvProduct);
            this.Product.Controls.Add(this.cmbCover);
            this.Product.Controls.Add(this.chkPro);
            this.Product.Controls.Add(this.chkAvail);
            this.Product.Controls.Add(this.txtPPrice);
            this.Product.Controls.Add(this.txtPerform);
            this.Product.Controls.Add(this.txtPName);
            this.Product.Controls.Add(this.label19);
            this.Product.Controls.Add(this.label18);
            this.Product.Controls.Add(this.label17);
            this.Product.Controls.Add(this.label16);
            this.Product.Controls.Add(this.label15);
            this.Product.Controls.Add(this.label14);
            this.Product.Controls.Add(this.label13);
            this.Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product.Location = new System.Drawing.Point(4, 25);
            this.Product.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(1004, 537);
            this.Product.TabIndex = 2;
            this.Product.Text = "Product";
            this.Product.UseVisualStyleBackColor = true;
            this.Product.Click += new System.EventHandler(this.Product_Click);
            // 
            // btnProdUp
            // 
            this.btnProdUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdUp.Location = new System.Drawing.Point(186, 368);
            this.btnProdUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProdUp.Name = "btnProdUp";
            this.btnProdUp.Size = new System.Drawing.Size(137, 31);
            this.btnProdUp.TabIndex = 21;
            this.btnProdUp.Text = "Update";
            this.btnProdUp.UseVisualStyleBackColor = true;
            this.btnProdUp.Click += new System.EventHandler(this.btnProdUp_Click);
            // 
            // btnProdExit
            // 
            this.btnProdExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdExit.Location = new System.Drawing.Point(865, 496);
            this.btnProdExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProdExit.Name = "btnProdExit";
            this.btnProdExit.Size = new System.Drawing.Size(137, 31);
            this.btnProdExit.TabIndex = 20;
            this.btnProdExit.Text = "Exit";
            this.btnProdExit.UseVisualStyleBackColor = true;
            this.btnProdExit.Click += new System.EventHandler(this.btnProdExit_Click);
            // 
            // btnProdDel
            // 
            this.btnProdDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdDel.Location = new System.Drawing.Point(667, 368);
            this.btnProdDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProdDel.Name = "btnProdDel";
            this.btnProdDel.Size = new System.Drawing.Size(137, 31);
            this.btnProdDel.TabIndex = 19;
            this.btnProdDel.Text = "Delete";
            this.btnProdDel.UseVisualStyleBackColor = true;
            this.btnProdDel.Click += new System.EventHandler(this.btnProdDel_Click);
            // 
            // btnProdIn
            // 
            this.btnProdIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdIn.Location = new System.Drawing.Point(424, 368);
            this.btnProdIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProdIn.Name = "btnProdIn";
            this.btnProdIn.Size = new System.Drawing.Size(137, 31);
            this.btnProdIn.TabIndex = 18;
            this.btnProdIn.Text = "Insert";
            this.btnProdIn.UseVisualStyleBackColor = true;
            this.btnProdIn.Click += new System.EventHandler(this.btnProdIn_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(488, 17);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(480, 300);
            this.dgvProduct.TabIndex = 17;
            // 
            // cmbCover
            // 
            this.cmbCover.FormattingEnabled = true;
            this.cmbCover.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbCover.Location = new System.Drawing.Point(273, 257);
            this.cmbCover.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCover.Name = "cmbCover";
            this.cmbCover.Size = new System.Drawing.Size(160, 26);
            this.cmbCover.TabIndex = 12;
            this.cmbCover.SelectedIndexChanged += new System.EventHandler(this.cmbCover_SelectedIndexChanged);
            // 
            // chkPro
            // 
            this.chkPro.AutoSize = true;
            this.chkPro.Location = new System.Drawing.Point(273, 294);
            this.chkPro.Margin = new System.Windows.Forms.Padding(4);
            this.chkPro.Name = "chkPro";
            this.chkPro.Size = new System.Drawing.Size(87, 22);
            this.chkPro.TabIndex = 11;
            this.chkPro.Text = "Available";
            this.chkPro.UseVisualStyleBackColor = true;
            // 
            // chkAvail
            // 
            this.chkAvail.AutoSize = true;
            this.chkAvail.Location = new System.Drawing.Point(273, 129);
            this.chkAvail.Margin = new System.Windows.Forms.Padding(4);
            this.chkAvail.Name = "chkAvail";
            this.chkAvail.Size = new System.Drawing.Size(87, 22);
            this.chkAvail.TabIndex = 10;
            this.chkAvail.Text = "Available";
            this.chkAvail.UseVisualStyleBackColor = true;
            // 
            // txtPPrice
            // 
            this.txtPPrice.Location = new System.Drawing.Point(273, 219);
            this.txtPPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPPrice.Name = "txtPPrice";
            this.txtPPrice.Size = new System.Drawing.Size(132, 24);
            this.txtPPrice.TabIndex = 9;
            // 
            // txtPerform
            // 
            this.txtPerform.Location = new System.Drawing.Point(273, 169);
            this.txtPerform.Margin = new System.Windows.Forms.Padding(4);
            this.txtPerform.Name = "txtPerform";
            this.txtPerform.Size = new System.Drawing.Size(132, 24);
            this.txtPerform.TabIndex = 8;
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(273, 87);
            this.txtPName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(132, 24);
            this.txtPName.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(90, 299);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(138, 18);
            this.label19.TabIndex = 6;
            this.label19.Text = "Product Promotion:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(90, 257);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(146, 18);
            this.label18.TabIndex = 5;
            this.label18.Text = "Product Cover Level:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(90, 219);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 18);
            this.label17.TabIndex = 4;
            this.label17.Text = "Product Price:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(90, 173);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(154, 18);
            this.label16.TabIndex = 3;
            this.label16.Text = "Product Performance:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(90, 129);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 18);
            this.label15.TabIndex = 2;
            this.label15.Text = "Product Availability:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(90, 87);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 18);
            this.label14.TabIndex = 1;
            this.label14.Text = "Product Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(185, 33);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 36);
            this.label13.TabIndex = 0;
            this.label13.Text = "Product";
            // 
            // Treatments
            // 
            this.Treatments.Controls.Add(this.label6);
            this.Treatments.Controls.Add(this.button1);
            this.Treatments.Controls.Add(this.txtSrchTrt);
            this.Treatments.Controls.Add(this.btnSrchTrt);
            this.Treatments.Controls.Add(this.dgvTreatments);
            this.Treatments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Treatments.Location = new System.Drawing.Point(4, 25);
            this.Treatments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Treatments.Name = "Treatments";
            this.Treatments.Size = new System.Drawing.Size(1004, 537);
            this.Treatments.TabIndex = 3;
            this.Treatments.Text = "Treatments";
            this.Treatments.UseVisualStyleBackColor = true;
            this.Treatments.Click += new System.EventHandler(this.Treatments_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(82, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 36);
            this.label6.TabIndex = 24;
            this.label6.Text = "Treatments";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(864, 504);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 31);
            this.button1.TabIndex = 23;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSrchTrt
            // 
            this.txtSrchTrt.Location = new System.Drawing.Point(100, 180);
            this.txtSrchTrt.Margin = new System.Windows.Forms.Padding(4);
            this.txtSrchTrt.Name = "txtSrchTrt";
            this.txtSrchTrt.Size = new System.Drawing.Size(132, 27);
            this.txtSrchTrt.TabIndex = 22;
            // 
            // btnSrchTrt
            // 
            this.btnSrchTrt.Location = new System.Drawing.Point(116, 118);
            this.btnSrchTrt.Margin = new System.Windows.Forms.Padding(4);
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
            this.dgvTreatments.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTreatments.Name = "dgvTreatments";
            this.dgvTreatments.RowHeadersWidth = 51;
            this.dgvTreatments.Size = new System.Drawing.Size(667, 400);
            this.dgvTreatments.TabIndex = 20;
            this.dgvTreatments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTreatments_CellContentClick);
            // 
            // Conditions
            // 
            this.Conditions.Controls.Add(this.txtConditionNewName);
            this.Conditions.Controls.Add(this.label24);
            this.Conditions.Controls.Add(this.txtCondtionName);
            this.Conditions.Controls.Add(this.label23);
            this.Conditions.Controls.Add(this.btnConUpdate);
            this.Conditions.Controls.Add(this.btnConExit);
            this.Conditions.Controls.Add(this.btnConDelete);
            this.Conditions.Controls.Add(this.btnConInsert);
            this.Conditions.Controls.Add(this.dgvConditions);
            this.Conditions.Controls.Add(this.label11);
            this.Conditions.Location = new System.Drawing.Point(4, 25);
            this.Conditions.Name = "Conditions";
            this.Conditions.Size = new System.Drawing.Size(1004, 537);
            this.Conditions.TabIndex = 4;
            this.Conditions.Text = "Conditions";
            this.Conditions.UseVisualStyleBackColor = true;
            // 
            // txtCondtionName
            // 
            this.txtCondtionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondtionName.Location = new System.Drawing.Point(233, 98);
            this.txtCondtionName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCondtionName.Name = "txtCondtionName";
            this.txtCondtionName.Size = new System.Drawing.Size(184, 34);
            this.txtCondtionName.TabIndex = 32;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(37, 98);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(193, 29);
            this.label23.TabIndex = 31;
            this.label23.Text = "Condition Name:";
            // 
            // btnConUpdate
            // 
            this.btnConUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConUpdate.Location = new System.Drawing.Point(185, 370);
            this.btnConUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConUpdate.Name = "btnConUpdate";
            this.btnConUpdate.Size = new System.Drawing.Size(137, 31);
            this.btnConUpdate.TabIndex = 30;
            this.btnConUpdate.Text = "Update";
            this.btnConUpdate.UseVisualStyleBackColor = true;
            this.btnConUpdate.Click += new System.EventHandler(this.btnConUpdate_Click);
            // 
            // btnConExit
            // 
            this.btnConExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConExit.Location = new System.Drawing.Point(866, 505);
            this.btnConExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConExit.Name = "btnConExit";
            this.btnConExit.Size = new System.Drawing.Size(137, 31);
            this.btnConExit.TabIndex = 29;
            this.btnConExit.Text = "Exit";
            this.btnConExit.UseVisualStyleBackColor = true;
            this.btnConExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConDelete
            // 
            this.btnConDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConDelete.Location = new System.Drawing.Point(328, 194);
            this.btnConDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConDelete.Name = "btnConDelete";
            this.btnConDelete.Size = new System.Drawing.Size(137, 31);
            this.btnConDelete.TabIndex = 28;
            this.btnConDelete.Text = "Delete";
            this.btnConDelete.UseVisualStyleBackColor = true;
            this.btnConDelete.Click += new System.EventHandler(this.btnConDelete_Click);
            // 
            // btnConInsert
            // 
            this.btnConInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConInsert.Location = new System.Drawing.Point(185, 194);
            this.btnConInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConInsert.Name = "btnConInsert";
            this.btnConInsert.Size = new System.Drawing.Size(137, 31);
            this.btnConInsert.TabIndex = 27;
            this.btnConInsert.Text = "Insert";
            this.btnConInsert.UseVisualStyleBackColor = true;
            this.btnConInsert.Click += new System.EventHandler(this.btnConInsert_Click);
            // 
            // dgvConditions
            // 
            this.dgvConditions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConditions.Location = new System.Drawing.Point(489, 26);
            this.dgvConditions.Name = "dgvConditions";
            this.dgvConditions.RowHeadersWidth = 51;
            this.dgvConditions.RowTemplate.Height = 24;
            this.dgvConditions.Size = new System.Drawing.Size(480, 300);
            this.dgvConditions.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(116, 40);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 36);
            this.label11.TabIndex = 25;
            this.label11.Text = "Conditions";
            // 
            // txtConditionNewName
            // 
            this.txtConditionNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConditionNewName.Location = new System.Drawing.Point(255, 320);
            this.txtConditionNewName.Margin = new System.Windows.Forms.Padding(4);
            this.txtConditionNewName.Name = "txtConditionNewName";
            this.txtConditionNewName.Size = new System.Drawing.Size(184, 34);
            this.txtConditionNewName.TabIndex = 34;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(59, 320);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(182, 29);
            this.label24.TabIndex = 33;
            this.label24.Text = "Updated Name:";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 574);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.ProviderManage_Load);
            this.tabControl1.ResumeLayout(false);
            this.Provider.ResumeLayout(false);
            this.Provider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPro)).EndInit();
            this.Users.ResumeLayout(false);
            this.Users.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.Product.ResumeLayout(false);
            this.Product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.Treatments.ResumeLayout(false);
            this.Treatments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).EndInit();
            this.Conditions.ResumeLayout(false);
            this.Conditions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConditions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Provider;
        private System.Windows.Forms.Button btnProUp;
        private System.Windows.Forms.CheckBox chkCheck;
        private System.Windows.Forms.TextBox txtAgree;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Users;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage Product;
        private System.Windows.Forms.TabPage Treatments;
        private System.Windows.Forms.Button btnUUp;
        private System.Windows.Forms.TextBox txtUContact;
        private System.Windows.Forms.TextBox txtUID;
        private System.Windows.Forms.TextBox txtuSur;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCover;
        private System.Windows.Forms.CheckBox chkPro;
        private System.Windows.Forms.CheckBox chkAvail;
        private System.Windows.Forms.TextBox txtPPrice;
        private System.Windows.Forms.TextBox txtPerform;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSrchTrt;
        private System.Windows.Forms.DataGridView dgvTreatments;
        private System.Windows.Forms.TextBox txtSrchTrt;
        private System.Windows.Forms.Button btnProDel;
        private System.Windows.Forms.Button btnProIn;
        private System.Windows.Forms.DataGridView dgvPro;
        private System.Windows.Forms.Button btnProExit;
        private System.Windows.Forms.Button btnUExit;
        private System.Windows.Forms.Button btnUDel;
        private System.Windows.Forms.Button btnUIn;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnProdUp;
        private System.Windows.Forms.Button btnProdExit;
        private System.Windows.Forms.Button btnProdDel;
        private System.Windows.Forms.Button btnProdIn;
        private System.Windows.Forms.DataGridView dgvProduct;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUPass;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox cbAdmin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage Conditions;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnConExit;
        private System.Windows.Forms.Button btnConDelete;
        private System.Windows.Forms.Button btnConInsert;
        private System.Windows.Forms.DataGridView dgvConditions;
        private System.Windows.Forms.Button btnConUpdate;
        private System.Windows.Forms.TextBox txtCondtionName;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtConditionNewName;
        private System.Windows.Forms.Label label24;
    }
}
﻿namespace Ukupholisa3
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
            this.tabShowAccounts = new System.Windows.Forms.TabPage();
            this.Product = new System.Windows.Forms.TabPage();
            this.btnPSub = new System.Windows.Forms.Button();
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
            this.txtSrchTrt = new System.Windows.Forms.TextBox();
            this.btnSrchTrt = new System.Windows.Forms.Button();
            this.dgvTreatments = new System.Windows.Forms.DataGridView();
            this.Conditions = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dgvViewAccounts = new System.Windows.Forms.DataGridView();
            this.userTabCtrl.SuspendLayout();
            this.tabCall.SuspendLayout();
            this.tabShowAccounts.SuspendLayout();
            this.Product.SuspendLayout();
            this.Treatments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).BeginInit();
            this.Conditions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // userTabCtrl
            // 
            this.userTabCtrl.Controls.Add(this.tabCall);
            this.userTabCtrl.Controls.Add(this.tabShowAccounts);
            this.userTabCtrl.Controls.Add(this.Product);
            this.userTabCtrl.Controls.Add(this.Treatments);
            this.userTabCtrl.Controls.Add(this.Conditions);
            this.userTabCtrl.Location = new System.Drawing.Point(0, 1);
            this.userTabCtrl.Margin = new System.Windows.Forms.Padding(2);
            this.userTabCtrl.Name = "userTabCtrl";
            this.userTabCtrl.SelectedIndex = 0;
            this.userTabCtrl.Size = new System.Drawing.Size(759, 460);
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
            this.tabCall.Size = new System.Drawing.Size(751, 434);
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
            // tabShowAccounts
            // 
            this.tabShowAccounts.Controls.Add(this.dgvViewAccounts);
            this.tabShowAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabShowAccounts.Location = new System.Drawing.Point(4, 22);
            this.tabShowAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.tabShowAccounts.Name = "tabShowAccounts";
            this.tabShowAccounts.Padding = new System.Windows.Forms.Padding(2);
            this.tabShowAccounts.Size = new System.Drawing.Size(751, 434);
            this.tabShowAccounts.TabIndex = 1;
            this.tabShowAccounts.Text = "Accounts";
            this.tabShowAccounts.UseVisualStyleBackColor = true;
            // 
            // Product
            // 
            this.Product.Controls.Add(this.btnPSub);
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
            this.Product.Location = new System.Drawing.Point(4, 22);
            this.Product.Margin = new System.Windows.Forms.Padding(2);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(751, 434);
            this.Product.TabIndex = 2;
            this.Product.Text = "Product";
            this.Product.UseVisualStyleBackColor = true;
            // 
            // btnPSub
            // 
            this.btnPSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSub.Location = new System.Drawing.Point(254, 278);
            this.btnPSub.Name = "btnPSub";
            this.btnPSub.Size = new System.Drawing.Size(75, 23);
            this.btnPSub.TabIndex = 13;
            this.btnPSub.Text = "Submit";
            this.btnPSub.UseVisualStyleBackColor = true;
            // 
            // cmbCover
            // 
            this.cmbCover.FormattingEnabled = true;
            this.cmbCover.Location = new System.Drawing.Point(306, 203);
            this.cmbCover.Name = "cmbCover";
            this.cmbCover.Size = new System.Drawing.Size(121, 23);
            this.cmbCover.TabIndex = 12;
            // 
            // chkPro
            // 
            this.chkPro.AutoSize = true;
            this.chkPro.Location = new System.Drawing.Point(306, 233);
            this.chkPro.Name = "chkPro";
            this.chkPro.Size = new System.Drawing.Size(75, 19);
            this.chkPro.TabIndex = 11;
            this.chkPro.Text = "Available";
            this.chkPro.UseVisualStyleBackColor = true;
            // 
            // chkAvail
            // 
            this.chkAvail.AutoSize = true;
            this.chkAvail.Location = new System.Drawing.Point(306, 99);
            this.chkAvail.Name = "chkAvail";
            this.chkAvail.Size = new System.Drawing.Size(75, 19);
            this.chkAvail.TabIndex = 10;
            this.chkAvail.Text = "Available";
            this.chkAvail.UseVisualStyleBackColor = true;
            // 
            // txtPPrice
            // 
            this.txtPPrice.Location = new System.Drawing.Point(306, 172);
            this.txtPPrice.Name = "txtPPrice";
            this.txtPPrice.Size = new System.Drawing.Size(100, 21);
            this.txtPPrice.TabIndex = 9;
            // 
            // txtPerform
            // 
            this.txtPerform.Location = new System.Drawing.Point(306, 132);
            this.txtPerform.Name = "txtPerform";
            this.txtPerform.Size = new System.Drawing.Size(100, 21);
            this.txtPerform.TabIndex = 8;
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(306, 65);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(100, 21);
            this.txtPName.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(169, 237);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(112, 15);
            this.label19.TabIndex = 6;
            this.label19.Text = "Product Promotion:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(169, 203);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(118, 15);
            this.label18.TabIndex = 5;
            this.label18.Text = "Product Cover Level:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(169, 172);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 15);
            this.label17.TabIndex = 4;
            this.label17.Text = "Product Price:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(169, 135);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 15);
            this.label16.TabIndex = 3;
            this.label16.Text = "Product Performance:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(169, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 15);
            this.label15.TabIndex = 2;
            this.label15.Text = "Product Availability:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(169, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "Product Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(240, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 29);
            this.label13.TabIndex = 0;
            this.label13.Text = "Product";
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
            this.Treatments.Size = new System.Drawing.Size(751, 434);
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
            this.Conditions.Controls.Add(this.label21);
            this.Conditions.Controls.Add(this.label20);
            this.Conditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conditions.Location = new System.Drawing.Point(4, 22);
            this.Conditions.Margin = new System.Windows.Forms.Padding(2);
            this.Conditions.Name = "Conditions";
            this.Conditions.Size = new System.Drawing.Size(751, 434);
            this.Conditions.TabIndex = 4;
            this.Conditions.Text = "Conditions";
            this.Conditions.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(139, 100);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 17);
            this.label21.TabIndex = 1;
            this.label21.Text = "label21";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(209, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(138, 29);
            this.label20.TabIndex = 0;
            this.label20.Text = "Conditions";
            // 
            // dgvViewAccounts
            // 
            this.dgvViewAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewAccounts.Location = new System.Drawing.Point(200, 32);
            this.dgvViewAccounts.Name = "dgvViewAccounts";
            this.dgvViewAccounts.Size = new System.Drawing.Size(500, 325);
            this.dgvViewAccounts.TabIndex = 21;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 518);
            this.Controls.Add(this.userTabCtrl);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.userTabCtrl.ResumeLayout(false);
            this.tabCall.ResumeLayout(false);
            this.tabCall.PerformLayout();
            this.tabShowAccounts.ResumeLayout(false);
            this.Product.ResumeLayout(false);
            this.Product.PerformLayout();
            this.Treatments.ResumeLayout(false);
            this.Treatments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).EndInit();
            this.Conditions.ResumeLayout(false);
            this.Conditions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl userTabCtrl;
        private System.Windows.Forms.TabPage tabCall;
        private System.Windows.Forms.TabPage tabShowAccounts;
        private System.Windows.Forms.TabPage Product;
        private System.Windows.Forms.Button btnPSub;
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
        private System.Windows.Forms.TabPage Treatments;
        private System.Windows.Forms.TextBox txtSrchTrt;
        private System.Windows.Forms.Button btnSrchTrt;
        private System.Windows.Forms.DataGridView dgvTreatments;
        private System.Windows.Forms.TabPage Conditions;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
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
    }
}
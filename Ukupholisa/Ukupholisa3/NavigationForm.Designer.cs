namespace Ukupholisa3
{
    partial class NavigationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCallForm = new System.Windows.Forms.Button();
            this.btnClientForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Navigation";
            // 
            // btnCallForm
            // 
            this.btnCallForm.BackColor = System.Drawing.Color.Transparent;
            this.btnCallForm.Location = new System.Drawing.Point(471, 103);
            this.btnCallForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCallForm.Name = "btnCallForm";
            this.btnCallForm.Size = new System.Drawing.Size(100, 28);
            this.btnCallForm.TabIndex = 1;
            this.btnCallForm.Text = "Call Form";
            this.btnCallForm.UseVisualStyleBackColor = false;
            this.btnCallForm.Click += new System.EventHandler(this.btnCallForm_Click);
            // 
            // btnClientForm
            // 
            this.btnClientForm.BackColor = System.Drawing.Color.Transparent;
            this.btnClientForm.Location = new System.Drawing.Point(471, 151);
            this.btnClientForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClientForm.Name = "btnClientForm";
            this.btnClientForm.Size = new System.Drawing.Size(100, 28);
            this.btnClientForm.TabIndex = 2;
            this.btnClientForm.Text = "Client Form";
            this.btnClientForm.UseVisualStyleBackColor = false;
            this.btnClientForm.Click += new System.EventHandler(this.btnClientForm_Click);
            // 
            // NavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnClientForm);
            this.Controls.Add(this.btnCallForm);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NavigationForm";
            this.Text = "NavigationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCallForm;
        private System.Windows.Forms.Button btnClientForm;
    }
}
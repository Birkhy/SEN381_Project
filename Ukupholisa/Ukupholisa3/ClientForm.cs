using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukupholisa3
{
    public partial class ClientForm : Form
    {
        DataHandler Handle = new DataHandler();
        BindingSource Source = new BindingSource();
        List<Accounts> getAccounts = new List<Accounts>();
        public ClientForm()
        {
            InitializeComponent();
            dgvClients.DataSource = Source;

            MessageBox.Show(Handle.GetClient());

            try
            {
                
                Source.DataSource = getAccounts;
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong trying to view Account.");
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //string CID, string SName, string SSName, DateTime DOB, string Sex
            string Sex = string.Empty;
            if(rbnMale.Checked == true){
                Sex = "Male";
            }else if(rbnFemale.Checked == false){
                Sex = "Female";
            }else{
                Sex = "Other";
            }

            try
            {
                Handle.AddClient(txtID.Text, txtName.Text, txtSName.Text, dtkDOB.Value, Sex);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong trying to insert the specified Client.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Handle.SearchClient(txtID.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong trying to search the specified Client.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            string Sex = string.Empty;
            if (rbnMale.Checked == true)
            {
                Sex = "Male";
            }
            else if (rbnFemale.Checked == false)
            {
                Sex = "Female";
            }
            else
            {
                Sex = "Other";
            }

            try
            {
                Handle.UpdateClient(txtID.Text, txtName.Text, txtSName.Text, dtkDOB.Value, Sex);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong trying to update the specified Client.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Handle.DeleteClient(txtID.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong trying to delete the specified Client.");
            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

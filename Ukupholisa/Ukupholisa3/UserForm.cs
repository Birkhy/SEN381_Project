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
    public partial class UserForm : Form
    {
        DataHandler Handle = new DataHandler();
        public UserForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(Handle.checkAccount(txtHID.Text).ToString());
                //if (Handle.checkAccount(txtHID.Text) == true)
                //{
                //    MessageBox.Show("Account Exists");
                //}
                //else
                //{
                //    MessageBox.Show("Account does not exist");
                //}
                
            }
            catch (Exception)
            {
                //e.GetBaseException();
                MessageBox.Show("Something went wrong trying to check account.");
            }
        }
    }
}

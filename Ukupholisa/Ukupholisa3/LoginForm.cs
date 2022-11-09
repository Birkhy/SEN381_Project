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

namespace Genisis
{
    public partial class LoginForm : Form
    {
        DataHandler handler = new DataHandler();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(handler.GetPreformance().ToString());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (handler.CheckUserLog(txtUserName.Text.Trim(), txtPass.Text))
                {
                    UserForm nf = new UserForm();
                    nf.Show();
                    this.Hide();
                }
                else 
                {
                    MessageBox.Show("These credential does not exist within the database.");
                }
            }
            catch
            {
                MessageBox.Show("Somthing whent wrong trying to login to the program, please try again later.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(handler.GetPreformance().ToString());
            try
            {
                if (handler.CheckAdminLog(txtUserName.Text.Trim(), txtPass.Text))
                {
                    AdminForm af = new AdminForm();
                    af.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("These credential does not exist within the database.");
                }
            }
            catch
            {
                MessageBox.Show("Somthing whent wrong trying to login to the program, please try again later.");
            }
        }
    }
}

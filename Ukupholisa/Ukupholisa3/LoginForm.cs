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
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            NavigationForm nf = new NavigationForm();
            nf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProviderManage pm = new ProviderManage();
            pm.Show();
            this.Hide();
        }
    }
}

using Genisis;
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
    public partial class NavigationForm : Form
    {
        public NavigationForm()
        {
            InitializeComponent();
        }

        private void btnCallForm_Click(object sender, EventArgs e)
        {
            CallForm cf = new CallForm();
            cf.Show();
            this.Hide();
        }

        private void btnClientForm_Click(object sender, EventArgs e)
        {
            ClientForm clf = new ClientForm();
            clf.Show();
            this.Hide();
        }
    }
}

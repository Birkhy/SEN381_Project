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
    public partial class ProviderManage : Form
    {
        DataHandler Handle = new DataHandler();
        //BindingSource Source = new BindingSource();
        public ProviderManage()
        {
            InitializeComponent();
        }

        private void btnSrchTrt_Click(object sender, EventArgs e)
        {

            // getAccounts = Handle.GetClient();

            //dgvTreatments.DataSource = Source;
            //MessageBox.Show(Handle.GetClient(););

            try
            {
                
                dgvTreatments.DataSource =  Handle.SearchTreatment(txtSrchTrt.Text);
                dgvTreatments.AutoResizeColumns();
                //MessageBox.Show("Handler supposed to work");
                //Source.DataSource = //Handle.GetClient();

            }
            catch (Exception)
            {
                //e.GetBaseException();
                MessageBox.Show("Something went wrong trying to view Treatments.");
            }
        }

        private void ProviderManage_Load(object sender, EventArgs e)
        {

        }

        private void dgvTreatments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Treatments_Click(object sender, EventArgs e)
        {

        }
    }
}

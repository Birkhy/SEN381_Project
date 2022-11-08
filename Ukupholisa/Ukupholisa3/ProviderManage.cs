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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Genisis
{
    public partial class AdminForm : Form
    {
        DataHandler Handle = new DataHandler();
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnSrchTrt_Click(object sender, EventArgs e)
        {
            try
            {
                dgvTreatments.DataSource =  Handle.SearchTreatment(txtSrchTrt.Text);
                dgvTreatments.AutoResizeColumns();

            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong trying to view Treatments.");
            }
        }

        private void ProviderManage_Load(object sender, EventArgs e)
        {
            //Will display the Providers on Initialization
            try
            {
                dgvPro.DataSource = Handle.getProvider();
            }
            catch (Exception)
            {
                MessageBox.Show("Somthing went wrong trying to display the Providers.");
            }

            //Will display the Users on Initialization
            try
            {
                dgvUsers.DataSource = Handle.getUser();
            }
            catch (Exception)
            {
                MessageBox.Show("Somthing went wrong trying to display the Users.");
            }

            //Will display the Products on Treatments
            try
            {
                dgvTreatments.DataSource = Handle.getTreatments();
            }
            catch (Exception)
            {
                MessageBox.Show("Somthing went wrong trying to display the Treatments.");
            }

            //Will display the Products on Initialization
            try
            {
                dgvProduct.DataSource = Handle.getProduct();
            }
            catch (Exception)
            {
                MessageBox.Show("Somthing went wrong trying to display the Products.");
            }


        }

        private void dgvTreatments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Treatments_Click(object sender, EventArgs e)
        {

        }

        private void btnProExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnUExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnProdExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnUUp_Click(object sender, EventArgs e)
        {
            int Clearance = 0;

            if (cbAdmin.Checked)
            {
                Clearance = 1;
            }

            //try
            //{
                MessageBox.Show(Handle.updateUser(txtUName.Text, txtuSur.Text, txtUContact.Text, txtUID.Text, txtUserName.Text, txtUPass.Text, Clearance));
                dgvUsers.DataSource = Handle.getUser();
            //}
            //catch
            //{
            //    MessageBox.Show($"Somthing went wrong trying to Update User with ID: {txtUID.Text}");
            //}
        }

        private void btnShowU_Click(object sender, EventArgs e)
        {
            //try
            //{
                dgvUsers.DataSource = Handle.getUser();
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Somthing went wrong trying to display the Users.");
            //}
        }

        private void btnUIn_Click(object sender, EventArgs e)
        {
            int Clearance = 0;

            if (cbAdmin.Checked)
            {
                Clearance = 1;
            }

            //try
            //{
                MessageBox.Show(Handle.addUser(txtUName.Text, txtuSur.Text, txtUContact.Text, txtUID.Text, txtUserName.Text, txtUPass.Text, Clearance));
                dgvUsers.DataSource = Handle.getUser();
            //}
            //catch
            //{
            //    MessageBox.Show($"Somthing went wrong trying to Insert User with ID: {txtUID.Text}");
            //}
        }

        private void btnUDel_Click(object sender, EventArgs e)
        {
            //try
            //{
                MessageBox.Show(Handle.deleteUser(txtUID.Text));
                dgvUsers.DataSource = Handle.getUser();
            //}
            //catch
            //{
            //    MessageBox.Show($"Somthing went wrong trying to Delete User with ID: {txtUID.Text}");
            //}
        }

        private void btnProUp_Click(object sender, EventArgs e)
        {
            int Status = 0;

            if (chkCheck.Checked)
            {
                Status = 1;
            }

            //try
            //{
                MessageBox.Show(Handle.updateProvider(txtName.Text, Status, txtAgree.Text, txtContact.Text));
                dgvPro.DataSource = Handle.getProvider();
            //}
            //catch
            //{
            //    MessageBox.Show($"Somthing went wrong trying to Update Provider with the Name: {txtName.Text}");
            //}
        }

        private void btnProIn_Click(object sender, EventArgs e)
        {
            int Status = 0;

            if (chkCheck.Checked)
            {
                Status = 1;
            }

            //try
            //{
                MessageBox.Show(Handle.addProvider(txtName.Text, Status, txtAgree.Text, txtContact.Text));
                dgvPro.DataSource = Handle.getProvider();
            //}
            //catch
            //{
            //    MessageBox.Show($"Somthing went wrong trying to Update Provider with the Name: {txtName.Text}");
            //}
        }

        private void btnProDel_Click(object sender, EventArgs e)
        {
            //try
            //{
                MessageBox.Show(Handle.deleteProvider(txtName.Text));
                dgvPro.DataSource = Handle.getProvider();
            //}
            //catch
            //{
            //    MessageBox.Show($"Somthing went wrong trying to Delete Provider with the Name: {txtName.Text}");
            //}
        }

        private void btnProdUp_Click(object sender, EventArgs e)
        {
            int Avail = 0;
            int Pro = 0;

            if (chkAvail.Checked)
            {
                Avail = 1;
            }else if (chkPro.Checked)
            {
                Pro = 1;
            }

            //try
            //{
                MessageBox.Show(Handle.updateProduct(txtPName.Text, double.Parse(txtPPrice.Text), Avail, double.Parse(txtPerform.Text), int.Parse(cmbCover.Text), Pro));
                dgvProduct.DataSource = Handle.getProduct();
            //}
            //catch
            //{
                //MessageBox.Show($"Somthing went wrong trying to Update Product with the Name: {txtPName.Text}");
            //}
        }

        private void Product_Click(object sender, EventArgs e)
        {

        }

        private void btnProdIn_Click(object sender, EventArgs e)
        {
            int Avail = 0;
            int Pro = 0;

            if (chkAvail.Checked)
            {
                Avail = 1;
            }
            else if (chkPro.Checked)
            {
                Pro = 1;
            }

            //try
            //{
                MessageBox.Show(Handle.addProduct(txtPName.Text, double.Parse(txtPPrice.Text), Avail, double.Parse(txtPerform.Text), int.Parse(cmbCover.Text), Pro));
                dgvProduct.DataSource = Handle.getProduct();
            //}
            //catch
            //{
            //    MessageBox.Show($"Somthing went wrong trying to Insert Product with the Name: {txtPName.Text}");
            //}
        }

        private void btnProdDel_Click(object sender, EventArgs e)
        {
            //try
            //{
                MessageBox.Show(Handle.deleteProduct(txtPName.Text));
                dgvProduct.DataSource = Handle.getProduct();
            //}
            //catch
            //{
            //    MessageBox.Show($"Somthing went wrong trying to Delete Product with the Name: {txtPName.Text}");
            //}
        }

        private void cmbCover_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnShowPro_Click(object sender, EventArgs e)
        {
            //try
            //{
                dgvPro.DataSource = Handle.getProduct();
            //}
            //catch (Exception)
            //{
                MessageBox.Show("Somthing went wrong trying to display the Products.");
            //}
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

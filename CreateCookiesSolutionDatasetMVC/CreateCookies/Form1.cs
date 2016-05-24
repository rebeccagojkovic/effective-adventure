using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace CreateCookies
{
    public partial class Form1 : Form
    {
        Controller.Controller controller;
        public Form1(Controller.Controller controller)
        {
            this.controller = controller;
            InitializeComponent();
            dataGridViewCustomersOrders.DataSource = null;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.palletTableAdapter.Fill(this.createCookiesDataSetTheOne.Pallet);
            this.orderspecificationTableAdapter.Fill(this.createCookiesDataSetTheOne1.Orderspecification);
            this.producedTableAdapter.Fill(this.createCookiesDataSetTheOne.Produced);
            this.supplierTableAdapter.Fill(this.createCookiesDataSetTheOne.Supplier);
            this.ingredientTableAdapter.Fill(this.createCookiesDataSetTheOne.Ingredient);
            this.productTableAdapter.Fill(this.createCookiesDataSetTheOne.Product);
            this.ordeTableAdapter.Fill(this.createCookiesDataSetTheOne.Orde);
            this.customerTableAdapter.Fill(this.createCookiesDataSetTheOne.Customer);
        }

        private void ButtonRegCustomer_Click(object sender, EventArgs e)
        {
            string[] customer = new string[6];
            try
            {
                customer[0] = TextBoxCnumber.Text;
                customer[1] = TextBoxCname.Text;
                customer[2] = TextBoxCaddress.Text;
                customer[3] = TextBoxCpostalAddress.Text;
                customer[4] = ComboBoxCcountry.Text;
                customer[5] = TextBoxCemail.Text;

                controller.RegisterCustomer(customer);
                toolStripStatusLabel1.Text = "Successful";

            }
            catch (Exception Ex)
            {
                string errorMessage = controller.Exception(Ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void BtnDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComboBoxDCnumber.SelectedIndex != -1)
                {
                    String cNumber = ComboBoxDCnumber.Text;
                    controller.DeleteCustomer(cNumber);
                }
                toolStripStatusLabel1.Text = "Successful";
            }
            catch (Exception Ex)
            {
                string errorMessage = controller.Exception(Ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void BtnSearchCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComboBoxUCnumber.SelectedIndex != -1)
                {
                    string cNumber = ComboBoxUCnumber.Text;
                    string[] searchCustomerValues = controller.SearchCustomer(cNumber);

                    foreach (string s in searchCustomerValues)
                    {
                        TextBoxUCname.Text = searchCustomerValues[0];
                        TextBoxUCaddress.Text = searchCustomerValues[1];
                        TextBoxUCpostaladdress.Text = searchCustomerValues[2];
                        ComboBoxUCcountry.Text = searchCustomerValues[3];
                        TextBoxUCemail.Text = searchCustomerValues[4];
                    }
                }
                toolStripStatusLabel1.Text = "Successful";
            }
            catch (Exception Ex)
            {
                string errorMessage = controller.Exception(Ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnNewCustomer_Click(object sender, EventArgs e)
        {
            TextBoxCnumber.Clear();
            TextBoxCname.Clear();
            TextBoxCaddress.Clear();
            TextBoxCpostalAddress.Clear();
            ComboBoxCcountry.SelectedIndex = -1;
            TextBoxCemail.Clear();
        }

        private void BtnUppdateCustomer_Click(object sender, EventArgs e)
        {
            string[] customer = new string[6];

            try
            {
                customer[0] = ComboBoxUCnumber.Text;
                customer[1] = TextBoxUCname.Text;
                customer[2] = TextBoxUCaddress.Text;
                customer[3] = TextBoxUCpostaladdress.Text;
                customer[4] = ComboBoxUCcountry.Text;
                customer[5] = TextBoxUCemail.Text;

                controller.UpdateCustomer(customer);
                toolStripStatusLabel1.Text = "Successful";

            }
            catch (Exception Ex)
            {
                string errorMessage = controller.Exception(Ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnSeeOrders_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewCustomersOrders.DataSource = controller.SeeOrder(ComboBoxOCnumber.Text.Trim());
                toolStripStatusLabel1.Text = "Successful";
            }
            catch (Exception Ex)
            {

                string errorMessage = controller.Exception(Ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BtnSeeAllOrders_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewCustomersOrders.DataSource = controller.SeeAllOrders();
                toolStripStatusLabel1.Text = "Successful";
            }
            catch (Exception Ex)
            {

                string errorMessage = controller.Exception(Ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxSearchOrder_TextChanged(object sender, EventArgs e)
        {
            String searchOrder = TextBoxSearchOrder.Text;


            if (ComboBoxSearchOrder.Text == "Order_Number")
            {
                dataGridViewOrderControl.DataSource = controller.SearchOrderNumber(TextBoxSearchOrder.Text);
            }
            else if (ComboBoxSearchOrder.Text == "Expected_Delivery_Date")
            {
                dataGridViewOrderControl.DataSource = controller.SearchExpectedDeliveryDate(TextBoxSearchOrder.Text);
            }
            else if (ComboBoxSearchOrder.Text == "Is_Delivered")
            {
                dataGridViewOrderControl.DataSource = controller.SearchIsDelivered(TextBoxSearchOrder.Text);
            }
            else if (ComboBoxSearchOrder.Text == "Customer_Number")
            {
                dataGridViewOrderControl.DataSource = controller.SearchCustomerNumber(TextBoxSearchOrder.Text);
            }
            //toolStripStatusLabel1.Text = "Successful";
        }

        private void BtnDeleteOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComboBoxDCnumber.SelectedIndex != -1)
                {
                    string oNumber = ComboBoxChooseOrder.Text;
                    controller.DeleteOrder(oNumber);
                }
                toolStripStatusLabel1.Text = "Successful";
            }
            catch (Exception Ex)
            {
                string errorMessage = controller.Exception(Ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnChoosenOrderInformation_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewOrderInformation.DataSource = controller.ChooseOrderinformation(ComboBox1.Text.Trim());
            toolStripStatusLabel1.Text = "Successful";
            }
            catch (Exception Ex)
            {
                toolStripStatusLabel1.Text = "";
                string errorMessage = controller.Exception(Ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ComboBoxChooseCookies_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] prList = controller.GetProducts(ComboBoxChooseCookies.Text);

            try
            {
                foreach (string s in prList)
                {
                    TextBoxProductNUmberOA.Text = prList[0];
                }
               // toolStripStatusLabel1.Text = "Successful";
            }
            catch (Exception Ex)
            {
                toolStripStatusLabel1.Text = "";
                string errorMessage = controller.Exception(Ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnAddOder_Click(object sender, EventArgs e)
        {

            String[] Order = new String[4];
            String[] Orderspecification = new String[3];

            try
            {

                Order[0] = TextBoxGenerateOrderNumber.Text;
                Order[1] = TextBoxisDeliveredAO.Text;
                Order[2] = DateTimePickerDeliveryDateAO.ToString();
                Order[3] = ComboBoxAOCnumber.Text;

                Orderspecification[0] = TextBoxGenerateOrderNumber.Text;
                Orderspecification[1] = TextBoxProductNUmberOA.Text;
                Orderspecification[2] = ComboBoxPalletQuantity.Text;

                controller.RegisterOrder(Order, Orderspecification);
                toolStripStatusLabel1.Text = "Successful";

            }
            catch (Exception Ex)
            {
                toolStripStatusLabel1.Text = "";
                string errorMessage = controller.Exception(Ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnProduce_Click(object sender, EventArgs e)
        {
            try
            {
                controller.AddProduce(DateTimePickerPProductTime.Value, TextBoxProductToProduce.Text, TextBoxpalletamountProduction.Text, TextBoxpNumberProduction.Text, ComboBoxOrderNumberProduction.Text);
                this.producedTableAdapter.Fill(this.createCookiesDataSetTheOne.Produced);
                this.ingredientTableAdapter.Fill(this.createCookiesDataSetTheOne.Ingredient);

                toolStripStatusLabel1.Text = "Successful";
            }
            catch (Exception Ex)
            {
                toolStripStatusLabel1.Text = "";
                string errorMessage = controller.Exception(Ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            

        }

        private void ComboBoxOrderNumberProduction_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] prList = controller.GetProductToProduceValues();

            try
            {
                foreach (string s in prList)
                {
                    TextBoxpNumberProduction.Text = prList[0];
                    TextBoxpalletamountProduction.Text = prList[1];
                    TextBoxProductToProduce.Text = prList[2];
                    TextBoxEDDProduction.Text = prList[3];
                }
              //  toolStripStatusLabel1.Text = "Successful";
            }
            catch (Exception Ex)
            {
                toolStripStatusLabel1.Text = "";
                string errorMessage = controller.Exception(Ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnAddSupplier_Click(object sender, EventArgs e)
        {
        }

        private void BtnSeeOrders_Click_1(object sender, EventArgs e)
        {
        }

        private void BtnStore_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxCooseFromProducedProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] prList = controller.GetProduced(ComboBoxCooseFromProducedProducts.Text);
            try
            {
                foreach (string s in prList)
                {
                    TextBoxStorageProduced.Text = prList[0];
                    TextBoxStoragePNumber.Text = prList[1];
                    TextBoxStorageONumber.Text = prList[2];

                }
              //  toolStripStatusLabel1.Text = "Successful";
            }
            catch (Exception Ex)
            {
                toolStripStatusLabel1.Text = "";
                string errorMessage = controller.Exception(Ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime myDateTime = DateTime.Now;
            controller.AddPallet(TextBoxPalletID.Text, myDateTime, TextBoxStoragePNumber.Text, TextBoxStorageONumber.Text);
            dataGridViewStorage1.DataSource = controller.GetPallet();
                toolStripStatusLabel1.Text = "Successful";
            }
            catch (Exception Ex)
            {
                toolStripStatusLabel1.Text = "";
                string errorMessage = controller.Exception(Ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            this.palletTableAdapter.Fill(this.createCookiesDataSetTheOne.Pallet);
            this.orderspecificationTableAdapter.Fill(this.createCookiesDataSetTheOne1.Orderspecification);
            this.producedTableAdapter.Fill(this.createCookiesDataSetTheOne.Produced);
            this.supplierTableAdapter.Fill(this.createCookiesDataSetTheOne.Supplier);
            this.ingredientTableAdapter.Fill(this.createCookiesDataSetTheOne.Ingredient);
            this.productTableAdapter.Fill(this.createCookiesDataSetTheOne.Product);
            this.ordeTableAdapter.Fill(this.createCookiesDataSetTheOne.Orde);
            this.customerTableAdapter.Fill(this.createCookiesDataSetTheOne.Customer);
        }

    }
}
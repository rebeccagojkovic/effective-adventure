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
using CreateCookies.Model;


namespace CreateCookies
{
    public partial class Form1 : Form
    {
        Controller.Controller controller;
        public Form1(Controller.Controller controller)
        {
            this.controller = controller;
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'createCookiesDataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.createCookiesDataSet.Supplier);
            // TODO: This line of code loads data into the 'createCookiesDataSet.Ingredient' table. You can move, or remove it, as needed.
            this.ingredientTableAdapter.Fill(this.createCookiesDataSet.Ingredient);
            // TODO: This line of code loads data into the 'createCookiesDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.createCookiesDataSet.Product);
            // TODO: This line of code loads data into the 'createCookiesDataSet.Orde' table. You can move, or remove it, as needed.
            this.ordeTableAdapter.Fill(this.createCookiesDataSet.Orde);
            // TODO: This line of code loads data into the 'createCookiesDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.createCookiesDataSet.Customer);
            // TODO: This line of code loads data into the 'createCookiesDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.createCookiesDataSet.Customer);

        }




        private void buttonRegCustomer_Click(object sender, EventArgs e)
        {

            SqlConnection RegisterCustomerConnection = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=CreateCookies;Persist Security Info=True;User ID=grupp15;Password=Grupp15");
            SqlCommand RegisterCustommerCommand = new SqlCommand("insert into Customer (cNumber, cName, cAddress, cPostalAddress, cCountry, cEmail) values(@cNumber, @cName, @cAddress, @cPostalAddress, @cCountry, @cEmail)", RegisterCustomerConnection);

            RegisterCustommerCommand.Parameters.AddWithValue("@cNumber", textBoxCnumber.Text);
            RegisterCustommerCommand.Parameters.AddWithValue("@cName", textBoxCname.Text);
            RegisterCustommerCommand.Parameters.AddWithValue("@cAddress", textBoxCaddress.Text);
            RegisterCustommerCommand.Parameters.AddWithValue("@cPostalAddress", textBoxCpostalAddress.Text);
            RegisterCustommerCommand.Parameters.AddWithValue("@cCountry", comboBoxCcountry.Text);
            RegisterCustommerCommand.Parameters.AddWithValue("@cEmail", textBoxCemail.Text);

            RegisterCustomerConnection.Open();
            RegisterCustommerCommand.ExecuteNonQuery();
            RegisterCustomerConnection.Close();
            //string cNumber = textBoxCnumber.Text;
            //string cName = textBoxCname.Text;
            //string cAddress = textBoxCaddress.Text;


            //  controller.RegisterCustomer(cNumber, cName, cAddress);
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            SqlConnection DeleteCustomerConnection = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=CreateCookies;Persist Security Info=True;User ID=grupp15;Password=Grupp15");
            SqlCommand DeleteCustomerCommand = new SqlCommand("delete from Customer where cNumber ='" + comboBoxDCnumber.Text.Trim() + "'", DeleteCustomerConnection);

            if (comboBoxDCnumber.SelectedIndex != -1)
            {
                DeleteCustomerConnection.Open();
                DeleteCustomerCommand.ExecuteNonQuery();
                DeleteCustomerConnection.Close();
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            SqlConnection SelectCustomerConnection = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=CreateCookies;Persist Security Info=True;User ID=grupp15;Password=Grupp15");
            SqlCommand SelectCustommerCommand = new SqlCommand("select * from Customer where cNumber='" + comboBoxUCnumber.Text.Trim() + "'", SelectCustomerConnection);

            SelectCustomerConnection.Open();

            SqlDataReader DR = SelectCustommerCommand.ExecuteReader();

            if (DR.Read())
            {
                if (comboBoxUCnumber.SelectedIndex != -1)
                {
                    textBoxUCname.Text = DR["cName"].ToString();
                    textBoxUCaddress.Text = DR["cAddress"].ToString();
                    textBoxUCpostaladdress.Text = DR["cPostalAddress"].ToString();
                    comboBoxUCcountry.Text = DR["cCountry"].ToString();
                    textBoxUCemail.Text = DR["cEmail"].ToString();
                }
            }

            DR.Close();
            SelectCustomerConnection.Close();
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            textBoxCnumber.Clear();
            textBoxCname.Clear();
            textBoxCaddress.Clear();
            textBoxCpostalAddress.Clear();
            comboBoxCcountry.SelectedIndex = -1;
            textBoxCemail.Clear();
        }

        private void btnUppdateCustomer_Click(object sender, EventArgs e)
        {
            SqlConnection UpdateCustomerConnection = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=CreateCookies;Persist Security Info=True;User ID=grupp15;Password=Grupp15");

            UpdateCustomerConnection.Open();

            SqlCommand UpdateCustommerCommand = new SqlCommand("update Customer set cName=@cName, cAddress= @cAddress, cPostalAddress=@cPostalAddress, cCountry = @cCountry,  cEmail = @cEmail where cNumber=@cNumber", UpdateCustomerConnection);

            UpdateCustommerCommand.Parameters.AddWithValue("@cNumber", comboBoxUCnumber.Text);
            UpdateCustommerCommand.Parameters.AddWithValue("@cName", textBoxUCname.Text);
            UpdateCustommerCommand.Parameters.AddWithValue("@cAddress", textBoxUCaddress.Text);
            UpdateCustommerCommand.Parameters.AddWithValue("@cPostalAddress", textBoxUCpostaladdress.Text);
            UpdateCustommerCommand.Parameters.AddWithValue("@cCountry", comboBoxUCcountry.Text);
            UpdateCustommerCommand.Parameters.AddWithValue("@cEmail", textBoxUCemail.Text);

            UpdateCustommerCommand.ExecuteNonQuery();
            UpdateCustomerConnection.Close();
        }

        private void btnSeeOrders_Click(object sender, EventArgs e)
        {
            SqlConnection SeeCustomerOrderConnection = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=CreateCookies;Persist Security Info=True;User ID=grupp15;Password=Grupp15");

            SeeCustomerOrderConnection.Open();

            SqlDataAdapter SeeAllOrdersAdapter = new SqlDataAdapter("Select * from Orde where cNumber= '" + comboBoxOCnumber.Text.Trim() + "'", SeeCustomerOrderConnection);
            DataTable dt = new DataTable();
            SeeAllOrdersAdapter.Fill(dt);

            listViewCustomersOrders.Items.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];

                ListViewItem listViewItemSeeAllOrders = new ListViewItem(dr["oNumber"].ToString());
                listViewItemSeeAllOrders.SubItems.Add(dr["isDelivered"].ToString());
                listViewItemSeeAllOrders.SubItems.Add(dr["cNumber"].ToString());
                listViewCustomersOrders.Items.Add(listViewItemSeeAllOrders);

            }
            SeeCustomerOrderConnection.Close();

        }

        private void btnSeeAllOrders_Click(object sender, EventArgs e)
        {
            SqlConnection SeeCustomerOrdersConnection = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=CreateCookies;Persist Security Info=True;User ID=grupp15;Password=Grupp15");

            SeeCustomerOrdersConnection.Open();

            SqlDataAdapter SeeAllOrdersAdapter = new SqlDataAdapter("Select * from Orde", SeeCustomerOrdersConnection);
            DataTable dt = new DataTable();
            SeeAllOrdersAdapter.Fill(dt);

            listViewCustomersOrders.Items.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listViewItemSeeAllOrders = new ListViewItem(dr["oNumber"].ToString());
                listViewItemSeeAllOrders.SubItems.Add(dr["isDelivered"].ToString());
                listViewItemSeeAllOrders.SubItems.Add(dr["cNumber"].ToString());
                listViewCustomersOrders.Items.Add(listViewItemSeeAllOrders);
            }

        }

        private void textBoxSearchOrder_TextChanged(object sender, EventArgs e)
        {
            SqlConnection SearchOrderConnection = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=CreateCookies;Persist Security Info=True;User ID=grupp15;Password=Grupp15");

            if (comboBoxSearchOrder.Text == "Order_Number")
            {
                SqlDataAdapter dataadapterOrder = new SqlDataAdapter("Select oNumber, expectedDeliveryDate, isDelivered,cNumber from Orde where oNumber like '" + textBoxSearchOrder.Text + "%'", SearchOrderConnection);
                DataTable SearchOrderGrid = new DataTable();
                dataadapterOrder.Fill(SearchOrderGrid);
                dataGridViewOrderControl.DataSource = SearchOrderGrid;
            }
            else if (comboBoxSearchOrder.Text == "Expected_Delivery_Date")
            {
                SqlDataAdapter da = new SqlDataAdapter("Select oNumber, expectedDeliveryDate, isDelivered,cNumber from Orde where expectedDeliveryDate like '" + textBoxSearchOrder.Text + "%'", SearchOrderConnection);
                DataTable SearchOrderGrid = new DataTable();
                da.Fill(SearchOrderGrid);
                dataGridViewOrderControl.DataSource = SearchOrderGrid;
            }
            else if (comboBoxSearchOrder.Text == "Is_Delivered")
            {
                SqlDataAdapter da = new SqlDataAdapter("Select oNumber, expectedDeliveryDate, isDelivered,cNumber from Orde where isDelivered like '" + textBoxSearchOrder.Text + "%'", SearchOrderConnection);
                DataTable SearchOrderGrid = new DataTable();
                da.Fill(SearchOrderGrid);
                dataGridViewOrderControl.DataSource = SearchOrderGrid;
            }
            else if (comboBoxSearchOrder.Text == "Customer_Number")
            {
                SqlDataAdapter da = new SqlDataAdapter("Select oNumber, expectedDeliveryDate, isDelivered,cNumber from Orde where cNumber like '" + textBoxSearchOrder.Text + "%'", SearchOrderConnection);
                DataTable SearchOrderGrid = new DataTable();
                da.Fill(SearchOrderGrid);
                dataGridViewOrderControl.DataSource = SearchOrderGrid;
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            SqlConnection DeleteOrderConnection = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=CreateCookies;Persist Security Info=True;User ID=grupp15;Password=Grupp15");
            SqlCommand DeleteOrderCommand = new SqlCommand("delete from Orde where oNumber='" + comboBoxChooseOrder.Text.Trim() + "'", DeleteOrderConnection);

            if (comboBoxDCnumber.SelectedIndex != -1)
            {
                DeleteOrderConnection.Open();
                DeleteOrderCommand.ExecuteNonQuery();
                DeleteOrderConnection.Close();

            }
        }

        private void btnChoosenOrderInformation_Click(object sender, EventArgs e)
        {
            SqlConnection ChooseOrderInformationConnection = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=CreateCookies;Persist Security Info=True;User ID=grupp15;Password=Grupp15");

            ChooseOrderInformationConnection.Open();

            SqlDataAdapter ChooseOrderinformationAdapter = new SqlDataAdapter(@"Select Orderspecification.oNumber,Orderspecification.pNumber,Orderspecification.palletQuantity, Product.pName 
                from Orderspecification inner join Product on (Orderspecification.pNumber = Product.pNumber) where oNumber= '" + comboBox1.Text.Trim() + "'", ChooseOrderInformationConnection);
            DataTable dtChooseOrderinfo = new DataTable();
            ChooseOrderinformationAdapter.Fill(dtChooseOrderinfo);

            listViewOrderInformation.Items.Clear();

            for (int i = 0; i < dtChooseOrderinfo.Rows.Count; i++)
            {
                DataRow dr = dtChooseOrderinfo.Rows[i];

                ListViewItem listViewItemorderInfo = new ListViewItem(dr["oNumber"].ToString());
                listViewItemorderInfo.SubItems.Add(dr["pNumber"].ToString());
                listViewItemorderInfo.SubItems.Add(dr["pName"].ToString());
                listViewItemorderInfo.SubItems.Add(dr["palletQuantity"].ToString());
                listViewOrderInformation.Items.Add(listViewItemorderInfo);

            }
            ChooseOrderInformationConnection.Close();
        }

        private void comboBoxChooseCookies_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection ChooseCookieConnection = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=CreateCookies;Persist Security Info=True;User ID=grupp15;Password=Grupp15");

            ChooseCookieConnection.Open();

            SqlCommand chooseCookiecmd = new SqlCommand("select * from Product where pName='" + comboBoxChooseCookies.Text + "'", ChooseCookieConnection);
            SqlDataReader dr = chooseCookiecmd.ExecuteReader();

            if (dr.Read())
            {
                textBoxProductNUmberOA.Text = dr["pNumber"].ToString();
            }
            dr.Close();
            ChooseCookieConnection.Close();
        }

        private void btnAddOder_Click(object sender, EventArgs e)
        {
            SqlConnection AddOrderConnection = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=CreateCookies;Persist Security Info=True;User ID=grupp15;Password=Grupp15");
            SqlCommand AddOrderCommand1 = new SqlCommand("insert into Orde (oNumber, isDelivered,expectedDeliveryDate, cNumber) values(@oNumber, @isDelivered,@expectedDeliveryDate, @cNumber)", AddOrderConnection);
           // SqlCommand AddOrderCommand2 = new SqlCommand("insert into Orderspecification (palletQuantity) values(@pNumber, @oNumber, @palletQuantity)", AddOrderConnection);

            AddOrderCommand1.Parameters.AddWithValue("@oNumber", textBoxGenerateOrderNumber.Text);
            AddOrderCommand1.Parameters.AddWithValue("@isDelivered", textBoxisDeliveredAO.Text);
            AddOrderCommand1.Parameters.AddWithValue("@expectedDeliveryDate", dateTimePickerDeliveryDateAO.Text);
            AddOrderCommand1.Parameters.AddWithValue("@cNumber", comboBoxAOCnumber.Text);

            //AddOrderCommand2.Parameters.AddWithValue("@palletQuantity", comboBoxPalletQuantity.Text);
          

            AddOrderConnection.Open();
            AddOrderCommand1.ExecuteNonQuery();
            //AddOrderCommand2.ExecuteNonQuery();
            AddOrderConnection.Close();
        }
    }
}  
    



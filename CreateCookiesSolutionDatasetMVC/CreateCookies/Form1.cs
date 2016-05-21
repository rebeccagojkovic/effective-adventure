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
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'createCookiesDataSetTheOne1.Orderspecification' table. You can move, or remove it, as needed.
            this.orderspecificationTableAdapter.Fill(this.createCookiesDataSetTheOne1.Orderspecification);


            // TODO: This line of code loads data into the 'createCookiesDataSetTheOne.Produced' table. You can move, or remove it, as needed.
            this.producedTableAdapter.Fill(this.createCookiesDataSetTheOne.Produced);
            // TODO: This line of code loads data into the 'createCookiesDataSetTheOne.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.createCookiesDataSetTheOne.Supplier);
            // TODO: This line of code loads data into the 'createCookiesDataSetTheOne.Ingredient' table. You can move, or remove it, as needed.
            this.ingredientTableAdapter.Fill(this.createCookiesDataSetTheOne.Ingredient);
            // TODO: This line of code loads data into the 'createCookiesDataSetTheOne.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.createCookiesDataSetTheOne.Product);
            // TODO: This line of code loads data into the 'createCookiesDataSetTheOne.Orde' table. You can move, or remove it, as needed.
            this.ordeTableAdapter.Fill(this.createCookiesDataSetTheOne.Orde);
            // TODO: This line of code loads data into the 'createCookiesDataSetTheOne.Customer' table. You can move, or remove it, as needed.
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
                        TextBoxUCaddress.Text= searchCustomerValues[1];
                        TextBoxUCpostaladdress.Text= searchCustomerValues[2];
                        ComboBoxUCcountry.Text= searchCustomerValues[3];
                        TextBoxUCemail.Text= searchCustomerValues[4];
                    }
                }
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
                //controller.SeeOrder(ComboBoxOCnumber.Text.Trim());
                dataGridViewCustomersOrders.DataSource = controller.SeeOrder(ComboBoxOCnumber.Text.Trim());

            }
            catch (Exception Ex)
            {

                string errorMessage = controller.Exception(Ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }

            //SqlConnection SeeCustomerOrderConnection = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=CreateCookies;Persist Security Info=True;User ID=grupp15;Password=Grupp15");

            //SeeCustomerOrderConnection.Open();

            //SqlDataAdapter SeeAllOrdersAdapter = new SqlDataAdapter("Select * from Orde where cNumber= '" + ComboBoxOCnumber.Text.Trim() + "'", SeeCustomerOrderConnection);
            //DataTable dt = new DataTable();
            //SeeAllOrdersAdapter.Fill(dt);

            //listViewCustomersOrders.Items.Clear();

            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    DataRow dr = dt.Rows[i];

            //    ListViewItem listViewItemSeeAllOrders = new ListViewItem(dr["oNumber"].ToString());
            //    listViewItemSeeAllOrders.SubItems.Add(dr["isDelivered"].ToString());
            //    listViewItemSeeAllOrders.SubItems.Add(dr["cNumber"].ToString());
            //    listViewCustomersOrders.Items.Add(listViewItemSeeAllOrders);

            //}
            //SeeCustomerOrderConnection.Close();
        }
        private void BtnSeeAllOrders_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewCustomersOrders.DataSource = controller.SeeAllOrders();
            }
            catch (Exception Ex)
            {

                string errorMessage = controller.Exception(Ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //SqlConnection SeeCustomerOrdersConnection = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=CreateCookies;Persist Security Info=True;User ID=grupp15;Password=Grupp15");

            //SeeCustomerOrdersConnection.Open();

            //SqlDataAdapter SeeAllOrdersAdapter = new SqlDataAdapter("Select * from Orde", SeeCustomerOrdersConnection);
            //DataTable dt = new DataTable();
            //SeeAllOrdersAdapter.Fill(dt);

            //listViewCustomersOrders.Items.Clear();

            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    DataRow dr = dt.Rows[i];
            //    ListViewItem listViewItemSeeAllOrders = new ListViewItem(dr["oNumber"].ToString());
            //    listViewItemSeeAllOrders.SubItems.Add(dr["isDelivered"].ToString());
            //    listViewItemSeeAllOrders.SubItems.Add(dr["cNumber"].ToString());
            //    listViewCustomersOrders.Items.Add(listViewItemSeeAllOrders);
            //}

        }

        private void textBoxSearchOrder_TextChanged(object sender, EventArgs e)
        {
            String searchOrder = TextBoxSearchOrder.Text;

            //SqlConnection SearchOrderConnection = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=CreateCookies;Persist Security Info=True;User ID=grupp15;Password=Grupp15");

            if (ComboBoxSearchOrder.Text == "Order_Number")
            {
                //SqlDataAdapter dataadapterOrder = new SqlDataAdapter("Select oNumber, expectedDeliveryDate, isDelivered,cNumber from Orde where oNumber like '" + TextBoxSearchOrder.Text + "%'", SearchOrderConnection);
                //DataTable SearchOrderGrid = new DataTable();
                //dataadapterOrder.Fill(SearchOrderGrid);
                dataGridViewOrderControl.DataSource = controller.SearchOrderNumber(TextBoxSearchOrder.Text);
            }
            else if (ComboBoxSearchOrder.Text == "Expected_Delivery_Date")
            {
                //SqlDataAdapter da = new SqlDataAdapter("Select oNumber, expectedDeliveryDate, isDelivered,cNumber from Orde where expectedDeliveryDate like '" + TextBoxSearchOrder.Text + "%'", SearchOrderConnection);
                //DataTable SearchOrderGrid = new DataTable();
                //da.Fill(SearchOrderGrid);
                dataGridViewOrderControl.DataSource = controller.SearchExpectedDeliveryDate(TextBoxSearchOrder.Text);
            }
            else if (ComboBoxSearchOrder.Text == "Is_Delivered")
            {
                //SqlDataAdapter da = new SqlDataAdapter("Select oNumber, expectedDeliveryDate, isDelivered,cNumber from Orde where isDelivered like '" + TextBoxSearchOrder.Text + "%'", SearchOrderConnection);
                //DataTable SearchOrderGrid = new DataTable();
                //da.Fill(SearchOrderGrid);
                dataGridViewOrderControl.DataSource = controller.SearchIsDelivered(TextBoxSearchOrder.Text);
            }
            else if (ComboBoxSearchOrder.Text == "Customer_Number")
            {
                //SqlDataAdapter da = new SqlDataAdapter("Select oNumber, expectedDeliveryDate, isDelivered,cNumber from Orde where cNumber like '" + TextBoxSearchOrder.Text + "%'", SearchOrderConnection);
                //DataTable SearchOrderGrid = new DataTable();
                //da.Fill(SearchOrderGrid);
                dataGridViewOrderControl.DataSource = controller.SearchCustomerNumber(TextBoxSearchOrder.Text);
            }
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
            }
            catch (Exception Ex)
            {
                string errorMessage = controller.Exception(Ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnChoosenOrderInformation_Click(object sender, EventArgs e)
        {
            SqlConnection ChooseOrderInformationConnection = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=CreateCookies;Persist Security Info=True;User ID=grupp15;Password=Grupp15");

            ChooseOrderInformationConnection.Open();

            SqlDataAdapter ChooseOrderinformationAdapter = new SqlDataAdapter(@"Select Orderspecification.oNumber,Orderspecification.pNumber,Orderspecification.palletQuantity, Product.pName 
                from Orderspecification inner join Product on (Orderspecification.pNumber = Product.pNumber) where oNumber= '" + ComboBox1.Text.Trim() + "'", ChooseOrderInformationConnection);
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

        private void ComboBoxChooseCookies_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection ChooseCookieConnection = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=CreateCookies;Persist Security Info=True;User ID=grupp15;Password=Grupp15");

            ChooseCookieConnection.Open();

            SqlCommand chooseCookiecmd = new SqlCommand("select * from Product where pName='" + ComboBoxChooseCookies.Text + "'", ChooseCookieConnection);
            SqlDataReader dr = chooseCookiecmd.ExecuteReader();

            if (dr.Read())
            {
                TextBoxProductNUmberOA.Text = dr["pNumber"].ToString();
            }
            dr.Close();
            ChooseCookieConnection.Close();
        }

        private void BtnAddOder_Click(object sender, EventArgs e)
        {
            
            String[] Order = new String[4];
            String[] Orderspecification = new String[3];

            try
            {

                Order[0] = TextBoxGenerateOrderNumber.Text;
                Order[1] = TextBoxisDeliveredAO.Text;
                Order[2] = (DateTimePickerDeliveryDateAO.ToString());
                Order[3] = ComboBoxAOCnumber.Text;

                Orderspecification[0] = TextBoxGenerateOrderNumber.Text;
                Orderspecification[1] = TextBoxProductNUmberOA.Text;
                Orderspecification[2] = ComboBoxPalletQuantity.Text;

                controller.RegisterOrder(Order, Orderspecification);

            }
            catch (Exception Ex)
            {
                string errorMessage = controller.Exception(Ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnProduce_Click(object sender, EventArgs e)
        {
            SqlConnection produceConnection = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=CreateCookies;Persist Security Info=True;User ID=grupp15;Password=Grupp15");
            SqlCommand producedCommand = new SqlCommand("insert into Produced( pTime,pName, pPallet, pNumber, oNumber) values(@pTime, @pName, @pPallet, @pNumber, @oNumber)", produceConnection);

            producedCommand.Parameters.AddWithValue("@pTime", DateTimePickerPProductTime.Value.Date);
            producedCommand.Parameters.AddWithValue("@pName", TextBoxProductToProduce.Text);
            producedCommand.Parameters.AddWithValue("@pPallet", TextBoxpalletamountProduction.Text);
            producedCommand.Parameters.AddWithValue("@pNumber", TextBoxpNumberProduction.Text);
            producedCommand.Parameters.AddWithValue("@oNumber", ComboBoxOrderNumberProduction.Text);

            if (TextBoxProductToProduce.Text == "Nötingar" && TextBoxProductToProduce.Text != "")
            {
                for (int j = 0; j <= Int32.Parse(TextBoxpalletamountProduction.Text); j++)
                {
                    SqlDataAdapter da = new SqlDataAdapter(@"UPDATE Ingredient SET iQuantityInStock = CASE iName
                              WHEN 'Smör' THEN (iQuantityInStock -450)
                              WHEN 'Mjöl' THEN (iQuantityInStock -450)
                              WHEN 'Socker' THEN (iQuantityInStock -190) 
                              WHEN 'Nötter' THEN (iQuantityInStock -225)
                              ELSE iQuantityInStock
                              END
                              WHERE iName IN('Smör', 'Mjöl','Socker','Nötter')", produceConnection);

                    DataTable ProduceStorageGrid = new DataTable();
                    da.Fill(ProduceStorageGrid);
                    dataGridViewStorage.DataSource = ProduceStorageGrid;
                    j++;
                }

            }
            else if (TextBoxProductToProduce.Text == "Nötkakor" && TextBoxProductToProduce.Text != "")
            {
                for (int j = 0; j <= Int32.Parse(TextBoxpalletamountProduction.Text); j++)
                {
                    SqlDataAdapter da = new SqlDataAdapter(@"UPDATE Ingredient SET iQuantityInStock = CASE iName
                      WHEN 'Ägg' THEN (iQuantityInStock -4)
                      WHEN 'Mjöl' THEN (iQuantityInStock -50)
                      WHEN 'Socker' THEN (iQuantityInStock -375) 
                      WHEN 'Nötter' THEN (iQuantityInStock -1375)
                      ELSE iQuantityInStock
                      END
                      WHERE iName IN('Ägg', 'Mjöl','Socker','Nötter')", produceConnection);

                    DataTable ProduceStorageGrid = new DataTable();
                    da.Fill(ProduceStorageGrid);
                    dataGridViewStorage.DataSource = ProduceStorageGrid;
                    j++;
                }
            }
            else if (TextBoxProductToProduce.Text == "Berliner" && TextBoxProductToProduce.Text != "")
            {
                for (int j = 0; j <= Int32.Parse(TextBoxpalletamountProduction.Text); j++)
                {
                    SqlDataAdapter da = new SqlDataAdapter(@"UPDATE Ingredient SET iQuantityInStock = CASE iName
                      WHEN 'Smör' THEN (iQuantityInStock -450)
                      WHEN 'Mjöl' THEN (iQuantityInStock -450)
                      WHEN 'Socker' THEN (iQuantityInStock -190) 
                      WHEN 'Mjölk' THEN (iQuantityInStock -150)
                      ELSE iQuantityInStock
                      END
                      WHERE iName IN('Smör', 'Mjöl','Socker','Nötter')", produceConnection);

                    DataTable ProduceStorageGrid = new DataTable();
                    da.Fill(ProduceStorageGrid);
                    dataGridViewStorage.DataSource = ProduceStorageGrid;
                    j++;
                }
            }
            else if (TextBoxProductToProduce.Text == "Kokostoppar" && TextBoxProductToProduce.Text != "")
            {
                for (int j = 0; j <= Int32.Parse(TextBoxpalletamountProduction.Text); j++)
                {
                    SqlDataAdapter da = new SqlDataAdapter(@"UPDATE Ingredient SET iQuantityInStock = CASE iName
                      WHEN 'Marsipan' THEN (iQuantityInStock -600)
                      WHEN 'vaniljsocker' THEN (iQuantityInStock -60)
                      WHEN 'Choklad' THEN (iQuantityInStock -400) 
                      WHEN 'Nötter' THEN (iQuantityInStock -600)
                      ELSE iQuantityInStock
                      END
                      WHERE iName IN('Marsipan', 'vaniljsocker','Choklad','Nötter')", produceConnection);

                    DataTable ProduceStorageGrid = new DataTable();
                    da.Fill(ProduceStorageGrid);
                    dataGridViewStorage.DataSource = ProduceStorageGrid;
                    j++;
                }

            }
            else if (TextBoxProductToProduce.Text == "Amneris" && TextBoxProductToProduce.Text != "")
            {
                for (int j = 0; j <= Int32.Parse(TextBoxpalletamountProduction.Text); j++)
                {

                    SqlDataAdapter da = new SqlDataAdapter(@"UPDATE Ingredient SET iQuantityInStock = CASE iName
                          WHEN 'Mjölk' THEN (iQuantityInStock -110)
                          WHEN 'Mjöl' THEN (iQuantityInStock -400)
                          WHEN 'Socker' THEN (iQuantityInStock -100) 
                          WHEN 'Mandel' THEN (iQuantityInStock -300)
                          ELSE iQuantityInStock
                          END
                          WHERE iName IN('Mjölk', 'Mjöl','Socker','Mandel')", produceConnection);

                    DataTable ProduceStorageGrid = new DataTable();
                    da.Fill(ProduceStorageGrid);
                    dataGridViewStorage.DataSource = ProduceStorageGrid;
                    j++;

                }
            }
            else if (TextBoxProductToProduce.Text == "Tango" && TextBoxProductToProduce.Text != "")
            {
                for (int j = 0; j <= Int32.Parse(TextBoxpalletamountProduction.Text); j++)
                {
                    SqlDataAdapter da = new SqlDataAdapter(@"UPDATE Ingredient SET iQuantityInStock = CASE iName
                      WHEN 'Marsipan' THEN (iQuantityInStock -550)
                      WHEN 'Choklad' THEN (iQuantityInStock -300)
                      WHEN 'vaniljsocker' THEN (iQuantityInStock -30) 
                      WHEN 'Ägg' THEN (iQuantityInStock -10)
                      ELSE iQuantityInStock
                      END
                      WHERE iName IN('Marsipan', 'Choklad','vaniljsocker','Ägg')", produceConnection);

                    DataTable ProduceStorageGrid = new DataTable();
                    da.Fill(ProduceStorageGrid);
                    dataGridViewStorage.DataSource = ProduceStorageGrid;
                    j++;
                }
            }
            

            SqlCommand DeleteingFromOrdersProduction = new SqlCommand("delete from Orderspecification  where oNumber= '" + ComboBoxOrderNumberProduction.Text.Trim() + "'", produceConnection);
            SqlCommand DeleteingFromOrdersProduction2 = new SqlCommand("delete from Orde  where oNumber= '" + ComboBoxOrderNumberProduction.Text.Trim() + "'", produceConnection);


            listViewOrderInformation.Items.RemoveByKey(ComboBoxOrderNumberProduction.Text);

            produceConnection.Open();
            producedCommand.ExecuteNonQuery();
            DeleteingFromOrdersProduction.ExecuteNonQuery();
            DeleteingFromOrdersProduction2.ExecuteNonQuery();
            produceConnection.Close();
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
            }
            catch (Exception Ex)
            {
                string errorMessage = controller.Exception(Ex);
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnAddSupplier_Click(object sender, EventArgs e)
        {
            SqlConnection addSupplierConnection = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=CreateCookies;Persist Security Info=True;User ID=grupp15;Password=Grupp15");
            SqlCommand addSupplierCommand1 = new SqlCommand("insert into Supplier (sNumber, sName, sLocation) values(@sNumber, @sName, @sLocation)", addSupplierConnection);
            SqlCommand addSupplierCommand2 = new SqlCommand("insert into Ingredient (iNumber, iName, iQuantityInStock,sNumber) values(@iNumber, @iName, @iQuantityInStock, @sNumber)", addSupplierConnection);

            addSupplierCommand1.Parameters.AddWithValue("@sNumber", TextBoxASNumber.Text);
            addSupplierCommand1.Parameters.AddWithValue("@sName", TextBoxSupplierName.Text);
            addSupplierCommand1.Parameters.AddWithValue("@sLocation", ComboBoxSlocation.Text);

            addSupplierCommand2.Parameters.AddWithValue("@iNumber", TextBoxASIngredientNumber.Text);
            addSupplierCommand2.Parameters.AddWithValue("@iName", TextBoxASIngredientName.Text);
            addSupplierCommand2.Parameters.AddWithValue("@iQuantityInStock", TextBoxASQuantityInStock.Text);
            addSupplierCommand2.Parameters.AddWithValue("@sNumber", TextBoxASNumber.Text);

            addSupplierConnection.Open();
            addSupplierCommand1.ExecuteNonQuery();
            addSupplierCommand2.ExecuteNonQuery();
            addSupplierConnection.Close();
        }

        private void BtnSeeOrders_Click_1(object sender, EventArgs e)
        {
            //SqlConnection SeeCustomerOrderConnection = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=CreateCookies;Persist Security Info=True;User ID=grupp15;Password=Grupp15");

            //SeeCustomerOrderConnection.Open();

            //SqlDataAdapter SeeAllOrdersAdapter = new SqlDataAdapter("Select * from Orde where cNumber= '" + ComboBoxOCnumber.Text.Trim() + "'", SeeCustomerOrderConnection);
            //DataTable dt = new DataTable();
            //SeeAllOrdersAdapter.Fill(dt);

            //listViewCustomersOrders.Items.Clear();

            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    DataRow dr = dt.Rows[i];

            //    ListViewItem listViewItemSeeAllOrders = new ListViewItem(dr["oNumber"].ToString());
            //    listViewItemSeeAllOrders.SubItems.Add(dr["isDelivered"].ToString());
            //    listViewItemSeeAllOrders.SubItems.Add(dr["cNumber"].ToString());
            //    listViewCustomersOrders.Items.Add(listViewItemSeeAllOrders);

            //}
            //SeeCustomerOrderConnection.Close();
        }

        private void BtnStore_Click(object sender, EventArgs e)
        {
            SqlConnection storeConnection = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=CreateCookies;Persist Security Info=True;User ID=grupp15;Password=Grupp15");

            SqlCommand insertIntoPalletCommand = new SqlCommand("insert into Pallet (palletNumber, palletTime, pNumber,oNumber) values(@palletNumber, @palletTime, @pNumber, @oNumber)", storeConnection);

            storeConnection.Open();

            insertIntoPalletCommand.Parameters.AddWithValue("@palletNumber", TextBoxPalletID.Text);
            insertIntoPalletCommand.Parameters.AddWithValue("@palletTime",TextBoxStorageProduced.Text);
            insertIntoPalletCommand.Parameters.AddWithValue("@pNumber", TextBoxStoragePNumber.Text);
            insertIntoPalletCommand.Parameters.AddWithValue("@oNumber", TextBoxStorageONumber.Text);


            SqlDataAdapter storeAdapter = new SqlDataAdapter(@"Select Pallet.palletNumber,Pallet.oNumber,Produced.pName,Produced.pTime,Produced.pNumber,Produced.pPallet from Pallet inner join 
                Produced on (Pallet.pNumber=Produced.pNumber) where pName= '" + ComboBoxCooseFromProducedProducts.Text.Trim() + "'", storeConnection);
            DataTable dtstore = new DataTable();
            storeAdapter.Fill(dtstore);

            for (int i = 0; i < dtstore.Rows.Count; i++)
            {
                DataRow dr = dtstore.Rows[i];

                ListViewItem listViewstore = new ListViewItem(dr["palletNumber"].ToString());
                listViewstore.SubItems.Add(dr["palletTime"].ToString());
                listViewstore.SubItems.Add(dr["pNumber"].ToString());
                listViewstore.SubItems.Add(dr["oNumber"].ToString());
                listViewstore.SubItems.Add(dr["pPallet"].ToString());
                listViewStorage.Items.Add(listViewstore);
            }

            SqlCommand deleteInProducedCommand = new SqlCommand("Delete from Produced where oNumber='"+ TextBoxStorageONumber.Text + "'", storeConnection);

            insertIntoPalletCommand.ExecuteNonQuery();
            deleteInProducedCommand.ExecuteNonQuery();
            storeConnection.Close();
        }

        private void ComboBoxCooseFromProducedProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection selectStoreInfoConnection = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=CreateCookies;Persist Security Info=True;User ID=grupp15;Password=Grupp15");

            selectStoreInfoConnection.Open();

            SqlCommand selectStoragecmd = new SqlCommand("select* from Produced where pName='" + ComboBoxCooseFromProducedProducts.Text + "'", selectStoreInfoConnection);
            SqlDataReader dr = selectStoragecmd.ExecuteReader();

            if (dr.Read())
            {
                TextBoxStoragePNumber.Text = dr["pNumber"].ToString();
                TextBoxStorageONumber.Text = dr["oNumber"].ToString();
                TextBoxStorageProduced.Text= dr["pTime"].ToString();
                TextBoxStorageProduced.Text = dr["pPallet"].ToString();
            }
            dr.Close();
            selectStoreInfoConnection.Close();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {

        }
    }
} 

    
  
    



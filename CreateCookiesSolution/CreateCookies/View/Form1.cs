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
            // TODO: This line of code loads data into the 'createCookiesDataSetTheOne.Orderspecification' table. You can move, or remove it, as needed.
            this.orderspecificationTableAdapter.Fill(this.createCookiesDataSetTheOne.Orderspecification);
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
            SqlCommand AddOrderCommand2 = new SqlCommand("insert into Orderspecification (oNumber, pNumber, palletQuantity) values(@oNumber, @pNumber, @palletQuantity)", AddOrderConnection);

            AddOrderCommand1.Parameters.AddWithValue("@oNumber", textBoxGenerateOrderNumber.Text);
            AddOrderCommand1.Parameters.AddWithValue("@isDelivered", textBoxisDeliveredAO.Text);
            AddOrderCommand1.Parameters.AddWithValue("@expectedDeliveryDate", dateTimePickerDeliveryDateAO.Value.Date);
            AddOrderCommand1.Parameters.AddWithValue("@cNumber", comboBoxAOCnumber.Text);

            AddOrderCommand2.Parameters.AddWithValue("@oNumber", textBoxGenerateOrderNumber.Text);
            AddOrderCommand2.Parameters.AddWithValue("@pNumber", textBoxProductNUmberOA.Text);
            AddOrderCommand2.Parameters.AddWithValue("@palletQuantity", comboBoxPalletQuantity.Text);

            AddOrderConnection.Open();
            AddOrderCommand1.ExecuteNonQuery();
            AddOrderCommand2.ExecuteNonQuery();
            AddOrderConnection.Close();
        }

        private void btnProduce_Click(object sender, EventArgs e)
        {
            SqlConnection produceConnection = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=CreateCookies;Persist Security Info=True;User ID=grupp15;Password=Grupp15");
            SqlCommand producedCommand = new SqlCommand("insert into Produced ( pTime,pName, pPallet, pNumber) values(@pTime, @pName, @pPallet, @pNumber)", produceConnection);

            producedCommand.Parameters.AddWithValue("@pTime", dateTimePickerPProductTime.Value.Date);
            producedCommand.Parameters.AddWithValue("@pName", textBoxProductToProduce.Text );
            producedCommand.Parameters.AddWithValue("@pPallet", textBoxpalletamountProduction.Text);
            producedCommand.Parameters.AddWithValue("@pNumber", textBoxpNumberProduction.Text);
         
            if (textBoxProductToProduce.Text == "Nötingar" && textBoxProductToProduce.Text!="" )
            {
                for (int j=0; j<= Int32.Parse(textBoxpalletamountProduction.Text); j++) { 
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
            else if (textBoxProductToProduce.Text == "Nötkakor" && textBoxProductToProduce.Text != "")
            {
                for (int j = 0; j <= Int32.Parse(textBoxpalletamountProduction.Text); j++)
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
            else if (textBoxProductToProduce.Text == "Berliner" && textBoxProductToProduce.Text != "")
            {
                for (int j = 0; j <= Int32.Parse(textBoxpalletamountProduction.Text); j++)
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
            else if (textBoxProductToProduce.Text == "Kokostoppar" && textBoxProductToProduce.Text != "" )
            {
                for (int j = 0; j <= Int32.Parse(textBoxpalletamountProduction.Text); j++)
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

            } else if (textBoxProductToProduce.Text == "Amneris" && textBoxProductToProduce.Text != "" )
            {
                for (int j = 0; j <= Int32.Parse(textBoxpalletamountProduction.Text); j++)
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
            } else if (textBoxProductToProduce.Text == "Tango" && textBoxProductToProduce.Text != "")
            {
                for (int j = 0; j <= Int32.Parse(textBoxpalletamountProduction.Text); j++)
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

            SqlCommand DeleteingFromOrdersProduction = new SqlCommand("delete from Orderspecification  where oNumber= '" + comboBoxOrderNumberProduction.Text.Trim() + "'",produceConnection);
            SqlCommand DeleteingFromOrdersProduction2 = new SqlCommand("delete from Orde  where oNumber= '" + comboBoxOrderNumberProduction.Text.Trim() + "'", produceConnection);
           
            comboBox1.Refresh();
            dataGridViewOrderControl.Refresh();
            listViewOrderInformation.Items.RemoveByKey(comboBoxOrderNumberProduction.Text.Trim());
            
            produceConnection.Open();
            producedCommand.ExecuteNonQuery();
            DeleteingFromOrdersProduction.ExecuteNonQuery();
            DeleteingFromOrdersProduction2.ExecuteNonQuery();
            produceConnection.Close();
        }

        private void comboBoxOrderNumberProduction_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection producttoProduceeConnection = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=CreateCookies;Persist Security Info=True;User ID=grupp15;Password=Grupp15");

            producttoProduceeConnection.Open();

            SqlCommand producttoProduceecmd = new SqlCommand("select * from Orderspecification inner join Product on (Orderspecification.pNumber=Product.pNumber) where oNumber='" + comboBoxOrderNumberProduction.Text + "'", producttoProduceeConnection);
            SqlDataReader dr = producttoProduceecmd.ExecuteReader();

            if (dr.Read())
            {
                textBoxpNumberProduction.Text = dr["pNumber"].ToString();
                textBoxpalletamountProduction.Text = dr["palletQuantity"].ToString();
                textBoxProductToProduce.Text = dr["pName"].ToString();
            }
            dr.Close();
            producttoProduceeConnection.Close();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            SqlConnection AddSupplierConnection = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=CreateCookies;Persist Security Info=True;User ID=grupp15;Password=Grupp15");
            SqlCommand AddSupplierCommand1 = new SqlCommand("insert into Supplier (sNumber, sName, sLocation) values(@sNumber, @sName, @sLocation)", AddSupplierConnection);
            SqlCommand AddSupplierCommand2 = new SqlCommand("insert into Ingredient (iNumber, iName, iQuantityInStock,sNumber) values(@iNumber, @iName, @iQuantityInStock, @sNumber)", AddSupplierConnection);

            AddSupplierCommand1.Parameters.AddWithValue("@sNumber", textBoxASNumber.Text);
            AddSupplierCommand1.Parameters.AddWithValue("@sName", textBoxSupplierName.Text);
            AddSupplierCommand1.Parameters.AddWithValue("@sLocation", comboBoxSlocation.Text);
           
            AddSupplierCommand2.Parameters.AddWithValue("@iNumber", textBoxASIngredientNumber.Text);
            AddSupplierCommand2.Parameters.AddWithValue("@iName", textBoxASIngredientName.Text);
            AddSupplierCommand2.Parameters.AddWithValue("@iQuantityInStock", textBoxASQuantityInStock.Text);
            AddSupplierCommand2.Parameters.AddWithValue("@sNumber", textBoxASNumber.Text);

            AddSupplierConnection.Open();
            AddSupplierCommand1.ExecuteNonQuery();
            AddSupplierCommand2.ExecuteNonQuery();
            AddSupplierConnection.Close();
        }
    }
} 

    
  
    



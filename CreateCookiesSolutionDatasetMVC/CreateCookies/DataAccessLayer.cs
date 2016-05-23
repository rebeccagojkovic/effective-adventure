using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateCookies.View;
using System.Data.Common;
using System.Windows.Forms;

namespace CreateCookies.View
{
    class DataAccessLayer
    {
        SqlConnection connection = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=CreateCookies;Persist Security Info=True;User ID=grupp15;Password=Grupp15");

        public void RegisterCustomer(string[] customer)
        {
            SqlCommand command = new SqlCommand(@"INSERT INTO Customer (cNumber, cName, cAddress, cPostalAddress, cCountry, cEmail) 
                               VALUES (@cNumber, @cName, @cAddress, @cPostalAddress, @cCountry, @cEmail)", connection);

            command.Parameters.AddWithValue("@cNumber", customer[0]);
            command.Parameters.AddWithValue("@cName", customer[1]);
            command.Parameters.AddWithValue("@cAddress", customer[2]);
            command.Parameters.AddWithValue("@cPostalAddress", customer[3]);
            command.Parameters.AddWithValue("@cCountry", customer[4]);
            command.Parameters.AddWithValue("@cEmail", customer[5]);

            connection.Open();

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
            finally
            {
                connection.Close();
            }

        }

        public void DeleteCustomer(string cNumber)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Customer WHERE cNumber='" + cNumber + "'", connection);
            {
                command.Parameters.AddWithValue("@cNumber", cNumber);

                connection.Open();

                try
                {
                    command.ExecuteNonQuery();
                }

                catch (Exception Ex)
                {
                    throw Ex;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void UpdateCustomer(string[] customer)
        {
            SqlCommand command = new SqlCommand("UPDATE Customer SET cName=@cName, cAddress= @cAddress, cPostalAddress=@cPostalAddress, cCountry = @cCountry,  cEmail = @cEmail WHERE cNumber=@cNumber", connection);
            {
                command.Parameters.AddWithValue("@cNumber", customer[0]);
                command.Parameters.AddWithValue("@cName", customer[1]);
                command.Parameters.AddWithValue("@cAddress", customer[2]);
                command.Parameters.AddWithValue("@cPostalAddress", customer[3]);
                command.Parameters.AddWithValue("@cCountry", customer[4]);
                command.Parameters.AddWithValue("@cEmail", customer[5]);

                connection.Open();

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    throw Ex;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public string[] SearchCustomer(string cNumber)
        {
            connection.Open();

            try
            {
                string[] searchCustomerValues = new string[5];

                SqlCommand command = new SqlCommand("SELECT * FROM Customer WHERE cNumber ='" + cNumber + "'", connection);

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    searchCustomerValues[0] = dr["cName"].ToString();
                    searchCustomerValues[1] = dr["cAddress"].ToString();
                    searchCustomerValues[2] = dr["cPostalAddress"].ToString();
                    searchCustomerValues[3] = dr["cCountry"].ToString();
                    searchCustomerValues[4] = dr["cEmail"].ToString();
                }
                return searchCustomerValues;
            }

            catch (Exception Ex)
            {
                throw Ex;
            }

            finally
            {
                connection.Close();
            }
        }
        public DataTable SeeOrder(string cNumber)
        {
            connection.Open();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Orde WHERE cNumber= '" + cNumber + "'", connection);
                DataTable SearchOrderGrid = new DataTable();
                da.Fill(SearchOrderGrid);
                return SearchOrderGrid;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }

            finally
            {
                connection.Close();
            }
        }

        public DataTable SeeAllOrders()
        {
            connection.Open();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Orde", connection);
                DataTable SearchOrderGrid = new DataTable();
                da.Fill(SearchOrderGrid);
                return SearchOrderGrid;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }

            finally
            {
                connection.Close();
            }
        }

        //Order
        public DataTable SearchOrderNumber(string oNumber)
        {
            connection.Open();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT oNumber, expectedDeliveryDate, isDelivered,cNumber FROM Orde WHERE oNumber LIKE '" + oNumber + "%'", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                connection.Close();
            }
        }
        public DataTable SearchExpectedDeliveryDate(string expectedDeliveryDate)
        {
            connection.Open();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT oNumber, expectedDeliveryDate, isDelivered,cNumber FROM Orde WHERE expectedDeliveryDate LIKE '" + expectedDeliveryDate + "%'", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                connection.Close();
            }
        }
        public DataTable SearchIsDelivered(string isDelivered)
        {
            connection.Open();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT oNumber, expectedDeliveryDate, isDelivered,cNumber FROM Orde WHERE isDelivered LIKE '" + isDelivered + "%'", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                connection.Close();
            }
        }
        public DataTable SearchCustomerNumber(string cNumber)
        {
            connection.Open();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT oNumber, expectedDeliveryDate, isDelivered,cNumber FROM Orde WHERE cNumber LIKE '" + cNumber + "%'", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                connection.Close();
            }
        }
        public DataTable ChooseOrderinformation(string oNumber)
        {
            connection.Open();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Orderspecification.oNumber,Orderspecification.pNumber,Orderspecification.palletQuantity, Product.pName FROM Orderspecification INNER JOIN Product ON (Orderspecification.pNumber = Product.pNumber) WHERE oNumber = '" + oNumber + "'", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public void RegisterOrder(string[] Order, string[] Orderspecification)
        {

            SqlCommand AddOrderCommand1 = new SqlCommand("INSERT INTO Orde (oNumber, isDelivered,expectedDeliveryDate, cNumber) VALUES (@oNumber, @isDelivered,@expectedDeliveryDate, @cNumber)", connection);
            SqlCommand AddOrderCommand2 = new SqlCommand("INSERT INTO Orderspecification (oNumber, pNumber, palletQuantity) VALUES (@oNumber, @pNumber, @palletQuantity)", connection);

            DateTime dt = Convert.ToDateTime(Order[2]);
            IFormatProvider culture = new System.Globalization.CultureInfo("sv-SE", true);
            DateTime dt2 = DateTime.Parse(Order[2], culture, System.Globalization.DateTimeStyles.AssumeLocal);


            AddOrderCommand1.Parameters.AddWithValue("@oNumber", Order[0]);
            AddOrderCommand1.Parameters.AddWithValue("@isDelivered", Order[1]);
            AddOrderCommand1.Parameters.AddWithValue("@expectedDeliveryDate", dt2);
            AddOrderCommand1.Parameters.AddWithValue("@cNumber", Order[3]);

            AddOrderCommand2.Parameters.AddWithValue("@oNumber", Orderspecification[0]);
            AddOrderCommand2.Parameters.AddWithValue("@pNumber", Orderspecification[1]);
            AddOrderCommand2.Parameters.AddWithValue("@palletQuantity", Orderspecification[2]);

            connection.Open();

            try
            {
                AddOrderCommand1.ExecuteNonQuery();
                AddOrderCommand2.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
            finally
            {
                connection.Close();
            }

        }

        public void DeleteOrder(string oNumber)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Orde WHERE oNumber='" + oNumber + "'", connection);
            {
                command.Parameters.AddWithValue("@oNumber", oNumber);

                connection.Open();

                try
                {
                    command.ExecuteNonQuery();
                }

                catch (Exception Ex)
                {
                    throw Ex;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        //Production
        public DataTable GetProduce()
        {
            connection.Open();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Produced", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
            finally
            {
                connection.Close();
            }
        }
        public DataTable AddProduce(DateTime pTime, string pName, string pPallet, string pNumber, string oNumber)
        {
            connection.Open();

            try
            {
                SqlCommand producedCommand = new SqlCommand("INSERT INTO Produced(pTime, pName, pPallet, pNumber, oNumber) VALUES (@pTime, @pName, @pPallet, @pNumber, @oNumber)", connection);
                SqlCommand DeleteingFromOrdersProduction = new SqlCommand("delete from Orderspecification  where oNumber= '" + oNumber + "'", connection);
                SqlCommand DeleteingFromOrdersProduction2 = new SqlCommand("delete from Orde  where oNumber= '" + oNumber + "'", connection);

                producedCommand.Parameters.AddWithValue("@pTime", pTime);
                producedCommand.Parameters.AddWithValue("@pName", pName);
                producedCommand.Parameters.AddWithValue("@pPallet", pPallet);
                producedCommand.Parameters.AddWithValue("@pNumber", pNumber);
                producedCommand.Parameters.AddWithValue("@oNumber", oNumber);
                producedCommand.ExecuteNonQuery();
                DeleteingFromOrdersProduction.ExecuteNonQuery();
                DeleteingFromOrdersProduction2.ExecuteNonQuery();


                if (pName == "Nötingar" && pName != "")
                {
                    for (int j = 0; j <= Int32.Parse(pPallet); j++)
                    {
                        SqlDataAdapter da = new SqlDataAdapter(@"UPDATE Ingredient SET iQuantityInStock = CASE iName
                              WHEN 'Smör' THEN (iQuantityInStock -450)
                              WHEN 'Mjöl' THEN (iQuantityInStock -450)
                              WHEN 'Socker' THEN (iQuantityInStock -190) 
                              WHEN 'Nötter' THEN (iQuantityInStock -225)
                              ELSE iQuantityInStock
                              END
                              WHERE iName IN('Smör', 'Mjöl','Socker','Nötter')", connection);

                        DataTable ProduceStorageGrid = new DataTable();
                        da.Fill(ProduceStorageGrid);
                        return ProduceStorageGrid;
                        j++;
                    }

                }
                else if (pName == "Nötkakor" && pName != "")
                {
                    for (int j = 0; j <= Int32.Parse(pPallet); j++)
                    {
                        SqlDataAdapter da = new SqlDataAdapter(@"UPDATE Ingredient SET iQuantityInStock = CASE iName
                      WHEN 'Ägg' THEN (iQuantityInStock -4)
                      WHEN 'Mjöl' THEN (iQuantityInStock -50)
                      WHEN 'Socker' THEN (iQuantityInStock -375) 
                      WHEN 'Nötter' THEN (iQuantityInStock -1375)
                      ELSE iQuantityInStock
                      END
                      WHERE iName IN('Ägg', 'Mjöl','Socker','Nötter')", connection);

                        DataTable ProduceStorageGrid = new DataTable();
                        da.Fill(ProduceStorageGrid);
                        return ProduceStorageGrid;
                        j++;
                    }

                }
                else if (pName == "Berliner" && pName != "")
                {
                    for (int j = 0; j <= Int32.Parse(pPallet); j++)
                    {
                        SqlDataAdapter da = new SqlDataAdapter(@"UPDATE Ingredient SET iQuantityInStock = CASE iName
                      WHEN 'Smör' THEN (iQuantityInStock -450)
                      WHEN 'Mjöl' THEN (iQuantityInStock -450)
                      WHEN 'Socker' THEN (iQuantityInStock -190) 
                      WHEN 'Mjölk' THEN (iQuantityInStock -150)
                      ELSE iQuantityInStock
                      END
                      WHERE iName IN('Smör', 'Mjöl','Socker','Nötter')", connection);

                        DataTable ProduceStorageGrid = new DataTable();
                        da.Fill(ProduceStorageGrid);
                        return ProduceStorageGrid;
                        j++;
                    }
                }
                else if (pName == "Kokostoppar" && pName != "")
                {
                    for (int j = 0; j <= Int32.Parse(pPallet); j++)
                    {
                        SqlDataAdapter da = new SqlDataAdapter(@"UPDATE Ingredient SET iQuantityInStock = CASE iName
                      WHEN 'Marsipan' THEN (iQuantityInStock -600)
                      WHEN 'vaniljsocker' THEN (iQuantityInStock -60)
                      WHEN 'Choklad' THEN (iQuantityInStock -400) 
                      WHEN 'Nötter' THEN (iQuantityInStock -600)
                      ELSE iQuantityInStock
                      END
                      WHERE iName IN('Marsipan', 'vaniljsocker','Choklad','Nötter')", connection);

                        DataTable ProduceStorageGrid = new DataTable();
                        da.Fill(ProduceStorageGrid);
                        return ProduceStorageGrid;
                        j++;
                    }

                }
                else if (pName == "Amneris" && pName != "")
                {
                    for (int j = 0; j <= Int32.Parse(pPallet); j++)
                    {

                        SqlDataAdapter da = new SqlDataAdapter(@"UPDATE Ingredient SET iQuantityInStock = CASE iName
                          WHEN 'Mjölk' THEN (iQuantityInStock -110)
                          WHEN 'Mjöl' THEN (iQuantityInStock -400)
                          WHEN 'Socker' THEN (iQuantityInStock -100) 
                          WHEN 'Mandel' THEN (iQuantityInStock -300)
                          ELSE iQuantityInStock
                          END
                          WHERE iName IN('Mjölk', 'Mjöl','Socker','Mandel')", connection);

                        DataTable ProduceStorageGrid = new DataTable();
                        da.Fill(ProduceStorageGrid);
                        return ProduceStorageGrid;
                        j++;

                    }
                }
                else if (pName == "Tango" && pName != "")
                {
                    for (int j = 0; j <= Int32.Parse(pPallet); j++)
                    {
                        SqlDataAdapter da = new SqlDataAdapter(@"UPDATE Ingredient SET iQuantityInStock = CASE iName
                      WHEN 'Marsipan' THEN (iQuantityInStock -550)
                      WHEN 'Choklad' THEN (iQuantityInStock -300)
                      WHEN 'vaniljsocker' THEN (iQuantityInStock -30) 
                      WHEN 'Ägg' THEN (iQuantityInStock -10)
                      ELSE iQuantityInStock
                      END
                      WHERE iName IN('Marsipan', 'Choklad','vaniljsocker','Ägg')", connection);

                        DataTable ProduceStorageGrid = new DataTable();
                        da.Fill(ProduceStorageGrid);
                        return ProduceStorageGrid;
                        j++;
                    }
                }
                return null;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
            finally
            {
                connection.Close();
            }
        }
        public string[] GetProducts(string pNumber)
        {
            string[] productList = new string[4];
            connection.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Product WHERE pName='" + pNumber + "'", connection);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    productList[0] = dr["pNumber"].ToString();
                }
                dr.Close();
                return productList;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                connection.Close();
            }
        }
        public string[] GetProductToProduceValues()
        {
            string[] productList = new string[4];

            connection.Open();

            try
            {
                SqlCommand producttoProduceecmd = new SqlCommand("SELECT * FROM Product INNER JOIN Orderspecification ON (Product.pNumber=Orderspecification.pNumber) INNER JOIN Orde ON (Orderspecification.oNumber=Orde.oNumber)", connection);

                SqlDataReader dr = producttoProduceecmd.ExecuteReader();

                if (dr.Read())
                {
                    productList[0] = dr["pNumber"].ToString();
                    productList[1] = dr["palletQuantity"].ToString();
                    productList[2] = dr["pName"].ToString();
                    productList[3] = dr["expectedDeliveryDate"].ToString();
                }
                dr.Close();

                return productList;

            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                connection.Close();
            }
        }
        public DataTable AddPallet(string palletNumber, DateTime palletTime, string pNumber, string oNumber)
        {

            connection.Open();

            try
            {
                SqlCommand insertIntoPalletCommand = new SqlCommand("INSERT INTO Pallet (palletNumber, palletTime, pNumber, oNumber) VALUES (@palletNumber, @palletTime, @pNumber, @oNumber)", connection);

                DateTime myDateTime = DateTime.Now;
                //string sqlFormattedDate = myDateTime.ToString("2016-02-02 00:00:00.000");

                insertIntoPalletCommand.Parameters.AddWithValue("@palletNumber", palletNumber);
                insertIntoPalletCommand.Parameters.AddWithValue("@palletTime", myDateTime);
                insertIntoPalletCommand.Parameters.AddWithValue("@pNumber", pNumber);
                insertIntoPalletCommand.Parameters.AddWithValue("@oNumber", oNumber);

                DataTable dtstore = new DataTable();

                SqlCommand deleteInProducedCommand = new SqlCommand("DELETE FROM Produced WHERE oNumber='" + oNumber + "'", connection);

                insertIntoPalletCommand.ExecuteNonQuery();
                deleteInProducedCommand.ExecuteNonQuery();
                connection.Close();
                return dtstore;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
            finally
            {
                connection.Close();
            }

        }
        public DataTable GetPallet()
        {
            connection.Open();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Pallet ", connection);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}



﻿
using CreateCookies.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateCookies.Controller
{
    public class Controller
    {
        DataAccessLayer dataAccessLayer = new DataAccessLayer();
        ErrorHandling error = new ErrorHandling();

        public Controller()
        {

        }
        //Customer
        public void RegisterCustomer(string[] customer)
        {
            dataAccessLayer.RegisterCustomer(customer);
        }

        public void DeleteCustomer(string cNumber)
        {
            dataAccessLayer.DeleteCustomer(cNumber);
        }

        public void UpdateCustomer(string[] customer)
        {
            dataAccessLayer.UpdateCustomer(customer);
        }

        public string[] SearchCustomer(string cNumber)
        {
          return dataAccessLayer.SearchCustomer(cNumber);
        }
        public DataTable SeeOrder(string cNumber)
        {
            return dataAccessLayer.SeeOrder(cNumber);
        }
        public DataTable SeeAllOrders()
        {
            return dataAccessLayer.SeeAllOrders();
        }

        //Order
        public void RegisterOrder(string[] Order,string[] Orderspecification)
        {
            dataAccessLayer.RegisterOrder(Order, Orderspecification);
        }
        public void DeleteOrder(string oNumber)
        {
            dataAccessLayer.DeleteCustomer(oNumber);
        }
        public DataTable SearchOrderNumber(string oNumber)
        {
            return dataAccessLayer.SearchCustomerNumber(oNumber);
        }
        public DataTable SearchExpectedDeliveryDate(string expectedDeliveryDate)
        {
            return dataAccessLayer.SearchExpectedDeliveryDate(expectedDeliveryDate);
        }
        public DataTable SearchIsDelivered(string isDelivered)
        {
            return dataAccessLayer.SearchIsDelivered(isDelivered);
        }
        public DataTable SearchCustomerNumber(string cNumber)
        {
            return dataAccessLayer.SearchCustomerNumber(cNumber);
        }
        public DataTable ChooseOrderinformation(string oNumber)
        {
            return dataAccessLayer.ChooseOrderinformation(oNumber);
        }
        //Production
        public string[] GetProduced(string pName)
        {
            return dataAccessLayer.GetProduced(pName);
        }
        public DataTable AddProduce(DateTime pTime, string pName, string pPallet, string pNumber, string oNumber)
        {
            return dataAccessLayer.AddProduce(pTime, pName, pPallet, pNumber, oNumber);
        }
        public string[] GetProducts(string pNumber)
        {
            return dataAccessLayer.GetProducts(pNumber);
        }
        public string [] GetProductToProduceValues() 
        {
            return dataAccessLayer.GetProductToProduceValues();
        }


        //Storage
        public DataTable AddPallet(string palletNumber, DateTime palletTime, string pNumber, string oNumber)
        {
            return dataAccessLayer.AddPallet(palletNumber, palletTime, pNumber, oNumber);
        }
        public DataTable GetPallet()
        {
            return dataAccessLayer.GetPallet();
        }
        public DataTable AddStoreToOrder(string oNumber, bool isDelivered, DateTime expectedDeliveryDate, string cNumber)
        {
            return dataAccessLayer.AddStoreToOrder(oNumber, isDelivered, expectedDeliveryDate, cNumber);
        }
        //Supplier


        //Error Handling
        public string Exception(Exception ex)
        {
            return error.HandleException(ex);
        }
    }
}

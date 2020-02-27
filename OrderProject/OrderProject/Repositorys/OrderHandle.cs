using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using OrderProject.Models;
using Dapper;

namespace OrderProject.Repositorys
{
    public class OrderHandle
    {
        string strconn = @"Server=localhost\sqlexpress;Integrated Security=SSPI;Database=test;";
        public Product_Model Get_productInfo(string ProductUID)
        {
            string strSQL = $@"select * from Product where ProductUID='{ProductUID}'";
            using (var conn = new SqlConnection(strconn))
            {
                conn.Open();
                return conn.QueryFirstOrDefault<Product_Model>(strSQL);
            }

        }
        public List<OrderInfo_Model> Get_OrderList(string AccountUID)
        {
            string strSQL = $@"select Product.PName,Product.Price,Product.Cost,OrderInfo.OrderStatus,OrderInfo.OrderUID from OrderInfo
                            left join Product on OrderInfo.ProductUID=Product.ProductUID where OrderInfo.AccountUID='{AccountUID}' order by Product.PName";
            using (var conn = new SqlConnection(strconn))
            {
                conn.Open();
                return conn.Query<OrderInfo_Model>(strSQL, new { IsEnable = 1 }).ToList();
            }
        }
        public void Change_Status(List<OrderInfo_Model> status)
        {
            string strSQL = $@"update OrderInfo set OrderStatus=@OrderStatus where OrderUID=@OrderUID";
            using (var conn = new SqlConnection(strconn))
            {
                conn.Open();
                conn.Execute(strSQL, status );
            }
        }
    }
}
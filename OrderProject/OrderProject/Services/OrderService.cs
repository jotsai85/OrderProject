using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OrderProject.Models;
using OrderProject.Repositorys;

namespace OrderProject.Services
{
    public class OrderService
    {
        public Product_Model GetProductInfo(string ProductUID)
        {
            var Pinfo = new OrderHandle();

            return Pinfo.Get_productInfo(ProductUID);

        }
        public List<OrderInfo_Model>GetOrderList(string AccountUID)
        {
            var Orderlist = new OrderHandle();

            return Orderlist.Get_OrderList(AccountUID);
        }
        public  void ChangeStatus(List<OrderInfo_Model> orderlist)
        {
            var change = new OrderHandle();
            change.Change_Status(orderlist);
        }
    }
}
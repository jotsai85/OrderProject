using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OrderProject.Services;
using OrderProject.Models;

namespace OrderProject.Controllers
{
    [RoutePrefix("api/value")]
    public class ValuesController : ApiController
    {
        [HttpGet]
        [Route("ProductInfo/{productUID}")]
        public virtual IHttpActionResult Get_ProductInfo(string productUID)
        {
            var product = new OrderService();

            return Ok(product.GetProductInfo(productUID));

        }
        [HttpGet]
        [Route("OrderList/{AccountUID}")]
        public virtual IHttpActionResult Get_OrderList(string AccountUID)
        {
            var Order = new OrderService();

            return Ok(Order.GetOrderList(AccountUID));

        }
        [HttpPost]
        [Route("shipped/{AccountUID}")]
        public virtual IHttpActionResult TO_be_shipped(string AccountUID,List<OrderInfo_Model> orderinfo)
        {
            var status= new OrderService();
            status.ChangeStatus(orderinfo);

            return Ok("ok");
        }
    }
}

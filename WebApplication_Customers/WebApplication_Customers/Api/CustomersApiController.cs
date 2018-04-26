using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using WebApplication_Customers.EF;

namespace WebApplication_Customers.Api
{
    public class CustomersApiController : ApiController
    {
        /// <summary>
        /// 查出所有的客戶資料
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Customers> GetAll()
        {
            NorthwindEntities dc = new NorthwindEntities();
            return dc.Customers.ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using WebApplication_Customers.EF;
using System.Data.Entity;

namespace WebApplication_Customers.Api
{
    public class CustomersApiController : ApiController
    {
        NorthwindEntities dc = new NorthwindEntities();

        /// <summary>
        /// 查出所有的客戶資料
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Customers> GetAll()
        {
            try
            {
                return dc.Customers.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 新增一筆客戶記錄
        /// </summary>
        /// <param name="customers"></param>
        [HttpPost]
        public void Create(Customers customers)
        {
            try
            {
                dc.Customers.Add(customers);
                dc.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 修改一筆客戶記錄
        /// </summary>
        /// <param name="customers"></param>
        [HttpPut]
        public void Update(Customers customers)
        {
            try
            {
                dc.Entry(customers).State = System.Data.Entity.EntityState.Modified;
                dc.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 刪除一筆客戶記錄
        /// </summary>
        /// <param name="customers"></param>
        [HttpDelete]
        public void Delete(Customers customers)
        {
            try
            {
                Customers DeleteCustomers = dc.Customers.Find(customers.CustomerID);
                dc.Customers.Remove(DeleteCustomers);
                dc.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

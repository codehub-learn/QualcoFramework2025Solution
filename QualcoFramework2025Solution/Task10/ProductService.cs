

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace QualcoLab2025.Task10
{

    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Status { get; set; }
        public DateTime OrderDate { get; set; }
    }
    public class AppDbContext
    {
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }

    public class OrderServiceOld
    {
        public List<Order> GetCustomerOrders(int customerId)
        {
            var context = new AppDbContext();
            var result = new List<Order>();

            foreach (var order in context.Orders)
            {
                if (order.CustomerId == customerId && order.Status != "Cancelled")
                {
                    result.Add(order);
                }
            }

            result.Sort((a, b) => a.OrderDate.CompareTo(b.OrderDate));

            return result;
        }
    }

    public class OrderService
    {
    }
}

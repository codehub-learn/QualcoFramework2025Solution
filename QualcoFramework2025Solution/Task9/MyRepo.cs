 
using System;
using System.Collections.Generic;
using System.Linq;

namespace QualcoLab2025.Task9
{

    public class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }

    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }
        public decimal Amount { get; set; }
    }
    public interface Infrastructure
    {
        ICollection<Customer> GetCustomers();
    }


    public class CustomerSummaryDto
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public int TotalOrders { get; set; }
        public decimal TotalSpent { get; set; }
    }

    public class ReportingService
    {
         
    }
}
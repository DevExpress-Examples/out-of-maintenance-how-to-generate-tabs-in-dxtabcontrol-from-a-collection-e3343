using System;
using System.Collections.Generic;

namespace DXExample.DemoData {
    public enum InvoiceStatus { Ordered, Payed, Shipped, Delivered, Invalidated }
    public class Invoice {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public DateTime OrderDate { get; set; }
        public double Discount { get; set; }
        public bool IsUrgent { get; set; }
        public InvoiceStatus Status { get; set; }
        static public List<Invoice> GetData() {
            List<Invoice> data = new List<Invoice>();

            data.Add(new Invoice() { ID = 0, ProductName = "Tofu", IsUrgent = false,
                Price = 235.54, Discount = 9.4, Status = InvoiceStatus.Invalidated,
                OrderDate = new DateTime(2009, 3, 12) });
            data.Add(new Invoice() { ID = 1, ProductName = "Ravioli Angelo", IsUrgent = true,
                Price = 178.45, Discount = 6.1, Status = InvoiceStatus.Delivered,
                OrderDate = new DateTime(2009, 2, 9) });
            data.Add(new Invoice() { ID = 2, ProductName = "Geitost", IsUrgent = false,
                Price = 89.98, Discount = 5.4, Status = InvoiceStatus.Payed,
                OrderDate = new DateTime(2009, 4, 1) });
            data.Add(new Invoice() { ID = 3, ProductName = "Chang", IsUrgent = true,
                Price = 189.33, Discount = 18.2, Status = InvoiceStatus.Shipped,
                OrderDate = new DateTime(2009, 5, 23) });
            data.Add(new Invoice() { ID = 4, ProductName = "Inlagd Sill", IsUrgent = false, 
                Price = 509.10, Discount = 22.2, Status = InvoiceStatus.Ordered,
                OrderDate = new DateTime(2009, 6, 30) });
            data.Add(new Invoice() { ID = 5, ProductName = "Alice Mutton", IsUrgent = true,
                Price = 791.18, Discount = 24.4, Status = InvoiceStatus.Invalidated,
                OrderDate = new DateTime(2009, 5, 7) });

            return data;
        }
    }
}

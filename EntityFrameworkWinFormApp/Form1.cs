using EntityFrameworkWinFormApp.DAL.Contexts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkWinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
using (NorthwindContext context = new NorthwindContext())
{
    foreach (var customer in context.Customers)
    {
        Console.WriteLine(customer);
    }
}*/

            /*
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Customers.Add(new Customer()
                {
                    City = "Niğde",
                    CompanyName = "Abc",
                    ContactName = "Hüseyin",
                    Country = "Türkiye"
                });
                context.SaveChanges();
            }*/

            /*
            using (NorthwindContext context = new NorthwindContext())
            {
                var customer = context.Customers.Find(1);
                context.Orders.Add(new Order()
                {
                    //OrderID = 1,
                    CreatedOrderDateTime = DateTime.Now,
                    Customer = customer,
                    ShipCity = "Niğde",
                    CustomerID = 1
                });
                context.SaveChanges();
            }
            */

            /*
            using (NorthwindContext context = new NorthwindContext())
            {
                Order order = context.Orders.Find(1);
                context.Orders.Remove(order);
                context.SaveChanges();
            }
            */

            /*
            using (NorthwindContext context = new NorthwindContext())
            {
                var customer = context.Customers.Find(1);
                customer.Country = "Rusya";
                context.SaveChanges();
            }
            */


            /*using (NorthwindContext context = new NorthwindContext())
            {*/
            /*IQueryable<Customer> result = from c in context.Customers
                                          select c;*/
            /*List<Customer> customerList = (from c in context.Customers
                select c).ToList();*/
            /*var customerList = (from c in context.Customers
                select c.ContactName).ToList();*/
            /*var customerList = from c in context.Customers
                select new { c.ContactName, c.Country, c.CompanyName };*/
            /*var customerList = from c in context.Customers
                select new Musteri{Adi = c.ContactName, Ulke = c.Country, Sirket = c.CompanyName };*/
            /*var customerList = (from c in context.Customers
                               where c.Country == "UK" && c.City == "London"
                               select c).ToList();*/
            /*var customerList = (from c in context.Customers
                where c.Country == "UK" || c.City == "Berlin"
                select c).ToList();*/
            /*var customerList = (from c in context.Customers
                group c by c.Country
                into g
                select g).ToList();*/
            /*var customerList = (from c in context.Customers
                group c by new { c.Country, c.City }
                into g
                select new {Country = g.Key.Country, City = g.Key.City, Count = g.Count()}).ToList();*/
            /*var customerList = (from c in context.Customers
                orderby c.Country, /*c.Country.Lenght descending*/ /*c.ContactName*/ //ülkeye göre sıralar ve ülke içindeki müşteri adlarını sıralar.
            /*select new { ContactName = c.ContactName}).ToList();
        foreach (var customer in customerList)
        {*/
            //Console.WriteLine(customerList.Count + " " + customerList.Capacity);
            //Console.WriteLine(customer.Key); //grubun anahtar değeri
            //Console.WriteLine(customer.City + " " + customer.Country + " " + customer.Count); 
            //Console.WriteLine(customer.Sirket + " " + customer.Adi + " " + customer.Ulke);
            /*}
        }
            */
            /*using (NorthwindContext context = new NorthwindContext())
            {*/
            /*var result = from c in context.Customers
                join o in context.Orders
                    on c.CustomerID equals o.CustomerID
                    orderby c.CustomerID
                select new
                {
                    c.CustomerID, c.ContactName, o.CreatedOrderDateTime, o.ShipCity
                };*/
            /**var result = from c in context.Customers
                join o in context.Orders
                    on new {CustomerID =  c.CustomerID, City = c.City }
                equals new {CustomerID = o.CustomerID, City = o.ShipCity } //İki kolon üstünden eşleştirme yapıyor.
                orderby c.CustomerID
                select new
                {
                    c.CustomerID,
                    c.ContactName,
                    o.CreatedOrderDateTime,
                    o.ShipCity
                };*/
            /*var result = from c in context.Customers
                join o in context.Orders
                    on new { CustomerID = c.CustomerID }
                    equals new { CustomerID = o.CustomerID} //İki kolon üstünden eşleştirme yapıyor.
                into temp
                         from co in temp.DefaultIfEmpty()
                         //where temp.Count() == 0 //hem olanlar hem olmayanlar gelsin istiyorsak bu satırı kapatacağız!
                select new
                {
                    c.CustomerID,
                    c.ContactName
                }; */
            //siparişi olmayan müşteriyi listeleyen linq sorgusudur.
            /*foreach (var item in result)
            {
                Console.WriteLine(item.CustomerID + " " + item.ContactName + " " /*+ item.CreatedOrderDateTime + " " + item.ShipCity);*/
            //}
            //    .NET Core Entity Framework çalışmalarım. Herşey program.cs'nin içinde.
            //}

            /*using (NorthwindContext context = new NorthwindContext())
            {*/
            //var results = context.Customers.Where(x => x.City == "London" && x.Country == "UK");
            //var results = context.Customers.Where(x => x.City == "London" && x.Country == "UK").OrderBy(x => x.ContactName);
            /*var results = context.Customers.Where(x => x.City == "London" && x.Country == "UK").OrderBy(x => x.ContactName)
                .Select(x => new { x.ContactName, x.CompanyName, x.City });

            foreach (var customer in results)
            {
                Console.WriteLine(customer);
            }*/
            //}

            using (NorthwindContext context = new NorthwindContext())
            {
                var results = context.Customers.
                    Where(x => x.ContactName == "Hüseyin Aydın")
                    .ToList();
                foreach (var customer in results)
                {
                    label1.Text += customer.ToString();
                    Console.WriteLine(customer.ToString());
                }
            }
        }
    }
}

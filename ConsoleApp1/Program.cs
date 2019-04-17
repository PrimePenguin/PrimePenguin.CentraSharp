using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PrimePenguin.CentraSharp.Filters;
using PrimePenguin.CentraSharp.Services.Brand;
using PrimePenguin.CentraSharp.Services.Category;
using PrimePenguin.CentraSharp.Services.Customer;
using PrimePenguin.CentraSharp.Services.Order;
using PrimePenguin.CentraSharp.Services.Product;
using PrimePenguin.CentraSharp.Services.Shipment;
using PrimePenguin.CentraSharp.Services.SupplierOrder;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            //var cc = new OrderFilter { Limits = 5, order = 7 };
            //var customwe = new CustomerService("https://sandbox.centraqa.com/", "5pNYv8tlXDmb");
            //var ddd = Task.Run(async () => await customwe.GetAsync(5));
            //var aa = new OrderFilter { Limits = 5, order = 7 };
            //var product = new ProductService("https://sandbox.centraqa.com/", "5pNYv8tlXDmb");
            //var a = Task.Run(async () => await product.ListAsync());
            //var order = new OrderService("https://sandbox.centraqa.com/", "5pNYv8tlXDmb");

            //var order1 = order.GetAsync(7);
            //var b = Task.Run(async () => await order.ListAsync());
            //var customer = new CustomerService("https://sandbox.centraqa.com/", "5pNYv8tlXDmb");
            //var c = Task.Run(async () => await customer.ListAsync());
            //var supplier = new SupplierOrderService("https://sandbox.centraqa.com/", "5pNYv8tlXDmb");
            //var d = Task.Run(async () => await supplier.ListSupplierOrdersAsync());
            //a.Wait();
            //b.Wait();
            //c.Wait();
            //d.Wait();
            //ddd.Wait();
            //order1.Wait();

            //var orderService = new OrderService("https://sandbox.centraqa.com/", "5pNYv8tlXDmb");
            //var orders = orderService.UpdateAsync(new OrderUpdateOptions
            //{
            //    Order = 11,
            //    InternalComment = "new"
            //}).Result;
            //var json = JsonConvert.SerializeObject(orders, Formatting.Indented);
            var shipmentService = new CampaignService("https://sandbox.centraqa.com/", "5pNYv8tlXDmb");
            var data = new List<KeyValuePair<string, int>>()
            {
                new KeyValuePair<string, int>("9", 1)
            };
            var orders = shipmentService.GetCampaign().Result;
            var json = JsonConvert.SerializeObject(orders, Formatting.Indented);
        }
    }
}
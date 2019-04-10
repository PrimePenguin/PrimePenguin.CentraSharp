using System.Threading.Tasks;
using PrimePenguin.CentraSharp.Filters;
using PrimePenguin.CentraSharp.Services.Customer;
using PrimePenguin.CentraSharp.Services.Order;
using PrimePenguin.CentraSharp.Services.Product;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var aa = new OrderFilter { Limits = 5, order = 7 };

            var product = new ProductService("https://sandbox.centraqa.com/", "5pNYv8tlXDmb");
            var a = Task.Run(async () => await product.ListAsync());
            var order = new OrderService("https://sandbox.centraqa.com/", "5pNYv8tlXDmb");
            var b = Task.Run(async () => await order.ListAsync());
            var customer = new CustomerService("https://sandbox.centraqa.com/", "5pNYv8tlXDmb");
            var c = Task.Run(async () => await customer.ListAsync());
            a.Wait();
            b.Wait();
            c.Wait();
        }
    }
}
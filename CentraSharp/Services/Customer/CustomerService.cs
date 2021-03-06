﻿using PrimePenguin.CentraSharp.Entities;
using PrimePenguin.CentraSharp.Extensions;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PrimePenguin.CentraSharp.Services.Customer
{
    /// <summary>
    /// A service for manipulating Centra orders.
    /// </summary>
    public class CustomerService : CentraService
    {
        /// <summary>
        /// Creates a new instance of <see cref="CustomerService" />.
        /// </summary>
        /// <param name="myCentraUrl">The shop's *.myCentraUrl.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public CustomerService(string myCentraUrl, string shopAccessToken) : base(myCentraUrl, shopAccessToken)
        {
        }

        /// <summary>
        /// Gets a list of the Customers.
        /// </summary>
        /// <param name="options">Options for filtering the list.</param>
        /// <returns>The list of Customers matching the filter.</returns>
        public virtual async Task<CustomerList> ListAsync(CustomerFilter options = null)
        {
            var req = PrepareRequest("customers");

            if (options != null) req.QueryParams.AddRange(options.ToParameters());

            return await ExecuteRequestAsync<CustomerList>(req, HttpMethod.Get);
        }

        /// <summary>
        /// Retrieves the customer with the given id.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns>The customer for matched Id</returns>
        public virtual async Task<CustomerById> GetAsync(int customerId)
        {
            var req = PrepareRequest($"customers/{customerId}");
            return await ExecuteRequestAsync<CustomerById>(req, HttpMethod.Get);
        }

        /// <summary>
        /// Update customer for given customerID
        /// </summary>
        /// <param name="updateCustomer"></param>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public virtual async Task<CustomerById> UpdateAsync(UpdateCustomerOptions updateCustomer, int customerId)
        {
            var req = PrepareRequest($"customers/{customerId}");
            var body = updateCustomer.ToDictionary();
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(body);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            return await ExecuteRequestAsync<CustomerById>(req, HttpMethod.Put, httpContent);
        }
    }
}
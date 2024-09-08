using OnlineShopTest.DataBase;
using OnlineShopTest.Dtos;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using OnlineShopTest.Models;
using Microsoft.EntityFrameworkCore;

namespace OnlineShopTest.repo
{
    public class Repository(DBContext dbcontext)
    {
        public async Task<CustomerModel[]> GetCustomers()
        {
            var customers = await dbcontext.Customers
                .OrderBy(u => u.Name)
                .ToArrayAsync();
            return customers;
        }
    }
}

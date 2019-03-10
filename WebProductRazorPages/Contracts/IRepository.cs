using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProductRazorPages.Models;

namespace WebProductRazorPages.Contracts
{
    public interface IRepository
    {
        List<Product> GetList();
        Product GetProductByID(int id);
    }
}

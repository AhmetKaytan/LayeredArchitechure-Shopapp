using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopapp.entity;

namespace shopapp.data.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        Product GetProductDetails(int id);
        List<Product> GetPopularProducts();
        List<Product> GetProductsByCategory(string name);
        List<Product> GetTop5Products();
    }
}
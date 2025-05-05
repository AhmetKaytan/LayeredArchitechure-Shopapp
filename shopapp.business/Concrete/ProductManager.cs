using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopapp.business.Abstract;
using shopapp.data.Abstract;
using shopapp.data.Concrete.EfCore;
using shopapp.entity;

namespace shopapp.business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productrepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productrepository = productRepository;
        }

        public void Create(Product entity)
        {
            //iş kurallarını uygula
            _productrepository.Create(entity);
        }

        public void Delete(Product entity)
        {
            //iş kuralları
            _productrepository.Delete(entity);
        }

        public List<Product> GetAll()
        {
            //iş kuralları
            return _productrepository.GetAll();
        }

        public Product GetById(int id)
        {
            //iş kuralları
            return _productrepository.GetById(id);
        }

        public Product GetProductDetails(int id)
        {
            return _productrepository.GetProductDetails(id);
        }

        public void Update(Product entity)
        {
            _productrepository.Update(entity);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal:IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product {Id = 1, Name = "bardak", CategoryId = 1,Qty = 5},
                new Product {Id = 2, Name = "Canak", CategoryId = 1,Qty = 10},
                new Product {Id = 3, Name = "Cömlek", CategoryId = 1,Qty = 20}
            };
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Update(Product product)
        {
            var productToUpdate = _products.SingleOrDefault(x => x.Id == product.Id);
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            var productToDelete = _products.SingleOrDefault(x => x.Id == product.Id);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll(int categoryId)
        {
            return _products.Where(x => x.CategoryId == categoryId).ToList();
        }
    }
}
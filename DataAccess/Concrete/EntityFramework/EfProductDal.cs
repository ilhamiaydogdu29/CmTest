using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal :EfEntityRepositoryBase<Product,CmTestContext>,IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (var context = new CmTestContext())
            {
                var result = from p in context.Products
                    join c in context.Categories
                        on p.CategoryId equals c.Id
                    select new ProductDetailDto
                    {
                        CategoryName = c.Name,
                        ProductId = p.Id,
                        ProductName = p.Name
                    };
                return result.ToList();
            }
        }
    }
}
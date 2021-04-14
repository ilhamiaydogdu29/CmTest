using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<ProductDetailDto>> GetProductDetails();

        IResult Add(Product product);
        IResult Update(Product product);
        IDataResult<Product>  GetById(int productId);
    }
}
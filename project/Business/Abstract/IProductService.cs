using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id); //category id'e göre filtrele 
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);  //x fiyat aralığındaki ürünleri getir
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IResult Add(Product product); //Data olanlara IResult veriyoruz.Result mesaj ve success içeriyor.
        IDataResult<Product> GetById(int productId);
        IResult Update(Product product);
    }
}

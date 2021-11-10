using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //product ile ilgili db işlemleri yapılacak
    //business IProductDal'a bağlı olduğu için en sona IProductDal yazılır
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var result = from p in context.Products
                             join x in context.Categories
                             on p.CategoryId equals x.CategoryId
                             select new ProductDetailDto
                             {
                                 CategoryName = x.CategoryName,
                                 ProductName = p.ProductName,
                                 ProductId = p.ProductId,
                                 UnitsInStock = p.UnitsInStock
                             };
                return result.ToList();
            }
        }
    }
}

using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DataAccess.Concrete.EntityFramework
{
    public class ProductsToSalesDal : EfRepositoryBase<ProductsToSales, AppDbContext>, IProductsToSalesDal
    {
        public List<ProductsToSalesDto> GetAllProductsToSales()
        {
            using (var context = new AppDbContext())
            {
                var products = context.Products.ToList();


                var result = new List<ProductsToSalesDto>();
                for (int i = 0; i < products.Count; i++)
                {

                    ProductsToSalesDto prod = new ProductsToSalesDto
                    {
                        ProductId = products[i].Id,
                        Title = products[i].Title,
                        Price = products[i].Price,
                        Poster = products[i].Poster,
                        Description = products[i].Description,
                        TargetId = products[i].TargetId,
                        ProductOptionsDtos = GetProductOptionsById(products[i].Id)
                    };
                    result.Add(prod);
                };
                return result;

            }
        }
        private List<ProductOptionsDto> GetProductOptionsById(int productId)
        {
            using (var context = new AppDbContext())
            {
                var productToSales = context.ProductsToSales.Where(x => x.ProductId == productId).Include(c => c.Color).Include(s => s.Size).ToList();

                List<ProductOptionsDto> productOptionsDtos = new();

                for (int i = 0; i < productToSales.Count; i++)
                {
                    ProductOptionsDto productOptionsDto = new()
                    {
                        Color = productToSales[i].Color.Name,
                        Amount = productToSales[i].Amount,
                        SizeDescription = productToSales[i].Size.Description,
                    };

                    productOptionsDtos.Add(productOptionsDto);

                }
                return productOptionsDtos;
            }
        }
    }



}


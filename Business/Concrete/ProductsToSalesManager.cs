using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.DTOs;

namespace Business.Concrete
{
    public class ProductsToSalesManager : IProductsToSalesService
    {
        private readonly IProductsToSalesDal productsToSalesDal;
        public ProductsToSalesManager(IProductsToSalesDal productsToSalesDal)
        {
            this.productsToSalesDal = productsToSalesDal;
        }

        public IDataResult<List<ProductsToSalesDto>> GetProductsToSales()
        {
            var products = productsToSalesDal.GetAllProductsToSales();

            return new SuccessDataResult<List<ProductsToSalesDto>>(products);
        }
    }
}

using Core.DataAccess;
using Entity.Concrete;
using Entity.DTOs;

namespace DataAccess.Abstract
{
    public interface IProductsToSalesDal : IRepositoryBase<ProductsToSales>
    {
        List<ProductsToSalesDto> GetAllProductsToSales();

    }
}

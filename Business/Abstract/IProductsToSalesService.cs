using Core.Utilities.Results;
using Entity.DTOs;

namespace Business.Abstract
{
    public interface IProductsToSalesService
    {
       IDataResult<List<ProductsToSalesDto>> GetProductsToSales();
    }
}

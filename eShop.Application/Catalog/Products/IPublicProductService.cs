using eShop.Application.Catalog.Dtos;
using eShop.Application.Catalog.Products.Dtos;
using eShop.Application.Catalog.Products.Dtos.Public;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}

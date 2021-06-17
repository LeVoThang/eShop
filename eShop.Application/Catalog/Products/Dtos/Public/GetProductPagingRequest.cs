using eShop.Application.Catalog.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Application.Catalog.Products.Dtos.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { set; get; }
    }
}

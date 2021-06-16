using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Application.Catalog.Dtos
{
    public class PagedViewModel<T>
    {
        List<T> Items { set; get; }
        public int TotalRecord { set; get; }
    }
}
 
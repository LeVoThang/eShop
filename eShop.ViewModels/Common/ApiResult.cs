using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.ViewModels.Common
{
    public class ApiResult<T>
    {
       
        public bool IsSuccessed { set; get; }

        public string Message { set; get; }
        public T ResultObj { set; get; }
    }
}

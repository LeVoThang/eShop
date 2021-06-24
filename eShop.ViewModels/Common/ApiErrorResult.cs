using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Http.ModelBinding;

namespace eShop.ViewModels.Common
{
    public class ApiErrorResult<T> : ApiResult<T>
    {
        public string[] ValidationErrors { set; get; }

        public ApiErrorResult()
        {

        }
        public ApiErrorResult(string message)
        {
            IsSuccessed = false;
            Message = message;
        }

        public ApiErrorResult(string[] validationErrors)
        {
            IsSuccessed = false;
            ValidationErrors = validationErrors;
        }
    }
}

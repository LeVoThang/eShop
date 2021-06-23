using eShop.ViewModels.Common;
using eShop.ViewModels.System.Users;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Application.System.Users
{
    public interface IUserService
    {
        Task<string>Authenticate(LoginRequest request);
        Task<bool> Register(RegisterRequest request);

        Task<PagedResult<UserVm>> GetUsersPaging(GetUserPagingRequest request);
    }

}

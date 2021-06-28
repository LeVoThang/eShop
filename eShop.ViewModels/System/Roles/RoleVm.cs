using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.ViewModels.System.Roles
{
    public class RoleVm
    {
        public Guid Id { set; get; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}

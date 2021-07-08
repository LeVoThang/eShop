using eShop.ViewModels.System.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.AdminApp.Models
{
    public class NavigationViewModel
    {
        public List<LanguageVm> Languages { set; get; }
        public string CurrentLanguageId { set; get; }

        public string ReturnUrl { get; set; }
    }
}

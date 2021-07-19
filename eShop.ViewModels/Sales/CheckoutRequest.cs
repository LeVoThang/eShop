﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.ViewModels.Sales
{
    public class CheckoutRequest
    {
        public string Name { set; get; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public List<OrderDetailVm> OrderDetails { get; set; }
    }
}
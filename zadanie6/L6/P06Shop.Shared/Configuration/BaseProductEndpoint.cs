﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06Shop.Shared.Configuration
{
    public class BaseProductEndpoint
    {
        public string Base_url { get; set; }
        public string GetAllProductsEndpoint { get; set; }
        public string GetOneProductEndpoint { get; set; }
        public string AddProductEndpoint { get; set; }
        public string DeleteProductEndpoint { get; set; }
        public string UpdateProductsEndpoint { get; set; }
    }
}

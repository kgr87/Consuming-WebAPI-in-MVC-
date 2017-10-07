﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Models
{
    interface IProduct
    {
        IEnumerable<Product> GetAll();
        Product FindbyId(string id);

    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Data
{
    public interface ICustomerRepository
    {
        List<string> GetAll();
    }
}
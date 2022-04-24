using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Service
{
    public interface ICustomerService
    {
        List<string> GetAll();
    }
}

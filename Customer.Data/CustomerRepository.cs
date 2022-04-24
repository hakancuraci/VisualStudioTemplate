using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Data
{
    public class CustomerRepository: ICustomerRepository
    {
        public List<string> GetAll()
        {
            return new List<string> { "Data1", "Data2", "Data3" };
        }
    }
}

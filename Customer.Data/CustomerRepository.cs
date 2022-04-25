using System.Collections.Generic;

namespace $ext_safeprojectname$.Data
{
    public class CustomerRepository: ICustomerRepository
    {
        public List<string> GetAll()
        {
            return new List<string> { "Data1", "Data2", "Data3" };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

using CafeCustomerInfoRecord.Abstract;
using CafeCustomerInfoRecord.Entities;

namespace CafeCustomerInfoRecord.Concrete
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

using CafeCustomerInfoRecord.Abstract;
using CafeCustomerInfoRecord.Entities;

namespace CafeCustomerInfoRecord.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}

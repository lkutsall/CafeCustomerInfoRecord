using System;
using System.Collections.Generic;
using System.Text;

using CafeCustomerInfoRecord.Entities;

namespace CafeCustomerInfoRecord.Abstract
{
    public interface ICustomerCheckService
    {
       bool CheckIfRealPerson(Customer customer);
    }
}

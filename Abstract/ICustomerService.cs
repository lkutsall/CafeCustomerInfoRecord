using System;
using System.Collections.Generic;
using System.Text;

using CafeCustomerInfoRecord.Entities;

namespace CafeCustomerInfoRecord.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}

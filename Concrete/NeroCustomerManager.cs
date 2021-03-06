using System;
using System.Collections.Generic;
using System.Text;

using CafeCustomerInfoRecord.Abstract;
using CafeCustomerInfoRecord.Entities;

namespace CafeCustomerInfoRecord.Concrete
{
    public class NeroCustomerManager : BaseCustomerManager
    {
        public override void Save(Customer customer)
        {
            base.Save(customer);
        }
    }
}

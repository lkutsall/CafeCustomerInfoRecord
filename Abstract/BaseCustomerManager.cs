using System;
using System.Collections.Generic;
using System.Text;

using CafeCustomerInfoRecord.Entities;
namespace CafeCustomerInfoRecord.Abstract
{
    public class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db : " + customer.FirstName);
        }
    }
}

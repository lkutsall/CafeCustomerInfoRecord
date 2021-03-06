using System;

using CafeCustomerInfoRecord.Concrete;
using CafeCustomerInfoRecord.Abstract;
using CafeCustomerInfoRecord.Entities;

namespace CafeCustomerInfoRecord
{
    partial class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new CustomerCheckManager);
            customerManager.Save(new Customer { FirstName = "Kutsal", LastName = "Mustafaoglu", DateOfBirth = new DateTime(1990, 04, 26), NationalityId = "11111111111", Id = 1 });
        }
    }
}

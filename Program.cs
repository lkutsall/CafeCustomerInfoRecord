using System;

using CafeCustomerInfoRecord.Concrete;
using CafeCustomerInfoRecord.Abstract;
using CafeCustomerInfoRecord.Entities;
using CafeCustomerInfoRecord.Adapters;

namespace CafeCustomerInfoRecord
{
    partial class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { FirstName = "Kutsal", LastName = "Mustafaoğlu", DateOfBirth = new DateTime(1991,04,26), NationalityId = "11111111111", Id = 1 });
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

using CafeCustomerInfoRecord.Abstract;

namespace CafeCustomerInfoRecord.Entities
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}

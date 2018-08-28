﻿using System.Collections.Generic;
using DDDSkeletonNET.Infrastructure.Common.Domain;

namespace DDDSkeleton.Portal.Domain.Customer
{
    public interface ICustomerRepository : IRepository<Customer, int>
    {
        IEnumerable<Customer> FindAll();
    }
}
﻿using DDDSkeletonNET.Portal.ApplicationServices.Messaging.Customers;

namespace DDDSkeletonNET.Portal.ApplicationServices.Interfaces
{
    public interface ICustomerService
    {
        GetCustomerResponse GetCustomer(GetCustomerRequest getCustomerRequest);
        GetCustomersResponse GetAllCustomers();
        InsertCustomerResponse InsertCustomer(InsertCustomerRequest insertCustomerRequest);
        UpdateCustomerResponse UpdateCustomer(UpdateCustomerRequest updateCustomerRequest);
        DeleteCustomerResponse DeleteCustomer(DeleteCustomerRequest deleteCustomerRequest);
    }
}
using DDDSkeletonNET.Portal.ApplicationServices.Interfaces;
using DDDSkeletonNET.Portal.ApplicationServices.Messaging;
using DDDSkeletonNET.Portal.ApplicationServices.Messaging.Customers;
using DDDSkeletonNET.Portal.WebService.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Net.Http;

namespace DDDSkeletonNET.Portal.WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService ?? throw new ArgumentException("CustomerService is null");
        }

        [HttpGet]
        public IActionResult GetCustomers()
        {
            ServiceResponseBase resp = _customerService.GetAllCustomers();


            return BuildRespones(resp);
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult Get(int id)
        {
            var resp = _customerService.GetCustomer(new GetCustomerRequest(id));

            return BuildRespones(resp);
        }


        private ObjectResult BuildRespones(ServiceResponseBase serviceResponse)
        {
            if (serviceResponse.Exception != null)
            {
                var statusCode = serviceResponse.Exception.ConvertToHttpStatusCode();
                return StatusCode((int)statusCode, serviceResponse.Exception.Message);
            }

            return Ok(serviceResponse);
        }

    }
}
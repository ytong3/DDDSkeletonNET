using System;
using System.Net;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DDDSkeletonNET.Portal.WebService
{
    public class DDSExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            HttpStatusCode status = HttpStatusCode.InternalServerError;
            string message = String.Empty;

            var exceptionType = context.Exception.GetType();

        }
    }
}
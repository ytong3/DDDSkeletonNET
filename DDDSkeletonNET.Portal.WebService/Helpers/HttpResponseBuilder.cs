using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using DDDSkeletonNET.Portal.ApplicationServices.Messaging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDDSkeletonNET.Portal.WebService.Helpers
{
    public static class HttpResponseBuilder
    {
        public static HttpResponseMessage BuildResponse(this HttpRequestMessage requestMessage, ServiceResponseBase baseResponse)
        {
            HttpStatusCode statusCode = HttpStatusCode.OK;
            if (baseResponse.Exception != null)
            {
                statusCode = baseResponse.Exception.ConvertToHttpStatusCode();
                HttpResponseMessage message = new HttpResponseMessage(statusCode);
                message.Content = new StringContent(baseResponse.Exception.Message);

                return message;

            }

            var httpResponse = requestMessage.CreateResponse(statusCode);
            httpResponse.Content = new ObjectContent<ServiceResponseBase>(baseResponse, new JsonMediaTypeFormatter());

            return httpResponse;
        }
    }
}
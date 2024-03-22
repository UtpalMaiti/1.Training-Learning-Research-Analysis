using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

using System.Net;
using System.Text.Json;

namespace _99.CoreBasics.Utility
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
        {
            _logger = logger;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                //_logger.LogError($"Something went wrong: {ex}");
                _logger.LogError(ex.ToString());
                if(ex.InnerException != null)
                {
                    _logger.LogError(ex.InnerException.ToString());

                }
                //await HandleExceptionAsync(httpContext, ex);
                await _next(httpContext);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            //await context.Response.WriteAsync(new ErrorDetails()
            //{
            //    StatusCode = context.Response.StatusCode,
            //    Message = "Internal Server Error from the custom middleware."
            //}.ToString());

            await _next(context);
        }
    }
}

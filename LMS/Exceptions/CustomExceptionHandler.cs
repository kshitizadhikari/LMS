using LMS.Core.Entities;
using Microsoft.AspNetCore.Diagnostics;

namespace LMS.Api.Exceptions
{
    public class CustomExceptionHandler : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            var response = new ErrorResponse
            {
                StatusCode = StatusCodes.Status500InternalServerError,
                Title = "Something went wrong",
                Message = exception.Message
            };

            await httpContext.Response.WriteAsJsonAsync(response, cancellationToken);
            httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            return true;
        }
    }
}

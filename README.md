# Exceptions
A generic implementation of Exceptions used in our applications...

## Usage
```c#
public class ConstraintException : BaseException
{
    public override HttpStatusCode StatusCode { get; } = HttpStatusCode.MethodNotAllowed;

    public ConstraintException(string message)
        : base(message)
    {
    }

    public ConstraintException(string message, Exception ex)
        : base(message, ex)
    {
    }
}
```

### Middleware
```c#
public class ExceptionMiddleware
{
    readonly RequestDelegate _next;

    public ExceptionMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext httpContext)
    {
        try
        {
            await _next(httpContext);
        }
        catch (BaseException ex)
        {
            await HandleException(httpContext, ex);
        }
        catch (Exception ex)
        {
            if (ex.InnerException?.GetBaseException() is BaseException)
            {
                await HandleException(httpContext, ex.InnerException?.GetBaseException() as BaseException);
            }

            throw ex;
        }
    }

    public static Task HandleException(HttpContext httpContext, BaseException ex)
    {
        httpContext.Response.Clear();
        httpContext.Response.StatusCode = (int)ex.StatusCode;
        httpContext.Response.ContentType = "application/problem+json";

        var exception = ex.Model;
        exception.Instance = httpContext.Request.Path.Value;

        return httpContext.Response.WriteAsync(JsonConvert.SerializeObject(exception));
    }
}
```

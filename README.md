# Exceptions
A generic implementation of Exceptions used in our applications...

## Usage
```c#
public class ConstraintException : laget.Exceptions.Exception
{
    public override HttpStatusCode StatusCode => HttpStatusCode.MethodNotAllowed;

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

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (laget.Exceptions.Exception ex)
        {
            await HandleExceptionAsync(context, ex);
        }
        catch (Exception e)
        {
            if (e.InnerException?.GetBaseException() is laget.Exceptions.Exception)
            {
                await HandleExceptionAsync(context, e.InnerException?.GetBaseException() as laget.Exceptions.Exception);
            }

            await HandleExceptionAsync(context, e);
        }
    }

    static Task HandleExceptionAsync(HttpContext context, Exception ex)
    {
        return HandleExceptionAsync(context, ex.GetResponse());
    }

    static Task HandleExceptionAsync(HttpContext context, laget.Exceptions.Exception ex)
    {
        return HandleExceptionAsync(context, ex.GetResponse());
    }

    static Task HandleExceptionAsync(HttpContext context, laget.Exceptions.Models.Response model)
    {
        context.Response.Clear();
        context.Response.ContentType = "application/problem+json";
        context.Response.StatusCode = model.Status ?? (int)HttpStatusCode.InternalServerError;

        var response = JsonConvert.SerializeObject(model);

        return context.Response.WriteAsync(response);
    }
}
```

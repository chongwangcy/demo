namespace ContextInjection;

public class ExecutionMiddleware
{
    private readonly RequestDelegate _next;

    public ExecutionMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext httpContext, DemoContext executionContext)
    {
        executionContext.DemoId = "1234567890";
        await _next(httpContext);
    }
}

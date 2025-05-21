namespace API.CustomMiddeware
{
    public class LoggerMiddleware
    {
        public readonly ILogger<LoggerMiddleware> _logger;
        public readonly RequestDelegate _next;
        public LoggerMiddleware(ILogger<LoggerMiddleware> logger, RequestDelegate next)
        {
            _logger = logger;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context) 
        {
            if (context == null)
            {
                _logger.LogError("Context is null");
                return;
            }
        
            _logger.LogInformation(context.Request.ToString());
            await _next(context);
            _logger.LogInformation(context.Request.ToString());
        }
    }
}

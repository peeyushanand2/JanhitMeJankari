namespace API.CustomMiddeware
{
    public class LoggerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<LoggerMiddleware> _logger;

        public LoggerMiddleware(RequestDelegate next, ILogger<LoggerMiddleware> logger)
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
        }
    }
}

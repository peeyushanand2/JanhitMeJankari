namespace API.CustomMiddeware
{
    public class LoggerMiddleware(ILogger<LoggerMiddleware> _logger):IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate _next) 
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

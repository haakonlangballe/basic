using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;

namespace basic.Middleware
{
    public class LoggingMiddleware
    {
        public RequestDelegate nextDelegate;

        public LoggingMiddleware(RequestDelegate next)
        {
            nextDelegate = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Debug.WriteLine("=== Before ===");
            await nextDelegate.Invoke(context);
            Debug.WriteLine("=== After ===");
        }
    }
}

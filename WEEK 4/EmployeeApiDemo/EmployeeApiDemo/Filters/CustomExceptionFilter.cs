using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.IO;

namespace EmployeeApiDemo.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var ex = context.Exception;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Logs");
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            File.WriteAllText(Path.Combine(path, "error.txt"), $"[{DateTime.Now}] {ex.Message}");

            context.Result = new ObjectResult("Internal Server Error occurred")
            {
                StatusCode = 500
            };
        }
    }
}

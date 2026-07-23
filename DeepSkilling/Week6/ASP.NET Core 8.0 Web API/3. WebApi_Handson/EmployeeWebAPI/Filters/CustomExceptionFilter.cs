using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EmployeeWebAPI.Filters;

public class CustomExceptionFilter : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        string logPath = Path.Combine(Directory.GetCurrentDirectory(), "Logs");

        if (!Directory.Exists(logPath))
        {
            Directory.CreateDirectory(logPath);
        }

        string filePath = Path.Combine(logPath, "ExceptionLog.txt");

        File.AppendAllText(
            filePath,
            $"[{DateTime.Now}] {context.Exception.Message}{Environment.NewLine}"
        );

        context.Result = new ObjectResult(new
        {
            Message = "Internal Server Error",
            Error = context.Exception.Message
        })
        {
            StatusCode = StatusCodes.Status500InternalServerError
        };

        context.ExceptionHandled = true;
    }
}
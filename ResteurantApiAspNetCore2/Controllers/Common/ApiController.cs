using ErrorOr;
using Microsoft.AspNetCore.Mvc;

namespace ResteurantApiAspNetCore2.Controllers.Common
{
    [ApiController] //atrybuty
    [Route("api/[controller]")]

    public class ApiController : ControllerBase
    {
        protected IActionResult Problem(List<Error> errors) 
        {
            if (errors.Count == 0)
            {
                return Problem();
            }

            var firstError = errors[0];

            return Problem(firstError);
        }

        private IActionResult Problem(Error error) //pomocnicza metoda
        {
            int? statusCode;

            switch (error.Type)
            {
                case ErrorType.Conflict:
                    statusCode = StatusCodes.Status409Conflict;
                    break;
                case ErrorType.Validation:
                    statusCode = StatusCodes.Status400BadRequest;
                    break;
                case ErrorType.NotFound: 
                    statusCode = StatusCodes.Status404NotFound;
                    break;
                default:
                    statusCode = StatusCodes.Status500InternalServerError; 
                    break;   
            }

            string? title = null;

            if (statusCode >= 400 && statusCode < 500)
            {
                title = "Input data error.";
            }
            else if (statusCode >= 500)
            {
                title = "Internal server error.";
            }

            return Problem(statusCode: statusCode,title: title, detail: error.Description);
        }

    }
}

using FindIndexNfibo.Service;
using Microsoft.AspNetCore.Mvc;

namespace FindIndexNfibo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FibonacciController : ControllerBase
    {
        //if it conditions that the parameter must be greater than 0 to comply with the rule

        //enters the function that calculates the value of the index
        private readonly IFiboService _fibonacciService;

        public FibonacciController(IFiboService fibonacciService)
        {
            _fibonacciService = fibonacciService;
        }

        //call action when the api is executed
        [HttpGet("{n}")]
        public IActionResult Get(int n)
        {
            try
            {
                var result = _fibonacciService.CalculateFibonacci(n);
                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
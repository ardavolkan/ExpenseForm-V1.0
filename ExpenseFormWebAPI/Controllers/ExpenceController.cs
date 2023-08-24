using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseFormWebAPI.Controllers
    
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenceController : ControllerBase
    {
        private readonly IExpenceService _expenceService;
        public ExpenceController(IExpenceService expenceService)
        {
            _expenceService = expenceService;           
        }
    }
}

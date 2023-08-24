using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseFormWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceiptController : ControllerBase
    {
        private readonly IReceiptService _receiptService;
        public ReceiptController(IReceiptService receiptService)
        {
            _receiptService = receiptService;
        }

    }
}

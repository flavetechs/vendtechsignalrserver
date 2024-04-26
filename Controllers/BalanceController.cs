using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using signalrserver.Hub_connection;

namespace signalrserver.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BalanceController : ControllerBase
    {
        private readonly ILogger<BalanceController> _logger;
        private readonly IHubContext<MessageHub, IMessageHub> hubContext;

        public BalanceController(ILogger<BalanceController> logger, IHubContext<MessageHub, IMessageHub> hubContext)
        {
            _logger = logger;
            this.hubContext = hubContext;
        }

       

        [HttpPost("update", Name = "update")]
        public IActionResult BalanceUpdate([FromBody] MessageBody request)
        {
            hubContext.Clients.All.SendBalanceUpdate("BalanceUpdate", request.UserId);
            return Ok(request);
        }

        public class MessageBody
        {
            public MessageBody()
            {
                UserId = string.Empty;
            }
            public string UserId { get; set; }
        }
    }
}
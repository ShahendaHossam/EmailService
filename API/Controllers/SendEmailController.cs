using Application.IManagers;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/controller")]
    public class SendEmailController : ControllerBase
    {
        private readonly ISendEmailManager _sendEmailManager;
        public SendEmailController(ISendEmailManager sendEmailManager)
        {
            _sendEmailManager = sendEmailManager;
        }

        [HttpPost]
        [Route("SendEmail")]
        public async Task<IActionResult> SendEmail(string receiver, string subject, string body)
        {
            await _sendEmailManager.SendEmail(receiver, subject, body);
            return Ok();
        }
    }
}

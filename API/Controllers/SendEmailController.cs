using Application.Dtos;
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
        public async Task<IActionResult> SendEmail(SendEmailDto sendEmail)
        {
            await _sendEmailManager.SendEmail(sendEmail);
            return Ok();
        }
    }
}

using App.Domain.Models;
using App.Publisher.Api.Models.Requests;
using App.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace App.Publisher.Api.Controllers
{
    [Route("messages")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMessageService _messageService;

        public MessagesController(IMessageService messageService)
        {
            _messageService = messageService;    
        }

        [HttpPost, Route("")]
        public async Task<IResult> Post([FromBody] CreateMessageRequest request)
        {
            _messageService.SendMessage(Message.Create(
                request.Id,
                request.Title,
                request.Body
            ));

            return await Task.FromResult(Results.Ok());
        }
    }
}

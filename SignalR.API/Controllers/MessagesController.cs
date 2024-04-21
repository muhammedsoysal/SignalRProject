using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.MessageDto;
using SignalR.EntityLayer.Entities;

namespace SignalR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMessageService _messageService;

        public MessagesController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpGet]
        public IActionResult MessageList()
        {
            return Ok(_messageService.TGetListAll());
        }
        [HttpPost]
        public IActionResult CreateMessage(CreateMessageDto createMessageDto)
        {
            var value = new Message()
            {
                Content = createMessageDto.Content,
                Email = createMessageDto.Email,
                NameSurname = createMessageDto.NameSurname,
                Phone = createMessageDto.Phone,
                SendDate = DateTime.Now,
                Subject = createMessageDto.Subject,
                Status = false
            };
            _messageService.TAdd(value);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteMessage(int id)
        {
            var value = _messageService.TGetById(id);
            _messageService.TDelete(value);
            return Ok("Mesaj Silindi.");
        }
        [HttpPut]
        public IActionResult UpdateMessage(UpdateMessageDto updateMessageDto)
        {
            var value = new Message()
            {
                Id=updateMessageDto.Id,
                Content = updateMessageDto.Content,
                Email = updateMessageDto.Email,
                NameSurname = updateMessageDto.NameSurname,
                Phone = updateMessageDto.Phone,
                SendDate = DateTime.Now,
                Subject = updateMessageDto.Subject,
                Status = false
            };
            _messageService.TUpdate(value);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetMessage(int id)
        {
            return Ok(_messageService.TGetById(id));
        }
    }
}

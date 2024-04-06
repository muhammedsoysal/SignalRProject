using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.NatificationDto;
using SignalR.EntityLayer.Entities;

namespace SignalR.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class NotificationsController : ControllerBase
	{
		private readonly INotificationService _natificationService;

		public NotificationsController(INotificationService natificationService)
		{
			_natificationService = natificationService;
		}
		[HttpGet("NatificationList")]
		public IActionResult NatificationList()
		{
			return Ok(_natificationService.TGetListAll());
		}
		[HttpGet("NotificationCountByStatusFalse")]
		public IActionResult NotificationCountByStatusFalse()
		{
			return Ok(_natificationService.TNotificationCountByStatusFalse());
		}
		[HttpGet("GetAllNotificationsByFalse")]
		public IActionResult GetAllNotificationsByFalse()
		{
			return Ok(_natificationService.TGetAllNotificationsByFalse());
		}

		[HttpPost]
		public IActionResult CreateNatification(CreateNotificationDto createNatificationDto)
		{
			Notification natification = new Notification()
			{
				Date = DateTime.Now,
				Description = createNatificationDto.Description,
				Status = createNatificationDto.Status,
				Type = createNatificationDto.Type,
				Icon = createNatificationDto.Icon,
			};
			_natificationService.TAdd(natification);
			return Ok("Başarılı Bir Şekilde Gönderildi");
		}
		[HttpPut]
		public IActionResult UpdateNatification(UpdateNotificationDto updateNotificationDto)
		{
			Notification natification = new Notification()
			{
				Id = updateNotificationDto.Id,
				Date = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
				Description = updateNotificationDto.Description,
				Status = updateNotificationDto.Status,
				Type = updateNotificationDto.Type,
				Icon = updateNotificationDto.Icon,
			};
			_natificationService.TUpdate(natification);
			return Ok("Başarılı Bir Şekilde Güncellendi");
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteNatification(int id)
		 {
			var value = _natificationService.TGetById(id);
			_natificationService.TDelete(value);
			return Ok("Başarılı Bir Şekilde Silindi");
		}
		[HttpGet("{id}")]
		public IActionResult GetNatification(int id)
		{
			var value = _natificationService.TGetById(id);
			return Ok(value);
		}
		[HttpGet("NotificationStatusChangeToTrue/{id}")]
		public IActionResult NotificationStatusChangeToTrue(int id)
		{
			_natificationService.TNotificationStatusChangeToTrue(id);
			return Ok();
		}
		[HttpGet("NotificationStatusChangeToFalse/{id}")]
		public IActionResult NotificationStatusChangeToFalse(int id)
		{
			_natificationService.TNotificationStatusChangeToFalse(id);
			return Ok();
		}
	}
}

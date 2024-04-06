using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.MenuTableDto;
using SignalR.DtoLayer.NatificationDto;
using SignalR.EntityLayer.Entities;

namespace SignalR.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MenuTablesController : ControllerBase
	{
		private readonly IMenuTableService _menuTableService;
		public MenuTablesController(IMenuTableService menuTableService)
		{
			_menuTableService = menuTableService;
		}
		[HttpGet("MenuTableCount")]
		public IActionResult MenuTableCount()
		{
			return Ok(_menuTableService.TMenuTableCount());
		}
		[HttpGet("MenuTableList")]
		public IActionResult MenuTableList()
		{
			return Ok(_menuTableService.TGetListAll());
		}
		[HttpPost]
		public IActionResult CreateMenuTable(CreateMenuTableDto createMenuTableDto)
		{
			MenuTable menuTable = new()
			{
				Name = createMenuTableDto.Name,
				Status = createMenuTableDto.Status
			};
			_menuTableService.TAdd(menuTable);
			return Ok("Başarılı Bir Şekilde Gönderildi");
		}
		[HttpPut]
		public IActionResult UpdateMenuTable(UpdateMenuTableDto updateMenuTableDto)
		{
			MenuTable menuTable = new()
			{
				Id = updateMenuTableDto.Id,
				Name = updateMenuTableDto.Name,
				Status = updateMenuTableDto.Status,
			};
			_menuTableService.TUpdate(menuTable);
			return Ok("Başarılı Bir Şekilde Güncellendi");
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteMenuTable(int id)
		{
			var value = _menuTableService.TGetById(id);
			_menuTableService.TDelete(value);
			return Ok("Başarılı Bir Şekilde Silindi");
		}
		[HttpGet("{id}")]
		public IActionResult GetMenuTable(int id)
		{
			var value = _menuTableService.TGetById(id);
			return Ok(value);
		}
	}
}

using AutoMapper;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.Entities;

namespace SignalR.API.Mapping
{
	public class AboutMapping : Profile
	{
		public AboutMapping()
		{
			CreateMap<About, CreateAboutDto>().ReverseMap();
			CreateMap<About, GetAboutDto>().ReverseMap();
			CreateMap<About, ResultAboutDto>().ReverseMap();
			CreateMap<About, UpdateAboutDto>().ReverseMap();
		}
	}
}

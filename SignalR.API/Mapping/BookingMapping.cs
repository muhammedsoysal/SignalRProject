﻿using AutoMapper;
using SignalR.DtoLayer.BookingDto;
using SignalR.EntityLayer.Entities;

namespace SignalR.API.Mapping
{
	public class BookingMapping:Profile
	{
		public BookingMapping()
		{
			CreateMap<Booking, CreateBookingDto>().ReverseMap();
			CreateMap<Booking, ResultBookingDto>().ReverseMap();
			CreateMap<Booking, GetBookingDto>().ReverseMap();
			CreateMap<Booking, UpdateBookingDto>().ReverseMap();

		}
	}
}

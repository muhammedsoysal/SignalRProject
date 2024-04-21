using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concrete
{
    public class BookingManager : IBookingService
	{
		private readonly IBookingDal _bookingDal;

		public BookingManager(IBookingDal booking)
		{
			_bookingDal = booking;
		}
		public void TAdd(Booking t)
		{
			_bookingDal.Add(t);
		}

		public void TDelete(Booking t)
		{
			_bookingDal.Delete(t);
		}

		public void TUpdate(Booking t)
		{
			_bookingDal.Update(t);
		}

		public Booking TGetById(int id)
		{
			return _bookingDal.GetById(id);
		}

		public List<Booking> TGetListAll()
		{
			return _bookingDal.GetListAll();
		}

        public void TBookingStatusApproved(int id)
        {
			_bookingDal.BookingStatusApproved(id);
        }

        public void TBookingStatusCancelled(int id)
        {
            _bookingDal.BookingStatusCancelled(id);
        }
    }
}

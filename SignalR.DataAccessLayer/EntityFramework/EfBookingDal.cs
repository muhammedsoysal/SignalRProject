using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(SignalRContext context) : base(context)
        {
        }
        public void BookingStatusApproved(int id)
        {
            using var context = new SignalRContext();
            var value = context.Bookings.Find(id);
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            value.Description = "Rezervasyon Onaylandı";
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            context.SaveChanges();

        }

        public void BookingStatusCancelled(int id)
        {
            using var context = new SignalRContext();
            var value = context.Bookings.Find(id);
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                        value.Description = "Rezervasyon İptal Edildi";
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            context.SaveChanges();
        }
    }
}

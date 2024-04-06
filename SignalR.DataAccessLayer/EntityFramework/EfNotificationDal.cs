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
	public class EfNotificationDal : GenericRepository<Notification>, INotificationDal
	{
		public EfNotificationDal(SignalRContext signalRContext) : base(signalRContext)
		{
		}

		public List<Notification> GetAllNotificationsByFalse()
		{
			using var context = new SignalRContext();
			return context.Notifications.Where(x => x.Status == false).ToList();
		}

		public int NotificationCountByStatusFalse()
		{
			using var context = new SignalRContext();
			return context.Notifications.Where(x => x.Status == false).Count();
		}

		public void NotificationStatusChangeToFalse(int id)
		{
			using var context = new SignalRContext();
			var notification = context.Notifications.Find(id);

			if (notification != null)
			{
				notification.Status = false;
				context.SaveChanges();
			}
		}

		public void NotificationStatusChangeToTrue(int id)
		{
			using var context = new SignalRContext();
			var notification = context.Notifications.Find(id);

			if (notification != null)
			{
				notification.Status = true;
				context.SaveChanges();
			}
		}
	}
}

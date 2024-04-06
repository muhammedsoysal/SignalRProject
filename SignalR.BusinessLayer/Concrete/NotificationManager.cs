using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
	public class NotificationManager : INotificationService
	{
		private readonly INotificationDal _natificationDal;

		public NotificationManager(INotificationDal natificationDal)
		{
			_natificationDal = natificationDal;
		}

		public void TAdd(Notification t)
		{
			_natificationDal.Add(t);
		}

		public void TDelete(Notification t)
		{
			_natificationDal.Delete(t);
		}

		public List<Notification> TGetAllNotificationsByFalse()
		{
			return _natificationDal.GetAllNotificationsByFalse();
		}

		public Notification TGetById(int id)
		{
			return _natificationDal.GetById(id);
		}

		public List<Notification> TGetListAll()
		{
			return _natificationDal.GetListAll();
		}

		public int TNotificationCountByStatusFalse()
		{
			return _natificationDal.NotificationCountByStatusFalse();
		}

		public void TNotificationStatusChangeToFalse(int id)
		{
			_natificationDal.NotificationStatusChangeToFalse(id);
		}

		public void TNotificationStatusChangeToTrue(int id)
		{
			_natificationDal.NotificationStatusChangeToTrue(id);
		}

		public void TUpdate(Notification t)
		{
			_natificationDal.Update(t);
		}
	}
}

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
	public class AboutManager:IAboutService
	{
		private readonly IAboutDal _aboutDal;

		public AboutManager(IAboutDal aboutDal)
		{
			_aboutDal = aboutDal;
		}

		public void TAdd(About t)
		{
			_aboutDal.Add(t);
		}

		public void TDelete(About t)
		{
			_aboutDal.Delete(t);
		}

		public void TUpdate(About t)
		{
			_aboutDal.Update(t);
		}

		public About TGetById(int id)
		{
			return _aboutDal.GetById(id);
		}

		public List<About> TGetListAll()
		{
			return _aboutDal.GetListAll();
		}
	}
}

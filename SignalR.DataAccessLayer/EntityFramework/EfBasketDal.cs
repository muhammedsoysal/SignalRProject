using Microsoft.EntityFrameworkCore;
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
	public class EfBasketDal : GenericRepository<Basket>, IBasketDal
	{
		public EfBasketDal(SignalRContext signalRContext) : base(signalRContext)
		{
		}

		public List<Basket> GetBasketByMenuTableNumber(int tableNumber)
		{
			using var context = new SignalRContext();
			var values = context.Baskets.Where(x => x.MenuTableId == tableNumber).Include(i=>i.Product).ToList();
			return values;
		}
	}
}

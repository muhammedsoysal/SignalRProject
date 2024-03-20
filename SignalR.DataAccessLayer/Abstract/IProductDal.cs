using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract
{
	public interface IProductDal : IGenericDal<Product>
	{
		List<Product> GetProductsWithCategories();
		int ProductCount();
		int ProductCountByCategoryName(string name);
		decimal ProductPriceAvg();
		string ProductNameByMaxPrice();
		string ProductNameByMinPrice();
		decimal ProductAvgPriceByName(string name);
		decimal ProductPriceByName(string name);
	}
}

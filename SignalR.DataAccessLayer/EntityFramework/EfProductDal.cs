using Microsoft.EntityFrameworkCore;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
	public class EfProductDal : GenericRepository<Product>, IProductDal
	{
		public EfProductDal(SignalRContext signalRContext) : base(signalRContext)
		{
		}

		public List<Product> GetProductsWithCategories()
		{
			var context = new SignalRContext();
			var values = context.Products.Include(x => x.Category).ToList();
			return values;
		}

		public int ProductCount()
		{
			using var context = new SignalRContext();
			return context.Products.Count();
		}

		public int ProductCountByCategoryName(string name)
		{
			using var context = new SignalRContext();
			return context.Products.Where(x => x.CategoryId == (context.Categories
				.Where(y => y.CategoryName == name).Select(z => z.CategoryId).FirstOrDefault())).Count();
		}

		public decimal ProductPriceAvg()
		{
			using var context = new SignalRContext();
			return context.Products.Average(x => x.Price);
		}

		public string ProductNameByMaxPrice()
		{
			using var context = new SignalRContext();
#pragma warning disable CS8603 // Possible null reference return.
			return context.Products.Where(x => x.Price == (context.Products.Max(y => y.Price)))
				.Select(z => z.ProductName).FirstOrDefault();
#pragma warning restore CS8603 // Possible null reference return.
		}

		public string ProductNameByMinPrice()
		{
			using var context = new SignalRContext();
#pragma warning disable CS8603 // Possible null reference return.
			return context.Products.Where(x => x.Price == (context.Products.Min(y => y.Price)))
				.Select(z => z.ProductName).FirstOrDefault();
#pragma warning restore CS8603 // Possible null reference return.
		}

		public decimal ProductAvgPriceByName(string name)
		{
			using var context = new SignalRContext();
			return context.Products.Where(x => x.CategoryId == (context.Categories.Where(y => y.CategoryName == name)
				.Select(z => z.CategoryId).FirstOrDefault())).Average(w => w.Price);
		}

		public decimal ProductPriceByName(string name)
		{
			using (var context = new SignalRContext())
			{
				var product = context.Products.FirstOrDefault(x => x.ProductName == name);
				if (product != null)
				{
					return product.Price;
				}
				else
					throw new InvalidOperationException("Ürün bulunamadı.");


			}
		}
	}
}

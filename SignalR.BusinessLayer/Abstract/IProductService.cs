using SignalR.EntityLayer.Entities;


namespace SignalR.BusinessLayer.Abstract
{
    public interface IProductService:IGenericService<Product>
    {
	    public List<Product> TGetProductsWithCategories();
        int TProductCount();
        int TProductCountByCategoryName(string name);
        decimal TProductPriceAvg();
        string TProductNameByMaxPrice();
        string TProductNameByMinPrice();
        decimal TProductAvgPriceByName(string name);
        decimal TProductPriceByName(string name);
	}
}

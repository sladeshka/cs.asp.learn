using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCoreProduct.Model;

namespace WebAppCoreProduct.Pages
{
    public class ProductModel : PageModel
    {
		public Product? Product { get; set; }
		public string? Message { get; set; }

		public void OnGet(string name, decimal? price)
		{
			Message = "Для товара можно определить скидку";
		}

		public void OnPostWithPoints(string name, decimal? price)
		{
			if (price == null || price < 0 || string.IsNullOrEmpty(name))
			{
				Message = "Переданы не корректные данные. Повторите ввод";
				return;
			}
			Product = new Product();
			Product.Price = price;
			Product.Name = name;
			Product.Points = 100;
			Message = Product.ToString();
		}
		public void OnPostWithDiscount(string name, decimal? price, double discount) {
			if (price == null || price < 0 || string.IsNullOrEmpty(name))
			{
				Message = "Переданы не корректные данные. Повторите ввод";
				return;
			}
			Product = new Product();
            Product.Price = price;
            Product.Name = name;
            Product.Discount = discount;
            Message = Product.ToString();
        }
	}
}

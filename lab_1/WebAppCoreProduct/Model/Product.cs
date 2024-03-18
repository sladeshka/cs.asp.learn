namespace WebAppCoreProduct.Model
{
	public class Product
	{
		public string? Name { get; set; }
		public decimal? Price { get; set; }
        public double? Discount { get; set; }
        public double? Points { get; set; }

        private decimal? result => (Price + (Price * (decimal?)0.18) );

        public override string ToString() {
			string str = "";
			if(Name != null)
			{
                str += $"Для товара {Name}, ";

            }
            if (Price != null)
            {
                str += $"с ценой {result} ( в том числе НДС {result - Price}) ";

            }
            if (Discount != null && Points == null)
            {
				str += $"и скидкой {Discount} % {result - (result * ((decimal)Discount / 100))} ";

            } else
			{
				str += $"получится {result}";
			}
			if (Points != null)
			{
				str += $" и {Points} баллов";
			}
			return str;
		}
	}
}

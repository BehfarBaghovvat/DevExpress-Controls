namespace Models
{
	public class Producte : BaseEntity
	{
		public Producte()
		{

		}

		public string Product_Name { get; set; }

		public int Quantity { get; set; }

		public decimal Price { get; set; }

		public System.DateTime DateTime_Register { get; set; }

		public bool Entity_Status { get; set; }

		public bool Is_Active { get; set; }
	}
}

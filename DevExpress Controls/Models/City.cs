namespace Models
{
	public class City
	{
		public City()
		{

		}

		[System.ComponentModel.DataAnnotations.Key]
		public int City_Id { get; set; }
		public string City_Name { get; set; }

		public string State_Name { get; set; }
	}
}

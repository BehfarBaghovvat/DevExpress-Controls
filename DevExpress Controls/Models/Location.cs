namespace Models
{
	public class Location
	{
		public Location()
		{

		}

		[System.ComponentModel.DataAnnotations.Key]
		public int Id { get; set; }

		public string Country_Name { get; set; }

		public string State_Name { get; set; }

		public string City_Name { get; set; }

		public string Area_Name { get; set; }
	}
}

namespace Models
{
	public class Area 
	{
		public Area()
		{

		}

		[System.ComponentModel.DataAnnotations.Key]
		public int Area_Id { get; set; }

		public string Area_Name { get; set; }

		public string City_Name { get; set; }
	}
}

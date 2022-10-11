namespace Models
{
	public class Country
	{
		public Country()
		{

		}

		[System.ComponentModel.DataAnnotations.Key]
		public int Country_Id { get; set; }

		public string Country_Name { get; set; }


	}
}

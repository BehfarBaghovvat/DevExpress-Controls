namespace Models
{
	public class Region
	{
		public Region()
		{

		}

		[System.ComponentModel.DataAnnotations.Key]
		public int Region_Id { get; set; }

		public string Region_Name { get; set; }

	}
}

namespace Models
{
	public class State
	{
		public State()
		{

		}

		[System.ComponentModel.DataAnnotations.Key]
		public int State_Id { get; set; }

		public string State_Name { get; set; }

		public string Country_Name { get; set; }
	}
}

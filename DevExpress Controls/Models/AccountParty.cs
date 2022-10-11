namespace Models
{
	/// <summary>
	/// طرف حساب
	/// </summary>
	public class AccountParty
	{

		public enum AccountType
		{
			فروشنده,
			خریدار,
		}
		public AccountParty()
		{

		}

		[System.ComponentModel.DataAnnotations.Key]
		public int Id { get; set; }

		public string FullName { get; set; }

		public AccountType Account_Type { get; set; }

		public int Phone { get; set; }

		public int Mobile { get; set; }

		public string Address { get; set; }



	}
}



namespace Models
{
	public class BaseEntity : System.Object
	{
		public BaseEntity()
		{
			Id = System.Guid.NewGuid();
		}

		public System.Guid Id { get; set; }
	}
}

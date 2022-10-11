namespace Models
{
	public class DataBaseContext : System.Data.Entity.DbContext
	{
		static DataBaseContext()
		{
			System.Data.Entity.Database.SetInitializer
				(new System.Data.Entity.DropCreateDatabaseIfModelChanges<DataBaseContext>());
		}

		public DataBaseContext() : base()
		{

		}

		//public System.Data.Entity.DbSet<> {get; set;}

		public System.Data.Entity.DbSet<AccountParty> AccountParties { get; set; }

		public System.Data.Entity.DbSet<Area> Areas {get; set;}

		public System.Data.Entity.DbSet<City> Cities { get; set; }

		public System.Data.Entity.DbSet<Country> Countries { get; set; }

		public System.Data.Entity.DbSet<Location> Locations { get; set; }

		public System.Data.Entity.DbSet<Producte> Productes { get; set; }

		public System.Data.Entity.DbSet<Region> Regions { get; set; }

		public System.Data.Entity.DbSet<State> States { get; set; }
	}
}

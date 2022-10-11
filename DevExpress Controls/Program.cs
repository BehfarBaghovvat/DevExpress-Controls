
using System.Linq;

namespace DevExpress_Controls
{
	static class Program
	{
		static string[] _region = new string[4] { "کشور", "استان", "شهرستان", "منطقه" };

		private static void SetData()
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				string _countryName = _region[0];


				Models.Region region =
					dataBaseContext.Regions
					.Where(current => string.Compare(current.Region_Name, _countryName) == 0)
					.FirstOrDefault();

				if (region != null)
				{
					return;
				}
				else
				{
					region =
						new Models.Region();
					for (int i = 0; i < _region.Length; i++)
					{
						region.Region_Name = _region[i];

						dataBaseContext.Regions.Add(region);
						dataBaseContext.SaveChanges();
					}
				}

				
			}
			catch(System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				dataBaseContext.Dispose();
				dataBaseContext = null;
			}


		}


		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[System.STAThread]
		static void Main()
		{
			System.Windows.Forms.Application.EnableVisualStyles();
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
			SetData();
			System.Windows.Forms.Application.Run(new MainForm());
		}
	}
}

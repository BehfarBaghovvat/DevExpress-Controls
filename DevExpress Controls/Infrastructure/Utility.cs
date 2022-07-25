namespace Infrastructure
{
	public static class Utility
	{
		private static int _index;





		public static string CapacityVariables1()
		{
			string showVariables = $"byte MaxValue: { byte.MaxValue} \n" +
				$"byte MinValue: {byte.MinValue} \n" +
				$"sbyte MaxValue: {sbyte.MaxValue} \n" +
				$"sbyte MinValue: {sbyte.MinValue} \n" +
				$"decimal MaxValue: {decimal.MaxValue} \n" +
				$"decimal MinValue: {decimal.MinValue} \n" +
				$"double MaxValue: {double.MaxValue} \n" +
				$"double MinValue: {double.MinValue} \n" +
				$"float MaxValue: {float.MaxValue} \n" +
				$"float MinValue: {float.MinValue} \n" +
				$"int MaxValue: {int.MaxValue} \n" +
				$"int MinValue: {int.MinValue} \n" +
				$"uint MaxValue: {uint.MaxValue} \n" +
				$"uint MinValue: {uint.MinValue} \n" +
				$"long MaxValue: {long.MaxValue} \n" +
				$"long MinValue: {long.MinValue} \n" +
				$"ulong MaxValue: {ulong.MaxValue} \n" +
				$"ulong MinValue: {ulong.MinValue} \n" +
				$"short MaxValue: {short.MaxValue} \n" +
				$"short MinValue: {short.MinValue} \n";

			return showVariables;
		}

		public static void CapacityVariables2()
		{
			System.Windows.Forms.MessageBox.Show(
			$"byte MaxValue: { byte.MaxValue} \n" +
			$"byte MinValue: {byte.MinValue} \n" +
			$"sbyte MaxValue: {sbyte.MaxValue} \n" +
			$"sbyte MinValue: {sbyte.MinValue} \n" +
			$"decimal MaxValue: {decimal.MaxValue} \n" +
			$"decimal MinValue: {decimal.MinValue} \n" +
			$"double MaxValue: {double.MaxValue} \n" +
			$"double MinValue: {double.MinValue} \n" +
			$"float MaxValue: {float.MaxValue} \n" +
			$"float MinValue: {float.MinValue} \n" +
			$"int MaxValue: {int.MaxValue} \n" +
			$"int MinValue: {int.MinValue} \n" +
			$"uint MaxValue: {uint.MaxValue} \n" +
			$"uint MinValue: {uint.MinValue} \n" +
			$"long MaxValue: {long.MaxValue} \n" +
			$"long MinValue: {long.MinValue} \n" +
			$"ulong MaxValue: {ulong.MaxValue} \n" +
			$"ulong MinValue: {ulong.MinValue} \n" +
			$"short MaxValue: {short.MaxValue} \n" +
			$"short MinValue: {short.MinValue} \n");
		}


		#region ADCalendar
		/// <summary>
		/// AD calendar with month names...
		/// </summary>
		/// <returns></returns>
		public static string ADCalendar()
		{
			string adCalendar;
			string nameMonth = string.Empty;

			System.Globalization.GregorianCalendar gregorianCalendar =
				new System.Globalization.GregorianCalendar();

			int years = gregorianCalendar.GetYear(System.DateTime.Now);
			int months = gregorianCalendar.GetMonth(System.DateTime.Now);
			int day = gregorianCalendar.GetDayOfMonth(System.DateTime.Now);

			switch (months)
			{
				case 1:
					nameMonth = "January";
					break;
				case 2:
					nameMonth = "February";
					break;
				case 3:
					nameMonth = "March";
					break;
				case 4:
					nameMonth = "April";
					break;
				case 5:
					nameMonth = "May";
					break;
				case 6:
					nameMonth = "June";
					break;
				case 7:
					nameMonth = "Julay";
					break;
				case 8:
					nameMonth = "August";
					break;
				case 9:
					nameMonth = "September";
					break;
				case 10:
					nameMonth = "October";
					break;
				case 11:
					nameMonth = "November";
					break;
				case 12:
					nameMonth = "Decemder";
					break;

				default:
					break;
			}

			adCalendar =
				nameMonth + " / " +
				day.ToString().PadLeft(2, '0') + " / " +
				years.ToString();

			return adCalendar;

		}

		#endregion /ADCalendar

		#region ADCalendar
		/// <summary>
		/// This function has an input value that is the date of your device's system.
		/// So try to keep your system up to date.
		/// </summary>
		/// <param name="dateTime"></param>
		/// <returns>Gregorian date</returns>
		public static string ADCalendar(System.DateTime dateTime)
		{
			string adCalendar;

			System.Globalization.GregorianCalendar gregorianCalendar =
				new System.Globalization.GregorianCalendar();

			int years = gregorianCalendar.GetYear(dateTime);
			int months = gregorianCalendar.GetMonth(dateTime);
			int day = gregorianCalendar.GetDayOfMonth(dateTime);

			adCalendar =
				months.ToString().PadLeft(2, '0') + " / " +
				day.ToString().PadLeft(2, '0') + " / " +
				years.ToString();

			return adCalendar;

		}
		#endregion /ADCalendar

		#region ApplictionExit
		public static void ApplictionExit()
		{
			System.Windows.Forms.Application.Exit();
		}
		#endregion /ApplictionExit

		#region ColumnDigitizer
		/// <summary>
		/// جدا کننده ارقام ستون یک جدول
		/// </summary>
		/// <param name="listViewControl"></param>
		/// <param name="indexSubItem"></param>
		private static void ColumnDigitizer(System.Windows.Forms.ListView listViewControl, int indexSubItem)
		{
			decimal sepatatorNumber;
			foreach (System.Windows.Forms.ListViewItem item in listViewControl.Items)
			{
				sepatatorNumber = decimal.Parse(item.SubItems[indexSubItem].Text);

				item.SubItems[indexSubItem].Text = $"{sepatatorNumber:#,0}";
			}
		}
		#endregion /ColumnDigitizer

		#region ColumnDigitizerByNameColumn
		/// <summary>
		/// جدا کننده ارقام بر اساس دریافت نام ستون
		/// </summary>
		/// <param name="listViewControl"></param>
		/// <param name="nameColumn"></param>
		private static void ColumnDigitizerByNameColumn(System.Windows.Forms.ListView listViewControl, string nameColumn)
		{
			decimal sepatatorNumber;
			bool statusSearch = false;
			if (string.IsNullOrWhiteSpace(nameColumn))
			{
				return;
			}
			else
			{
				for (int i = 0; i < listViewControl.Columns.Count; i++)
				{
					if (string.Compare(listViewControl.Columns[i].Text, nameColumn) != 0)
					{
						statusSearch = false;
					}
					else
					{
						statusSearch = true;
						_index = i;
						break;
					}
				}
			}

			if (statusSearch)
			{
				foreach (System.Windows.Forms.ListViewItem item in listViewControl.Items)
				{
					sepatatorNumber = decimal.Parse(item.SubItems[_index].Text);

					item.SubItems[_index].Text = $"{sepatatorNumber:#,0}";
				}
			}
			else
			{
				System.Windows.Forms.MessageBox.Show($"{nameColumn} در جدول وجود ندارد", "خطا", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
			}
		}
		#endregion /ColumnDigitizerByNameColumn

		#region EnglishAndNumberTyping
		/// <summary>
		/// It is a function that allows only English and numeric characters to be typed while typing.
		/// </summary>
		/// <param name="e"></param>
		public static void EnglishAndNumberTyping(System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar > 'آ' && e.KeyChar <= 'ی'))
			{
				e.Handled = true;
			}
		}
		#endregion EnglishAndNumberTyping

		#region EnglishTyping
		/// <summary>
		/// A function used to type English
		/// </summary>
		/// <param name="e"></param>
		public static void EnglishTyping(System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar > 'آ' && e.KeyChar <= 'ی') || (e.KeyChar >= '0' && e.KeyChar <= '9'))
			{
				e.Handled = true;
			}
		}
		#endregion /EnglishTyping

		#region EnglishLanguage
		/// <summary>
		/// Function to change Persian to English
		/// </summary>
		public static void EnglishLanguage()
		{
			System.Threading.Thread.CurrentThread.CurrentCulture =
				new System.Globalization.CultureInfo("en-us");

			System.Threading.Thread.CurrentThread.CurrentUICulture =
				System.Threading.Thread.CurrentThread.CurrentCulture;

			System.Windows.Forms.InputLanguage.CurrentInputLanguage =
				System.Windows.Forms.InputLanguage.FromCulture(new System.Globalization.CultureInfo("en-us"));
		}
		#endregion /EnglishLanguage

		#region GetSerialNumber
		/// <summary>
		/// تابعی که به تعداد 7 کاراکتر حروف و عدد به صورت تصادوفی
		///  و ترکیبی ایجاد کرده و به ما بر میگرداند.
		/// </summary>
		/// <param name="numberSection"></param>
		/// <returns>ممبر letter که حاصل دریافت ترکیبی عدد و حرف میباشد نتیجه این تابع میباشد. </returns>
		public static string GetSerialNumber(int numberSection)
		{
			int count, number1, number2;

			string[] text = new string[3];
			string letter = string.Empty;

			System.Random randomCount = new System.Random();
			System.Random randomNumber = new System.Random();
			System.Random random = new System.Random();
			if (numberSection == 1)
			{
				for (int i = 1; i <= 5; i++)
				{
					count = randomCount.Next(0, 2);

					if (count == 0)
					{
						number1 = randomNumber.Next(0, 10);
						letter += number1.ToString();
					}
					else if (count == 1)
					{
						for (int k = 0; k < 1; k++)
						{
							number2 = random.Next(65, 91);
							text[k] = System.Convert.ToChar(number2).ToString();
							letter += text[k];
						}
					}
				}

				for (int i = 1; i < 6; i++)
				{
					if (i % 6 == 0)
					{
						letter = letter.Insert(i - 1, "-");
					}
				}
			}

			else if (numberSection == 2)
			{
				for (int i = 1; i <= 10; i++)
				{
					count = randomCount.Next(0, 2);

					if (count == 0)
					{
						number1 = randomNumber.Next(0, 10);
						letter += number1.ToString();
					}
					else if (count == 1)
					{
						for (int k = 0; k < 1; k++)
						{
							number2 = random.Next(65, 91);
							text[k] = System.Convert.ToChar(number2).ToString();
							letter += text[k];
						}
					}
				}

				for (int i = 1; i < 11; i++)
				{
					if (i % 6 == 0)
					{
						letter = letter.Insert(i - 1, "-");
					}
				}
			}

			else if (numberSection == 3)
			{
				for (int i = 1; i <= 15; i++)
				{
					count = randomCount.Next(0, 2);

					if (count == 0)
					{
						number1 = randomNumber.Next(0, 10);
						letter += number1.ToString();
					}
					else if (count == 1)
					{
						for (int k = 0; k < 1; k++)
						{
							number2 = random.Next(65, 91);
							text[k] = System.Convert.ToChar(number2).ToString();
							letter += text[k];
						}
					}
				}

				for (int i = 1; i < 16; i++)
				{
					if (i % 6 == 0)
					{
						letter = letter.Insert(i - 1, "-");
					}
				}
			}

			else if (numberSection == 4)
			{
				for (int i = 1; i <= 20; i++)
				{
					count = randomCount.Next(0, 2);

					if (count == 0)
					{
						number1 = randomNumber.Next(0, 10);
						letter += number1.ToString();
					}
					else if (count == 1)
					{
						for (int k = 0; k < 1; k++)
						{
							number2 = random.Next(65, 91);
							text[k] = System.Convert.ToChar(number2).ToString();
							letter += text[k];
						}
					}
				}

				for (int i = 1; i < 21; i++)
				{
					if (i % 6 == 0)
					{
						letter = letter.Insert(i - 1, "-");
					}
				}
			}

			else if (numberSection >= 5)
			{
				letter = string.Empty;
			}
			return letter;
		}
		#endregion /GetSerialNumber

		#region InsertOnlyNumber
		/// <summary>
		/// A function used to type a Number
		/// </summary>
		/// <param name="e"></param>
		public static void InsertOnlyNumber(System.Windows.Forms.KeyPressEventArgs e)
		{
			if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
			{
				e.Handled = true;
			}
		}
		#endregion /InsertOnlyNumber

		#region PersianAndNumberTyping
		/// <summary>
		/// A function used to type Farsi
		/// </summary>
		/// <param name="e"></param>
		public static void PersianAndNumberTyping(System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar > 'a' && e.KeyChar <= 'z') || (e.KeyChar > 'A' && e.KeyChar <= 'Z'))
			{
				e.Handled = true;
			}
		}
		#endregion /PersianAndNumberTyping

		#region PersianCalendar
		/// <summary>
		/// View Persian calendar with month names.
		/// </summary>
		/// <returns></returns>
		public static string PersianCalendar()
		{
			string farsiCalendar;
			string nameMonth = string.Empty;

			System.Globalization.PersianCalendar persianCalendar =
				new System.Globalization.PersianCalendar();

			int years = persianCalendar.GetYear(System.DateTime.Now);
			int month = persianCalendar.GetMonth(System.DateTime.Now);
			int day = persianCalendar.GetDayOfMonth(System.DateTime.Now);

			switch (month)
			{
				case 1:
					nameMonth = "فروردین";
					break;
				case 2:
					nameMonth = "اردیبهشت";
					break;
				case 3:
					nameMonth = "خرداد";
					break;
				case 4:
					nameMonth = "تیر";
					break;
				case 5:
					nameMonth = "مرداد";
					break;
				case 6:
					nameMonth = "شهریور";
					break;
				case 7:
					nameMonth = "مهر";
					break;
				case 8:
					nameMonth = "آبان";
					break;
				case 9:
					nameMonth = "آذر";
					break;
				case 10:
					nameMonth = "دی";
					break;
				case 11:
					nameMonth = "بهمن";
					break;
				case 12:
					nameMonth = "اسفند";
					break;

				default:
					break;
			}

			farsiCalendar =
				day.ToString().PadLeft(2, '0') + " / " + nameMonth + " / " + years.ToString();

			return farsiCalendar;
		}
		#endregion /PersianCalendar

		#region PersianCalendar
		/// <summary>
		/// View Persian Calendar.
		/// </summary>
		/// <param name="dateTime">Calendar entry</param>
		/// <returns></returns>
		public static string PersianCalendar(System.DateTime dateTime)
		{
			System.Globalization.PersianCalendar persianCalendar =
				new System.Globalization.PersianCalendar();

			int year = persianCalendar.GetYear(dateTime);
			int month = persianCalendar.GetMonth(dateTime);
			int day = persianCalendar.GetDayOfMonth(dateTime);

			string showCalendar =
				year.ToString() + "/" +
				month.ToString().PadLeft(2, '0') + "/" +
				day.ToString().PadLeft(2, '0');

			return showCalendar;
		}
		#endregion / PersianCalendar

		#region PersianLanguage
		/// <summary>
		/// Function to change English to Persian
		/// </summary>
		public static void PersianLanguage()
		{
			System.Threading.Thread.CurrentThread.CurrentCulture =
				new System.Globalization.CultureInfo("fa-ir");

			System.Threading.Thread.CurrentThread.CurrentUICulture =
				System.Threading.Thread.CurrentThread.CurrentCulture;

			System.Windows.Forms.InputLanguage.CurrentInputLanguage =
				System.Windows.Forms.InputLanguage.FromCulture(new System.Globalization.CultureInfo("fa-ir"));
		}
		#endregion /PersianLanguage

		#region PersianTyping
		/// <summary>
		/// A function used to type Farsi
		/// </summary>
		/// <param name="e"></param>
		public static void PersianTyping(System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar > 'a' && e.KeyChar <= 'z') || (e.KeyChar > 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '9'))
			{
				e.Handled = true;
			}
		}
		#endregion /PersianTyping

		#region ShowTime
		/// <summary>
		/// A function that displays the clock.
		/// </summary>
		/// <returns>The device's system clock output</returns>
		public static string ShowTime()
		{
			string timeNow =
				System.DateTime.Now.TimeOfDay.ToString().Substring(0, 8);

			return timeNow;
		}
		#endregion /ShowTime

		#region ShowTime
		/// <summary>
		/// Function for displaying time with display format.
		/// </summary>
		/// <returns>The device's system clock output</returns>
		public static string ShowTime(string format)
		{
			string timeNow =
				System.DateTime.Now.ToString(format);

			return timeNow;
		}
		#endregion /ShowTime
		
	}
}

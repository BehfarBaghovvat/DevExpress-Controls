

using System;
using System.Linq;

namespace User_Control
{
	public partial class addRegionUC : System.Windows.Forms.UserControl
	{

		//--------------Properties, Field

		private string _inputValue = null;

		private Models.DataBaseContext dataBaseContext = null;



		public System.Drawing.Color BackColorCaption
		{
			get
			{
				return captionPanel.BackColor;
			}
			set
			{
				captionPanel.BackColor = value;
			}
		}

		private int _regionID = 0;
		public int RegionID
		{
			get
			{
				return _regionID;
			}
			set
			{
				_regionID = value;
			}
		}




		public addRegionUC()
		{
			InitializeComponent();
		}

		private void InputTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}

		private void InputTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}

		private void InputTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(inputTextBox.Text))
			{
				_inputValue = null;
			}
			else
			{
				_inputValue = inputTextBox.Text.Trim();
			}
		}

		private void SaveButton_Click(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(_inputValue))
			{
				System.Windows.Forms.MessageBox.Show($"لطفا نام {captionLabel.Text} وارد نمایید.");
				inputTextBox.Focus();
			}
			else
			{
				SetRegion(_inputValue);
			}
		}


		//-------------------Private Methods

		private void SetRegion(string inputValue)
		{
			int count = 0;

			dataBaseContext =
				new Models.DataBaseContext();

			if (_regionID == 1)
			{
				System.Collections.Generic.List<Models.Country> listCountries = null;

				listCountries =
					dataBaseContext.Countries
					.OrderBy(current => current.Country_Id)
					.ToList();

				count = listCountries.Count();

				Models.Country country =
					dataBaseContext.Countries
					.Where(current => string.Compare(current.Country_Name, inputValue) == 0)
					.FirstOrDefault();

				if (country != null)
				{
					System.Windows.Forms.MessageBox.Show($"نام {inputValue} در لیست کشور ها موجود است");
					inputTextBox.Focus();
					return;
				}
				else
				{
					country =
						new Models.Country
						{
							Country_Id = count + 1,
							Country_Name = inputValue,
						};

					dataBaseContext.Countries.Add(country);
					dataBaseContext.SaveChanges();

					System.Windows.Forms.MessageBox.Show($"نام {inputValue} ثبت گردید.");

					RefreshData();

					inputTextBox.ResetText();
				}
			}
			else if (_regionID == 2)
			{
				System.Collections.Generic.List<Models.State> listState = null;

				listState =
					dataBaseContext.States
					.OrderBy(current => current.State_Id)
					.ToList();

				count = listState.Count();

				Models.State state =
					dataBaseContext.States
					.Where(current => string.Compare(current.State_Name, inputValue) == 0)
					.FirstOrDefault();

				if (state != null)
				{
					System.Windows.Forms.MessageBox.Show($"نام {inputValue} در لیست کشور ها موجود است");
					inputTextBox.Focus();
					return;
				}
				else
				{
					state =
						new Models.State
						{
							State_Id = count + 1,
							State_Name = inputValue,
						};

					dataBaseContext.States.Add(state);
					dataBaseContext.SaveChanges();

					System.Windows.Forms.MessageBox.Show($"نام {inputValue} ثبت گردید.");

					RefreshData();

					inputTextBox.ResetText();
				}
			}
			else if (_regionID == 3)
			{
				System.Collections.Generic.List<Models.City> listCities = null;

				listCities =
					dataBaseContext.Cities
					.OrderBy(current => current.City_Id)
					.ToList();

				count = listCities.Count();

				Models.City city =
					dataBaseContext.Cities
					.Where(current => string.Compare(current.City_Name, inputValue) == 0)
					.FirstOrDefault();

				if (city != null)
				{
					System.Windows.Forms.MessageBox.Show($"نام {inputValue} در لیست کشور ها موجود است");
					inputTextBox.Focus();
					return;
				}
				else
				{
					city =
						new Models.City
						{
							City_Id = count + 1,
							City_Name = inputValue,
						};

					dataBaseContext.Cities.Add(city);
					dataBaseContext.SaveChanges();

					System.Windows.Forms.MessageBox.Show($"نام {inputValue} ثبت گردید.");

					RefreshData();

					inputTextBox.ResetText();
				}
			}
			else if (_regionID == 4)
			{
				System.Collections.Generic.List<Models.Area> listAreas = null;

				listAreas =
					dataBaseContext.Areas
					.OrderBy(current => current.Area_Id)
					.ToList();

				count = listAreas.Count();

				Models.Area area =
					dataBaseContext.Areas
					.Where(current => string.Compare(current.Area_Name, inputValue) == 0)
					.FirstOrDefault();

				if (area != null)
				{
					System.Windows.Forms.MessageBox.Show($"نام {inputValue} در لیست کشور ها موجود است");
					inputTextBox.Focus();
					return;
				}
				else
				{
					area =
						new Models.Area
						{
							Area_Id = count + 1,
							Area_Name = inputValue,
						};

					dataBaseContext.Areas.Add(area);
					dataBaseContext.SaveChanges();

					System.Windows.Forms.MessageBox.Show($"نام {inputValue} ثبت گردید.");

					RefreshData();

					inputTextBox.ResetText();
				}
			}
			else
			{
				System.Windows.Forms.MessageBox.Show($"شناسه درج شده در سیستم موجود نمیباشد.");
			}
		}

		public void RefreshData()
		{
			dataBaseContext =
				new Models.DataBaseContext();

			if (_regionID == 1)
			{
				System.Collections.Generic.List<Models.Country> listCountries = null;

				listCountries =
					dataBaseContext.Countries
					.OrderBy(current => current.Country_Id)
					.ToList();

				regionNameCheckedListBoxControl.DataSource = listCountries;

				regionNameCheckedListBoxControl.ValueMember = "Country_Id";
				regionNameCheckedListBoxControl.DisplayMember = "Country_Name";


			}
			else if (_regionID == 2)
			{
				System.Collections.Generic.List<Models.State> listStates = null;

				listStates =
					dataBaseContext.States
					.OrderBy(current => current.State_Id)
					.ToList();

				regionNameCheckedListBoxControl.DataSource = listStates;

				regionNameCheckedListBoxControl.ValueMember = "State_Id";
				regionNameCheckedListBoxControl.DisplayMember = "State_Name";
			}
			else if (_regionID == 3)
			{
				System.Collections.Generic.List<Models.City> listSities = null;

				listSities =
					dataBaseContext.Cities
					.OrderBy(current => current.City_Id)
					.ToList();

				regionNameCheckedListBoxControl.DataSource = listSities;

				regionNameCheckedListBoxControl.ValueMember = "City_Id";
				regionNameCheckedListBoxControl.DisplayMember = "City_Name";
			}
			else if (_regionID == 4)
			{
				System.Collections.Generic.List<Models.Area> listAreas = null;

				listAreas =
					dataBaseContext.Areas
					.OrderBy(current => current.Area_Id)
					.ToList();

				regionNameCheckedListBoxControl.DataSource = listAreas;

				regionNameCheckedListBoxControl.ValueMember = "Area_Id";
				regionNameCheckedListBoxControl.DisplayMember = "Area_Name";
			}
			else
			{
				return;
			}
		}
	}
}

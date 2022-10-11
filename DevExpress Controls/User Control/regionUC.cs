using System;
using System.Linq;

namespace User_Control
{
	public partial class RegionUC : System.Windows.Forms.UserControl
	{

		//--------------Properties, Field

		private bool _upDateMode = false;
		private string _selectValueName = null;

		public class My_Region
		{
			public int Region_Id { get; set; }

			public string Region_Name { get; set; }
		}

		private string _inputValue;
		public string InputValue 
		{ 
			get
			{
				return _inputValue;
			}
			set
			{
				_inputValue = value;
			}
		}

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

		private My_Region _myRegion = null;
		public My_Region MyRegion
		{
			get
			{
				if (_myRegion == null)
				{
					_myRegion =
						new My_Region();
				}

				return _myRegion;
			}

			set
			{
				_myRegion = value;
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

		private string _oldVlaue;
		public string OldValue 
		{ 
			get
			{
				return _oldVlaue;
			}
			set
			{
				_oldVlaue = value;
			}
		}

		public RegionUC()
		{
			InitializeComponent();
		}

		public event System.EventHandler SelectItem;

		private void SearchButton_Click(object sender, System.EventArgs e)
		{
			SearchItem(MyRegion);
		}

		private void SearchButton_DoubleClick(object sender, System.EventArgs e)
		{
			RefreshData();
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
				InputValue = null;
			}
			else
			{
				InputValue = inputTextBox.Text.Trim();
			}
		}

		private void SaveButton_Click(object sender, System.EventArgs e)
		{
			if (_upDateMode)
			{
				UpdateRegion(_inputValue, _oldVlaue, MyRegion);
			}
			else
			{
				if (string.IsNullOrWhiteSpace(_inputValue))
				{
					System.Windows.Forms.MessageBox.Show($"لطفا نام {captionLabel.Text} وارد نمایید.");
					inputTextBox.Focus();
				}
				else
				{
					if (RegionID == 1)
					{
						SetRegion(_inputValue);
					}
					else if (RegionID > 1)
					{
						SetRegion(_inputValue, MyRegion);
					}
				}
			}
		}

		private void RegionNameCheckedListBoxControl_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
		{
			if (SelectItem != null)
			{
				SelectItem.Invoke(sender, e);
			}

			if (regionNameCheckedListBoxControl.CheckedItemsCount == 0)
			{
				_upDateMode = false;

				_selectValueName = null;

				MyRegion.Region_Name = null;
			}
			else
			{
				_upDateMode = true;

				_selectValueName = GetSelectItemValue();

				MyRegion.Region_Name = GetSelectItemValue();
				//MyRegion.Region_Id = this.RegionID;
			}
		}

		private void DeleteItemToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			DeleteItem(_selectValueName);
		}

		private void DeleteItem(string selectValueName)
		{
			dataBaseContext =
				new Models.DataBaseContext();

			if (RegionID == 1)
			{
				try
				{
					Models.Country country
								= dataBaseContext.Countries
								.Where(current => string.Compare(current.Country_Name, selectValueName) == 0)
								.FirstOrDefault();

					if (country != null)
					{
						var entry = dataBaseContext.Entry(country);

						if (entry.State == System.Data.Entity.EntityState.Detached)
						{
							dataBaseContext.Countries.Attach(country);
						}

						dataBaseContext.Countries.Remove(country);
						dataBaseContext.SaveChanges();

						System.Windows.Forms.MessageBox.Show($"{selectValueName} حذف شد!");
					}
				}
				catch (	System.Exception ex)
				{
					System.Windows.Forms.MessageBox.Show(ex.Message);
				}
			}
			else if (RegionID == 2)
			{
				Models.State state
								= dataBaseContext.States
								.Where(current => string.Compare(current.State_Name, selectValueName) == 0)
								.FirstOrDefault();

				if (state != null)
				{
					var entry = dataBaseContext.Entry(state);

					if (entry.State == System.Data.Entity.EntityState.Detached)
					{
						dataBaseContext.States.Attach(state);
					}

					dataBaseContext.States.Remove(state);
					dataBaseContext.SaveChanges();

					System.Windows.Forms.MessageBox.Show($"{selectValueName} حذف شد!");
				}
			}
			else if (RegionID == 3)
			{
				Models.City city
								= dataBaseContext.Cities
								.Where(current => string.Compare(current.City_Name, selectValueName) == 0)
								.FirstOrDefault();

				if (city != null)
				{
					var entry = dataBaseContext.Entry(city);

					if (entry.State == System.Data.Entity.EntityState.Detached)
					{
						dataBaseContext.Cities.Attach(city);
					}

					dataBaseContext.Cities.Remove(city);
					dataBaseContext.SaveChanges();

					System.Windows.Forms.MessageBox.Show($"{selectValueName} حذف شد!");
				}
			}
			else if (RegionID == 4)
			{
				Models.Area area
								= dataBaseContext.Areas
								.Where(current => string.Compare(current.Area_Name, selectValueName) == 0)
								.FirstOrDefault();

				if (area != null)
				{
					var entry = dataBaseContext.Entry(area);

					if (entry.State == System.Data.Entity.EntityState.Detached)
					{
						dataBaseContext.Areas.Attach(area);
					}

					dataBaseContext.Areas.Remove(area);
					dataBaseContext.SaveChanges();

					System.Windows.Forms.MessageBox.Show($"{selectValueName} حذف شد!");
				}
			}
			else
			{
				return;
			}

			RefreshData();

			_upDateMode = false;
			
		}


		//-------------------Private Methods

		public string GetSelectItemValue()
		{
			return regionNameCheckedListBoxControl.GetItemText(regionNameCheckedListBoxControl.SelectedIndex).ToString();
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

		private void SearchItem(My_Region myRegion)
		{
			if (!string.IsNullOrWhiteSpace(myRegion.Region_Name))
			{
				dataBaseContext =
				new Models.DataBaseContext();

				if (_regionID == 2)
				{
					System.Collections.Generic.List<Models.State> listState = null;

					listState =
						dataBaseContext.States
						.Where(current => string.Compare(current.Country_Name, myRegion.Region_Name) == 0)
						.OrderBy(current => current.State_Name)
						.ToList();

					if (listState != null)
					{
						regionNameCheckedListBoxControl.DataSource = listState;

						regionNameCheckedListBoxControl.ValueMember = "State_Id";
						regionNameCheckedListBoxControl.DisplayMember = "State_Name";
					}
					else
					{
						return;
					}
				}
				else if (_regionID == 3)
				{
					System.Collections.Generic.List<Models.City> listCity = null;

					listCity =
						dataBaseContext.Cities
						.Where(current => string.Compare(current.State_Name, myRegion.Region_Name) == 0)
						.OrderBy(current => current.City_Name)
						.ToList();

					if (listCity != null)
					{
						regionNameCheckedListBoxControl.DataSource = listCity;

						regionNameCheckedListBoxControl.ValueMember = "City_Id";
						regionNameCheckedListBoxControl.DisplayMember = "City_Name";
					}
					else
					{
						return;
					}
				}
				else if (_regionID == 4)
				{
					System.Collections.Generic.List<Models.Area> listAreas = null;

					listAreas =
						dataBaseContext.Areas
						.Where(current => string.Compare(current.City_Name, myRegion.Region_Name) == 0)
						.OrderBy(current => current.Area_Name)
						.ToList();

					if (listAreas != null)
					{
						regionNameCheckedListBoxControl.DataSource = listAreas;

						regionNameCheckedListBoxControl.ValueMember = "Area_Id";
						regionNameCheckedListBoxControl.DisplayMember = "Area_Name";
					}
					else
					{
						return;
					}
				}
				else
				{
					RefreshData();
				}
			}
			else
			{
				RefreshData();
			}
		}

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

					//System.Windows.Forms.MessageBox.Show($"نام {inputValue} ثبت گردید.");

					RefreshData();

					inputTextBox.ResetText();
				}
			}
			else
			{
				System.Windows.Forms.MessageBox.Show($"شناسه درج شده در سیستم موجود نمیباشد.");
			}
		}

		private void SetRegion(string inputValue, My_Region myRegion)
		{
			int count = 0;

			dataBaseContext =
				new Models.DataBaseContext();

			if (_regionID == 2)
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
					System.Windows.Forms.MessageBox.Show($"نام {inputValue} در لیست استان ها موجود است");
					inputTextBox.Focus();
					return;
				}
				else
				{
					if (string.IsNullOrWhiteSpace(myRegion.Region_Name))
					{
						System.Windows.Forms.MessageBox.Show($"لطفا یک کشور را انتخاب کنید!");
						return;
					}
					else
					{
						state =
						new Models.State
						{
							State_Id = count + 1,
							State_Name = inputValue,
							Country_Name = myRegion.Region_Name,
						};

						dataBaseContext.States.Add(state);
						dataBaseContext.SaveChanges();

						//System.Windows.Forms.MessageBox.Show($"نام {inputValue} ثبت گردید.");

						RefreshData();

						inputTextBox.ResetText();

						myRegion = null;
					}
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
					System.Windows.Forms.MessageBox.Show($"نام {inputValue} در لیست شهرستان ها موجود است");
					inputTextBox.Focus();
					return;
				}
				else
				{
					if (string.IsNullOrWhiteSpace(myRegion.Region_Name))
					{
						System.Windows.Forms.MessageBox.Show($"لطفا یک استان را انتخاب کنید!");
					}
					else
					{
						city =
						new Models.City
						{
							City_Id = count + 1,
							City_Name = inputValue,
							State_Name = myRegion.Region_Name,
						};

						dataBaseContext.Cities.Add(city);
						dataBaseContext.SaveChanges();

						RefreshData();

						inputTextBox.ResetText();
						myRegion = null;
					}
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
					System.Windows.Forms.MessageBox.Show($"نام {inputValue} در لیست مناطق موجود است");
					inputTextBox.Focus();
					return;
				}
				else
				{
					if (string.IsNullOrWhiteSpace(myRegion.Region_Name))
					{
						System.Windows.Forms.MessageBox.Show($"لطفا یک شهرستان را انتخاب کنید!");
					}
					else
					{
						area =
						new Models.Area
						{
							Area_Id = count + 1,
							Area_Name = inputValue,
							City_Name = myRegion.Region_Name,
						};

						dataBaseContext.Areas.Add(area);
						dataBaseContext.SaveChanges();

						RefreshData();

						inputTextBox.ResetText();
						myRegion = null;
					}
				}
			}
			else
			{
				System.Windows.Forms.MessageBox.Show($"شناسه درج شده در سیستم موجود نمیباشد.");
			}
		}

		public void UpdateRegion(string inputValue, string oldValue, My_Region myRegion)
		{
			dataBaseContext =
				new Models.DataBaseContext();

			if (_regionID == 2)
			{
				System.Collections.Generic.List<Models.State> listState = null;

				listState =
					dataBaseContext.States
					.OrderBy(current => current.State_Id)
					.ToList();

				Models.State state =
					dataBaseContext.States
					.Where(current => current.State_Name == oldValue)
					.FirstOrDefault();

				state.State_Name = inputValue;
				state.Country_Name = myRegion.Region_Name;

				dataBaseContext.SaveChanges();

				System.Windows.Forms.MessageBox.Show("نام فایل تغییر یافت");

				_upDateMode = false;

				RefreshData();
			}
		}

		
	}
}
